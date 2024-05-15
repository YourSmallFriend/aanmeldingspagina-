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

                // Check if file exists
                if (File.Exists(filePath))
                {
                    // Clear existing content
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    // Read the CSV file
                    string[] lines = File.ReadAllLines(filePath);

                    // Add columns
                    dataGridView1.Columns.Add("Name", "Name");
                    dataGridView1.Columns.Add("MiddleName", "Middle Name");
                    dataGridView1.Columns.Add("LastName", "Last Name");
                    dataGridView1.Columns.Add("Date", "Date");

                    // Display the contents in DataGridView
                    foreach (string line in lines)
                    {
                        // Split the line into parts
                        string[] parts = line.Split(',');

                        // Check if line has enough parts
                        if (parts.Length >= 4)
                        {
                            string firstName = parts[0];
                            string middleName = parts[1];
                            string lastName = parts[2];
                            string date = parts[3];

                            // Add row to DataGridView
                            dataGridView1.Rows.Add(firstName, middleName, lastName, date);
                        }
                    }

                    // Update label with the count of people
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
