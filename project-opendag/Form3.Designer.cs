﻿namespace admimlogin
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
            this.mailTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telefoonnummerTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Location = new System.Drawing.Point(447, 188);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 4, 25, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 25, 14, 1, 32, 0);
            // 
            // aanmeldBTN
            // 
            this.aanmeldBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aanmeldBTN.Location = new System.Drawing.Point(447, 247);
            this.aanmeldBTN.Name = "aanmeldBTN";
            this.aanmeldBTN.Size = new System.Drawing.Size(364, 46);
            this.aanmeldBTN.TabIndex = 14;
            this.aanmeldBTN.Text = "aanmelden";
            this.aanmeldBTN.UseVisualStyleBackColor = true;
            this.aanmeldBTN.Click += new System.EventHandler(this.aanmeldBTN_Click);
            // 
            // achternaamLBL
            // 
            this.achternaamLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.achternaamLBL.AutoSize = true;
            this.achternaamLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achternaamLBL.Location = new System.Drawing.Point(3, 215);
            this.achternaamLBL.Name = "achternaamLBL";
            this.achternaamLBL.Size = new System.Drawing.Size(138, 29);
            this.achternaamLBL.TabIndex = 13;
            this.achternaamLBL.Text = "achternaam";
            // 
            // achternaamTXT
            // 
            this.achternaamTXT.Location = new System.Drawing.Point(3, 247);
            this.achternaamTXT.Multiline = true;
            this.achternaamTXT.Name = "achternaamTXT";
            this.achternaamTXT.Size = new System.Drawing.Size(374, 46);
            this.achternaamTXT.TabIndex = 12;
            // 
            // tussenvoegselLBL
            // 
            this.tussenvoegselLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tussenvoegselLBL.AutoSize = true;
            this.tussenvoegselLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tussenvoegselLBL.Location = new System.Drawing.Point(3, 105);
            this.tussenvoegselLBL.Name = "tussenvoegselLBL";
            this.tussenvoegselLBL.Size = new System.Drawing.Size(168, 29);
            this.tussenvoegselLBL.TabIndex = 11;
            this.tussenvoegselLBL.Text = "tussenvoegsel";
            // 
            // tussenvoegselTXT
            // 
            this.tussenvoegselTXT.Location = new System.Drawing.Point(3, 137);
            this.tussenvoegselTXT.Multiline = true;
            this.tussenvoegselTXT.Name = "tussenvoegselTXT";
            this.tussenvoegselTXT.Size = new System.Drawing.Size(374, 45);
            this.tussenvoegselTXT.TabIndex = 10;
            // 
            // voornaamLBL
            // 
            this.voornaamLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voornaamLBL.AutoSize = true;
            this.voornaamLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voornaamLBL.Location = new System.Drawing.Point(3, 10);
            this.voornaamLBL.Name = "voornaamLBL";
            this.voornaamLBL.Size = new System.Drawing.Size(119, 29);
            this.voornaamLBL.TabIndex = 9;
            this.voornaamLBL.Text = "voornaam";
            // 
            // voornaamTXT
            // 
            this.voornaamTXT.Location = new System.Drawing.Point(3, 42);
            this.voornaamTXT.Multiline = true;
            this.voornaamTXT.Name = "voornaamTXT";
            this.voornaamTXT.Size = new System.Drawing.Size(374, 43);
            this.voornaamTXT.TabIndex = 8;
            // 
            // mailTXT
            // 
            this.mailTXT.Location = new System.Drawing.Point(447, 137);
            this.mailTXT.Multiline = true;
            this.mailTXT.Name = "mailTXT";
            this.mailTXT.Size = new System.Drawing.Size(364, 45);
            this.mailTXT.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "e-mail adress";
            // 
            // telefoonnummerTXT
            // 
            this.telefoonnummerTXT.Location = new System.Drawing.Point(447, 42);
            this.telefoonnummerTXT.Multiline = true;
            this.telefoonnummerTXT.Name = "telefoonnummerTXT";
            this.telefoonnummerTXT.Size = new System.Drawing.Size(364, 43);
            this.telefoonnummerTXT.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "telefoonnummer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.61441F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.38559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.voornaamLBL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.voornaamTXT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.achternaamTXT, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.achternaamLBL, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tussenvoegselLBL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tussenvoegselTXT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.telefoonnummerTXT, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.mailTXT, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.aanmeldBTN, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(132, 233);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.63277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.36723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 509F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 754);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(221, 75);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::project_opendag.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_opendag.Properties.Resources.huawei_nova_8_pro_bubble_circle_white_background_purple_2560x1080_3962;
            this.ClientSize = new System.Drawing.Size(1090, 930);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox mailTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefoonnummerTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}