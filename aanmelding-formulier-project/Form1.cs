using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace aanmelding_formulier_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var standaardTXTsize = new System.Drawing.Font("Arial", 20);
            voornaamTXT.Font = standaardTXTsize;
            tussenvoegselTXT.Font = standaardTXTsize;
            achternaamTXT.Font = standaardTXTsize;
        }

        private void aanmeldBTN_Click(object sender, EventArgs e)
        {
            string filePath = "aanmeldingformulier.csv";
            string content = string.Format("\n{0},{1},{2},{3:yyyy-MM-dd}", voornaamTXT.Text, tussenvoegselTXT.Text, achternaamTXT.Text, dateTimePicker1.Value);
            try
            {
                if (File.Exists(filePath))
                {
                    File.AppendAllText(filePath, content);
                }
                else
                {
                    File.WriteAllText(filePath, content);
                }
                voornaamTXT.Clear();
                tussenvoegselTXT.Clear();
                achternaamTXT.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the CSV content: {ex.Message}");
            }
        }
    }
}
