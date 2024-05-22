using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.DataVisualization.Charting;


namespace admimlogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadCSVFile("aanmeldingformulier.csv");
            DisplayChartFromGrid();
        }

        public void LoadCSVFile(string filename)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, filename);

                if (File.Exists(filePath))
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    string[] lines = File.ReadAllLines(filePath);

                    dataGridView1.Columns.Add("Opleiding", "Opleiding");
                    dataGridView1.Columns.Add("Naam", "Naam");
                    dataGridView1.Columns.Add("Tussenvoegsel", "Tussenvoegsel");
                    dataGridView1.Columns.Add("Achternaam", "Achternaam");
                    dataGridView1.Columns.Add("Telefoonnummer", "Telefoonnummer");
                    dataGridView1.Columns.Add("E-mail", "E-mail");
                    dataGridView1.Columns.Add("Datum", "Datum");

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 7)
                        {
                            string opleiding = parts[0];
                            string voornaam = parts[1];
                            string tussenvoegsel = parts[2];
                            string achternaam = parts[3];
                            string telefoonnummer = parts[4];
                            string mail = parts[5];
                            string datum = parts[6];

                            dataGridView1.Rows.Add(opleiding,voornaam, tussenvoegsel, achternaam, telefoonnummer, mail, datum);
                        }
                    }
                    label1.Text = $"Aantal aanmeldingen: {dataGridView1.Rows.Count - 1}";
                }
                else
                {
                    MessageBox.Show("File not found: " + filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void DisplayChartFromGrid()
        {
            chart1.Series.Clear();
            var series = chart1.Series.Add("Kandidaten");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            Dictionary<string, int> datumCountsFromGrid = new Dictionary<string, int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string datum = row.Cells["Datum"].Value.ToString();
                    if (datumCountsFromGrid.ContainsKey(datum))
                    {
                        datumCountsFromGrid[datum]++;
                    }
                    else
                    {
                        datumCountsFromGrid[datum] = 1;
                    }
                }
            }

            foreach (var kvp in datumCountsFromGrid)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
        }
    }
}
