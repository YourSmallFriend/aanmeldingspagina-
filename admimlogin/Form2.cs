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
            LoadCSVFile("Aameldingsformulier.csv");
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
                    richTextBox1.Clear();

                    // Read the CSV file
                    string[] lines = File.ReadAllLines(filePath);

                    // Display the contents in RichTextBox
                    foreach (string line in lines)
                    {
                        richTextBox1.AppendText(line + Environment.NewLine);
                    }
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
