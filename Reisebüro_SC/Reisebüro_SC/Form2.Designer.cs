namespace Reisebüro_SC
{
    partial class Buchung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buchung));
            this.persönliche_angaben = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnredeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VornameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NachnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GeburtsdatumBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonnummerBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buchen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.E_Mail_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // persönliche_angaben
            // 
            this.persönliche_angaben.AutoSize = true;
            this.persönliche_angaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persönliche_angaben.Location = new System.Drawing.Point(128, 18);
            this.persönliche_angaben.Name = "persönliche_angaben";
            this.persönliche_angaben.Size = new System.Drawing.Size(179, 20);
            this.persönliche_angaben.TabIndex = 0;
            this.persönliche_angaben.Text = "Persönliche Angaben";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anrede *";
            // 
            // AnredeBox
            // 
            this.AnredeBox.FormattingEnabled = true;
            this.AnredeBox.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.AnredeBox.Location = new System.Drawing.Point(144, 75);
            this.AnredeBox.Name = "AnredeBox";
            this.AnredeBox.Size = new System.Drawing.Size(156, 28);
            this.AnredeBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vorname *";
            // 
            // VornameBox
            // 
            this.VornameBox.Location = new System.Drawing.Point(144, 120);
            this.VornameBox.Name = "VornameBox";
            this.VornameBox.Size = new System.Drawing.Size(156, 26);
            this.VornameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nachname *";
            // 
            // NachnameBox
            // 
            this.NachnameBox.Location = new System.Drawing.Point(144, 170);
            this.NachnameBox.Name = "NachnameBox";
            this.NachnameBox.Size = new System.Drawing.Size(156, 26);
            this.NachnameBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Geburtsdatum *";
            // 
            // GeburtsdatumBox
            // 
            this.GeburtsdatumBox.Location = new System.Drawing.Point(144, 215);
            this.GeburtsdatumBox.Mask = "00/00/0000";
            this.GeburtsdatumBox.Name = "GeburtsdatumBox";
            this.GeburtsdatumBox.Size = new System.Drawing.Size(156, 26);
            this.GeburtsdatumBox.TabIndex = 9;
            this.GeburtsdatumBox.ValidatingType = typeof(System.DateTime);
            // 
            // TelefonnummerBox
            // 
            this.TelefonnummerBox.Location = new System.Drawing.Point(144, 256);
            this.TelefonnummerBox.Name = "TelefonnummerBox";
            this.TelefonnummerBox.Size = new System.Drawing.Size(156, 26);
            this.TelefonnummerBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefonnummer *";
            // 
            // buchen
            // 
            this.buchen.Location = new System.Drawing.Point(232, 366);
            this.buchen.Name = "buchen";
            this.buchen.Size = new System.Drawing.Size(75, 26);
            this.buchen.TabIndex = 12;
            this.buchen.Text = "buchen";
            this.buchen.UseVisualStyleBackColor = true;
            this.buchen.Click += new System.EventHandler(this.buchen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "E-Mail-Adresse *";
            // 
            // E_Mail_Box
            // 
            this.E_Mail_Box.Location = new System.Drawing.Point(144, 304);
            this.E_Mail_Box.Name = "E_Mail_Box";
            this.E_Mail_Box.Size = new System.Drawing.Size(156, 26);
            this.E_Mail_Box.TabIndex = 14;
            // 
            // Buchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(813, 564);
            this.Controls.Add(this.E_Mail_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buchen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelefonnummerBox);
            this.Controls.Add(this.GeburtsdatumBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NachnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VornameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnredeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.persönliche_angaben);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buchung";
            this.Text = "Buchung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label persönliche_angaben;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AnredeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VornameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NachnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox GeburtsdatumBox;
        private System.Windows.Forms.MaskedTextBox TelefonnummerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buchen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox E_Mail_Box;
    }
}