namespace admimlogin
{
    partial class Form3
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.aanmeldBTN = new System.Windows.Forms.Button();
            this.achternaamLBL = new System.Windows.Forms.Label();
            this.achternaamTXT = new System.Windows.Forms.TextBox();
            this.tussenvoegselLBL = new System.Windows.Forms.Label();
            this.tussenvoegselTXT = new System.Windows.Forms.TextBox();
            this.voornaamLBL = new System.Windows.Forms.Label();
            this.voornaamTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 80);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 4, 25, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 25, 14, 1, 32, 0);
            // 
            // aanmeldBTN
            // 
            this.aanmeldBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aanmeldBTN.Location = new System.Drawing.Point(544, 359);
            this.aanmeldBTN.Name = "aanmeldBTN";
            this.aanmeldBTN.Size = new System.Drawing.Size(238, 68);
            this.aanmeldBTN.TabIndex = 14;
            this.aanmeldBTN.Text = "aanmelden";
            this.aanmeldBTN.UseVisualStyleBackColor = true;
            this.aanmeldBTN.Click += new System.EventHandler(this.aanmeldBTN_Click);
            // 
            // achternaamLBL
            // 
            this.achternaamLBL.AutoSize = true;
            this.achternaamLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achternaamLBL.Location = new System.Drawing.Point(19, 203);
            this.achternaamLBL.Name = "achternaamLBL";
            this.achternaamLBL.Size = new System.Drawing.Size(138, 29);
            this.achternaamLBL.TabIndex = 13;
            this.achternaamLBL.Text = "achternaam";
            // 
            // achternaamTXT
            // 
            this.achternaamTXT.Location = new System.Drawing.Point(20, 235);
            this.achternaamTXT.Multiline = true;
            this.achternaamTXT.Name = "achternaamTXT";
            this.achternaamTXT.Size = new System.Drawing.Size(360, 47);
            this.achternaamTXT.TabIndex = 12;
            // 
            // tussenvoegselLBL
            // 
            this.tussenvoegselLBL.AutoSize = true;
            this.tussenvoegselLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tussenvoegselLBL.Location = new System.Drawing.Point(18, 111);
            this.tussenvoegselLBL.Name = "tussenvoegselLBL";
            this.tussenvoegselLBL.Size = new System.Drawing.Size(168, 29);
            this.tussenvoegselLBL.TabIndex = 11;
            this.tussenvoegselLBL.Text = "tussenvoegsel";
            // 
            // tussenvoegselTXT
            // 
            this.tussenvoegselTXT.Location = new System.Drawing.Point(19, 143);
            this.tussenvoegselTXT.Multiline = true;
            this.tussenvoegselTXT.Name = "tussenvoegselTXT";
            this.tussenvoegselTXT.Size = new System.Drawing.Size(360, 47);
            this.tussenvoegselTXT.TabIndex = 10;
            // 
            // voornaamLBL
            // 
            this.voornaamLBL.AutoSize = true;
            this.voornaamLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voornaamLBL.Location = new System.Drawing.Point(19, 23);
            this.voornaamLBL.Name = "voornaamLBL";
            this.voornaamLBL.Size = new System.Drawing.Size(119, 29);
            this.voornaamLBL.TabIndex = 9;
            this.voornaamLBL.Text = "voornaam";
            // 
            // voornaamTXT
            // 
            this.voornaamTXT.Location = new System.Drawing.Point(20, 55);
            this.voornaamTXT.Multiline = true;
            this.voornaamTXT.Name = "voornaamTXT";
            this.voornaamTXT.Size = new System.Drawing.Size(360, 47);
            this.voornaamTXT.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.aanmeldBTN);
            this.Controls.Add(this.achternaamLBL);
            this.Controls.Add(this.achternaamTXT);
            this.Controls.Add(this.tussenvoegselLBL);
            this.Controls.Add(this.tussenvoegselTXT);
            this.Controls.Add(this.voornaamLBL);
            this.Controls.Add(this.voornaamTXT);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button aanmeldBTN;
        private System.Windows.Forms.Label achternaamLBL;
        private System.Windows.Forms.TextBox achternaamTXT;
        private System.Windows.Forms.Label tussenvoegselLBL;
        private System.Windows.Forms.TextBox tussenvoegselTXT;
        private System.Windows.Forms.Label voornaamLBL;
        private System.Windows.Forms.TextBox voornaamTXT;
    }
}