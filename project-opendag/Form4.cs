using admimlogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace project_opendag
{
    public partial class Form4 : Form
    {
        private const string correctGebruikersnaam = "admin";
        private const string correctWachtwoord = "admin";
        private int kansen = 0;
        private DateTime lockoutEindTijd;

        public Form4()
        {
            InitializeComponent();
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
                this.Hide();
                Form2 adminscherm = new Form2();
                adminscherm.ShowDialog();
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
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                wachtwoordTXT.UseSystemPasswordChar = true;
            }
            else
            {
                wachtwoordTXT.UseSystemPasswordChar = false;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            wachtwoordTXT.UseSystemPasswordChar = false;
        }
    }
}
