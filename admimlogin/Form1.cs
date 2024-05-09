using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admimlogin
{
    public partial class Form1 : Form
    {
        private const string correctGebruikersnaam = "Samuel";
        private const string correctWachtwoord = "1234";
        private int kansen = 0;
        private DateTime lockoutEindTijd;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                wachtwoordTXT.UseSystemPasswordChar = true;
            }
            else
            {
                wachtwoordTXT.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.Now < lockoutEindTijd)
            {
                TimeSpan remainingTime = lockoutEindTijd - DateTime.Now;
                string remainingTimeString = string.Format("{0}:{1:00}", remainingTime.Minutes, remainingTime.Seconds);
                MessageBox.Show($"Je moet nog {remainingTimeString} wachten voordat je opnieuw kunt proberen in te loggen.");
                return;
            }

            if (gebruikersnaamTXT.Text == correctGebruikersnaam && wachtwoordTXT.Text == correctWachtwoord)
            {
                Application.Exit();
            }
            else
            {
                gebruikersnaamTXT.Clear();
                wachtwoordTXT.Clear();
                kansen++;

                if (kansen == 1)
                {
                    MessageBox.Show("De combinatie van gebruikersnaam en wachtwoord is incorrect. Je hebt nog 2 pogingen over.");
                }
                else if (kansen == 2)
                {
                    MessageBox.Show("De combinatie van gebruikersnaam en wachtwoord is incorrect. Je hebt nog 1 poging over.");
                }
                else if (kansen >= 3)
                {
                    lockoutEindTijd = DateTime.Now.AddMinutes(3);
                    MessageBox.Show($"Te veel mislukte pogingen. Je moet 3 minuten wachten voordat je opnieuw kunt proberen in te loggen.");
                }
            }
        }
    }
}
