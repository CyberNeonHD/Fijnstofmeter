
namespace FijnstofGIP.FormsGebruikerInstellingen
{
    partial class FormAdresVeranderen
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
            this.lbltitel = new System.Windows.Forms.Label();
            this.btnGegevensOpslaan = new System.Windows.Forms.Button();
            this.txtGemeente = new System.Windows.Forms.TextBox();
            this.pnlgemeente = new System.Windows.Forms.Panel();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.pnlpostcode = new System.Windows.Forms.Panel();
            this.txtHuisNummer = new System.Windows.Forms.TextBox();
            this.pnlhuisnummer = new System.Windows.Forms.Panel();
            this.txtStraat = new System.Windows.Forms.TextBox();
            this.pnlstraat = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbltitel.Location = new System.Drawing.Point(288, -2);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltitel.Size = new System.Drawing.Size(173, 34);
            this.lbltitel.TabIndex = 3;
            this.lbltitel.Text = "Adres veranderen";
            this.lbltitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGegevensOpslaan
            // 
            this.btnGegevensOpslaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGegevensOpslaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGegevensOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGegevensOpslaan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGegevensOpslaan.Location = new System.Drawing.Point(477, 426);
            this.btnGegevensOpslaan.Name = "btnGegevensOpslaan";
            this.btnGegevensOpslaan.Size = new System.Drawing.Size(129, 34);
            this.btnGegevensOpslaan.TabIndex = 7;
            this.btnGegevensOpslaan.Text = "Opslaan";
            this.btnGegevensOpslaan.UseVisualStyleBackColor = true;
            this.btnGegevensOpslaan.Click += new System.EventHandler(this.btnGegevensOpslaan_Click);
            // 
            // txtGemeente
            // 
            this.txtGemeente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtGemeente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGemeente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGemeente.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGemeente.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtGemeente.Location = new System.Drawing.Point(166, 266);
            this.txtGemeente.MaxLength = 27;
            this.txtGemeente.Multiline = true;
            this.txtGemeente.Name = "txtGemeente";
            this.txtGemeente.Size = new System.Drawing.Size(240, 20);
            this.txtGemeente.TabIndex = 18;
            this.txtGemeente.Click += new System.EventHandler(this.txtGemeente_Click);
            this.txtGemeente.Enter += new System.EventHandler(this.txtGemeente_Enter);
            this.txtGemeente.Leave += new System.EventHandler(this.txtGemeente_Leave);
            // 
            // pnlgemeente
            // 
            this.pnlgemeente.BackColor = System.Drawing.Color.White;
            this.pnlgemeente.Location = new System.Drawing.Point(171, 285);
            this.pnlgemeente.Margin = new System.Windows.Forms.Padding(0);
            this.pnlgemeente.Name = "pnlgemeente";
            this.pnlgemeente.Size = new System.Drawing.Size(226, 3);
            this.pnlgemeente.TabIndex = 12;
            // 
            // txtPostcode
            // 
            this.txtPostcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostcode.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPostcode.Location = new System.Drawing.Point(495, 266);
            this.txtPostcode.MaxLength = 4;
            this.txtPostcode.Multiline = true;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(78, 20);
            this.txtPostcode.TabIndex = 19;
            this.txtPostcode.Click += new System.EventHandler(this.txtPostcode_Click);
            this.txtPostcode.Enter += new System.EventHandler(this.txtPostcode_Enter);
            this.txtPostcode.Leave += new System.EventHandler(this.txtPostcode_Leave);
            // 
            // pnlpostcode
            // 
            this.pnlpostcode.BackColor = System.Drawing.Color.White;
            this.pnlpostcode.Location = new System.Drawing.Point(498, 285);
            this.pnlpostcode.Margin = new System.Windows.Forms.Padding(0);
            this.pnlpostcode.Name = "pnlpostcode";
            this.pnlpostcode.Size = new System.Drawing.Size(74, 3);
            this.pnlpostcode.TabIndex = 13;
            // 
            // txtHuisNummer
            // 
            this.txtHuisNummer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtHuisNummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHuisNummer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHuisNummer.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuisNummer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtHuisNummer.Location = new System.Drawing.Point(496, 155);
            this.txtHuisNummer.MaxLength = 5;
            this.txtHuisNummer.Multiline = true;
            this.txtHuisNummer.Name = "txtHuisNummer";
            this.txtHuisNummer.Size = new System.Drawing.Size(77, 20);
            this.txtHuisNummer.TabIndex = 17;
            this.txtHuisNummer.Click += new System.EventHandler(this.txtHuisNummer_Click);
            this.txtHuisNummer.Enter += new System.EventHandler(this.txtHuisNummer_Enter);
            this.txtHuisNummer.Leave += new System.EventHandler(this.txtHuisNummer_Leave);
            // 
            // pnlhuisnummer
            // 
            this.pnlhuisnummer.BackColor = System.Drawing.Color.White;
            this.pnlhuisnummer.Location = new System.Drawing.Point(499, 174);
            this.pnlhuisnummer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlhuisnummer.Name = "pnlhuisnummer";
            this.pnlhuisnummer.Size = new System.Drawing.Size(73, 3);
            this.pnlhuisnummer.TabIndex = 14;
            // 
            // txtStraat
            // 
            this.txtStraat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtStraat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStraat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStraat.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStraat.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtStraat.Location = new System.Drawing.Point(166, 155);
            this.txtStraat.MaxLength = 27;
            this.txtStraat.Multiline = true;
            this.txtStraat.Name = "txtStraat";
            this.txtStraat.Size = new System.Drawing.Size(240, 20);
            this.txtStraat.TabIndex = 15;
            this.txtStraat.Click += new System.EventHandler(this.txtStraat_Click);
            this.txtStraat.Enter += new System.EventHandler(this.txtStraat_Enter);
            this.txtStraat.Leave += new System.EventHandler(this.txtStraat_Leave);
            // 
            // pnlstraat
            // 
            this.pnlstraat.BackColor = System.Drawing.Color.White;
            this.pnlstraat.Location = new System.Drawing.Point(171, 174);
            this.pnlstraat.Margin = new System.Windows.Forms.Padding(0);
            this.pnlstraat.Name = "pnlstraat";
            this.pnlstraat.Size = new System.Drawing.Size(226, 3);
            this.pnlstraat.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(166, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gemeente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(492, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Postcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(493, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(166, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Straat";
            // 
            // FormAdresVeranderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(686, 461);
            this.Controls.Add(this.txtGemeente);
            this.Controls.Add(this.pnlgemeente);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.pnlpostcode);
            this.Controls.Add(this.txtHuisNummer);
            this.Controls.Add(this.pnlhuisnummer);
            this.Controls.Add(this.txtStraat);
            this.Controls.Add(this.pnlstraat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGegevensOpslaan);
            this.Controls.Add(this.lbltitel);
            this.Name = "FormAdresVeranderen";
            this.Text = "FormAdresVeranderen";
            this.Load += new System.EventHandler(this.FormAdresVeranderen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Button btnGegevensOpslaan;
        private System.Windows.Forms.TextBox txtGemeente;
        private System.Windows.Forms.Panel pnlgemeente;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Panel pnlpostcode;
        private System.Windows.Forms.TextBox txtHuisNummer;
        private System.Windows.Forms.Panel pnlhuisnummer;
        private System.Windows.Forms.TextBox txtStraat;
        private System.Windows.Forms.Panel pnlstraat;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}