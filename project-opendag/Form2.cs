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

namespace admimlogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadCSVFile("aanmeldingformulier.csv");
        }
        private void LoadCSVFile(string filename)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, filename);

                if (File.Exists(filePath))
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    string[] lines = File.ReadAllLines(filePath);

                    dataGridView1.Columns.Add("Naam", "Naam");
                    dataGridView1.Columns.Add("Tussenvoegsel", "Tussenvoegsel");
                    dataGridView1.Columns.Add("Achternaam", "Achternaam");
                    dataGridView1.Columns.Add("telefoonnummer", "telefoonnummer");
                    dataGridView1.Columns.Add("e-mail", "e-mail");
                    dataGridView1.Columns.Add("Datum", "Datum");

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 6)
                        {
                            string voornaam = parts[0];
                            string tussenvoegsel = parts[1];
                            string achternaam = parts[2];
                            string telefoonnummer = parts[3];
                            string mail = parts[4];
                            string datum = parts[5];

                            dataGridView1.Rows.Add(voornaam, tussenvoegsel, achternaam, telefoonnummer, mail, datum);
                        }
                    }
                    label1.Text = $"aantal aanmeldingen: {dataGridView1.Rows.Count - 1}";
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
    }
}
