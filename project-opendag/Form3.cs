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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var standaardTXTsize = new System.Drawing.Font("Arial", 15);
            voornaamTXT.Font = standaardTXTsize;
            tussenvoegselTXT.Font = standaardTXTsize;
            achternaamTXT.Font = standaardTXTsize;
            telefoonnummerTXT.Font = standaardTXTsize;
            mailTXT.Font = standaardTXTsize;
        }

        private void aanmeldBTN_Click(object sender, EventArgs e)
        {
            string filePath = "aanmeldingformulier.csv";
            string content = string.Format("\n{0},{1},{2},{3},{4},{5:yyyy-MM-dd}", voornaamTXT.Text, tussenvoegselTXT.Text, achternaamTXT.Text,telefoonnummerTXT.Text, mailTXT.Text, dateTimePicker1.Value);
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
                telefoonnummerTXT.Clear();
                mailTXT.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the CSV content: {ex.Message}");
            }
        }
    }
}
