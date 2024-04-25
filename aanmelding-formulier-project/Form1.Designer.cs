namespace aanmelding_formulier_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.voornaamTXT = new System.Windows.Forms.TextBox();
            this.voornaamLBL = new System.Windows.Forms.Label();
            this.tussenvoegselLBL = new System.Windows.Forms.Label();
            this.tussenvoegselTXT = new System.Windows.Forms.TextBox();
            this.achternaamLBL = new System.Windows.Forms.Label();
            this.achternaamTXT = new System.Windows.Forms.TextBox();
            this.aanmeldBTN = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // voornaamTXT
            // 
            this.voornaamTXT.Location = new System.Drawing.Point(13, 57);
            this.voornaamTXT.Multiline = true;
            this.voornaamTXT.Name = "voornaamTXT";
            this.voornaamTXT.Size = new System.Drawing.Size(360, 47);
            this.voornaamTXT.TabIndex = 0;
            // 
            // voornaamLBL
            // 
            this.voornaamLBL.AutoSize = true;
            this.voornaamLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voornaamLBL.Location = new System.Drawing.Point(12, 25);
            this.voornaamLBL.Name = "voornaamLBL";
            this.voornaamLBL.Size = new System.Drawing.Size(119, 29);
            this.voornaamLBL.TabIndex = 1;
            this.voornaamLBL.Text = "voornaam";
            // 
            // tussenvoegselLBL
            // 
            this.tussenvoegselLBL.AutoSize = true;
            this.tussenvoegselLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tussenvoegselLBL.Location = new System.Drawing.Point(11, 113);
            this.tussenvoegselLBL.Name = "tussenvoegselLBL";
            this.tussenvoegselLBL.Size = new System.Drawing.Size(168, 29);
            this.tussenvoegselLBL.TabIndex = 3;
            this.tussenvoegselLBL.Text = "tussenvoegsel";
            // 
            // tussenvoegselTXT
            // 
            this.tussenvoegselTXT.Location = new System.Drawing.Point(12, 145);
            this.tussenvoegselTXT.Multiline = true;
            this.tussenvoegselTXT.Name = "tussenvoegselTXT";
            this.tussenvoegselTXT.Size = new System.Drawing.Size(360, 47);
            this.tussenvoegselTXT.TabIndex = 2;
            // 
            // achternaamLBL
            // 
            this.achternaamLBL.AutoSize = true;
            this.achternaamLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achternaamLBL.Location = new System.Drawing.Point(12, 205);
            this.achternaamLBL.Name = "achternaamLBL";
            this.achternaamLBL.Size = new System.Drawing.Size(138, 29);
            this.achternaamLBL.TabIndex = 5;
            this.achternaamLBL.Text = "achternaam";
            // 
            // achternaamTXT
            // 
            this.achternaamTXT.Location = new System.Drawing.Point(13, 237);
            this.achternaamTXT.Multiline = true;
            this.achternaamTXT.Name = "achternaamTXT";
            this.achternaamTXT.Size = new System.Drawing.Size(360, 47);
            this.achternaamTXT.TabIndex = 4;
            // 
            // aanmeldBTN
            // 
            this.aanmeldBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aanmeldBTN.Location = new System.Drawing.Point(537, 361);
            this.aanmeldBTN.Name = "aanmeldBTN";
            this.aanmeldBTN.Size = new System.Drawing.Size(238, 68);
            this.aanmeldBTN.TabIndex = 6;
            this.aanmeldBTN.Text = "aanmelden";
            this.aanmeldBTN.UseVisualStyleBackColor = true;
            this.aanmeldBTN.Click += new System.EventHandler(this.aanmeldBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aanmeldBTN);
            this.Controls.Add(this.achternaamLBL);
            this.Controls.Add(this.achternaamTXT);
            this.Controls.Add(this.tussenvoegselLBL);
            this.Controls.Add(this.tussenvoegselTXT);
            this.Controls.Add(this.voornaamLBL);
            this.Controls.Add(this.voornaamTXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox voornaamTXT;
        private System.Windows.Forms.Label voornaamLBL;
        private System.Windows.Forms.Label tussenvoegselLBL;
        private System.Windows.Forms.TextBox tussenvoegselTXT;
        private System.Windows.Forms.Label achternaamLBL;
        private System.Windows.Forms.TextBox achternaamTXT;
        private System.Windows.Forms.Button aanmeldBTN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

