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
            string content = string.Format("\n{0},{1},{2}", voornaamTXT.Text, tussenvoegselTXT.Text, achternaamTXT.Text);
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

                MessageBox.Show("CSV content is opgeslagen!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the CSV content: {ex.Message}");
            }
        }


    }
}