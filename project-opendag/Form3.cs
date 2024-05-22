using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace admimlogin
{
    public partial class Form3 : Form
    {
        public string opleiding = "";
        private ErrorProvider errorProvider;

        public Form3()
        {
            InitializeComponent();
            var standaardTXTsize = new System.Drawing.Font("Arial", 15);
            voornaamTXT.Font = standaardTXTsize;
            achternaamTXT.Font = standaardTXTsize;
            telefoonnummerTXT.Font = standaardTXTsize;
            mailTXT.Font = standaardTXTsize;

            // Initialisatie van ErrorProvider
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void aanmeldBTN_Click(object sender, EventArgs e)
        {
            if (!ict3.Checked && !ict4.Checked && !dev.Checked)
            {
                errorProvider.SetError(opleidingLBL, "Selecteer een opleiding.");
                return;
            }
            else
            {
                errorProvider.SetError(opleidingLBL, "");
            }

            if (ict3.Checked)
            {
                opleiding = "ICT niveau 3";
            }
            else if (ict4.Checked)
            {
                opleiding = "ICT niveau 4";
            }
            else if (dev.Checked)
            {
                opleiding = "Dev";
            }

            // Validatie van voornaam
            if (!Regex.IsMatch(voornaamTXT.Text, "^[a-zA-Z]+$"))
            {
                errorProvider.SetError(voornaamTXT, "Voer een geldige voornaam in.");
                return;
            }
            else
            {
                errorProvider.SetError(voornaamTXT, "");
            }

            // Validatie van achternaam
            if (!Regex.IsMatch(achternaamTXT.Text, "^[a-zA-Z]+$"))
            {
                errorProvider.SetError(achternaamTXT, "Voer een geldige achternaam in.");
                return;
            }
            else
            {
                errorProvider.SetError(achternaamTXT, "");
            }

            // Validatie van telefoonnummer
            if (!Regex.IsMatch(telefoonnummerTXT.Text, "^06[0-9]{8}$"))
            {
                errorProvider.SetError(telefoonnummerTXT, "Voer een geldig telefoonnummer in dat begint met '06' en daarna nog 8 cijfers heeft.");
                return;
            }
            else
            {
                errorProvider.SetError(telefoonnummerTXT, "");
            }

            // Validatie van e-mailadres
            if (string.IsNullOrWhiteSpace(mailTXT.Text))
            {
                errorProvider.SetError(mailTXT, "Voer een e-mailadres in.");
                return;
            }
            else if (!IsValidEmail(mailTXT.Text))
            {
                errorProvider.SetError(mailTXT, "Voer een geldig e-mailadres in.");
                return;
            }
            else
            {
                errorProvider.SetError(mailTXT, "");
            }

            string filePath = "aanmeldingformulier.csv";
            string content = string.Format("\n{0},{1},{2},{3},{4},{5},{6:yyyy-MM-dd}", opleiding, voornaamTXT.Text, "", achternaamTXT.Text, telefoonnummerTXT.Text, mailTXT.Text, dateTimePicker1.Value);
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
                achternaamTXT.Clear();
                telefoonnummerTXT.Clear();
                mailTXT.Clear();
                dev.Checked = false;
                ict3.Checked = false;
                ict4.Checked = false;
                MessageBox.Show("De aanmelding is opgeslagen");
            }
            catch
            {
                MessageBox.Show("Er was een probleem met het opslaan van de data");
            }
        }

        // Methode om de geldigheid van een e-mailadres te controleren
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
