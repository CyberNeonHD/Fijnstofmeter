
namespace FijnstofGIP.FormsGebruikerInstellingen
{
    partial class FormGebruiksersNaamVeranderen
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
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.pnlgebruikersnaam = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbltitel.Size = new System.Drawing.Size(269, 34);
            this.lbltitel.TabIndex = 4;
            this.lbltitel.Text = "Gebruikersnaam veranderen";
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
            this.btnGegevensOpslaan.TabIndex = 9;
            this.btnGegevensOpslaan.Text = "Opslaan";
            this.btnGegevensOpslaan.UseVisualStyleBackColor = true;
            this.btnGegevensOpslaan.Click += new System.EventHandler(this.btnGegevensOpslaan_Click);
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtGebruikersnaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGebruikersnaam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikersnaam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtGebruikersnaam.Location = new System.Drawing.Point(288, 200);
            this.txtGebruikersnaam.MaxLength = 30;
            this.txtGebruikersnaam.Multiline = true;
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(240, 20);
            this.txtGebruikersnaam.TabIndex = 12;
            this.txtGebruikersnaam.Click += new System.EventHandler(this.txtGebruikersnaam_Click);
            this.txtGebruikersnaam.Enter += new System.EventHandler(this.txtGebruikersnaam_Enter);
            this.txtGebruikersnaam.Leave += new System.EventHandler(this.txtGebruikersnaam_Leave);
            // 
            // pnlgebruikersnaam
            // 
            this.pnlgebruikersnaam.BackColor = System.Drawing.Color.White;
            this.pnlgebruikersnaam.Location = new System.Drawing.Point(293, 219);
            this.pnlgebruikersnaam.Margin = new System.Windows.Forms.Padding(0);
            this.pnlgebruikersnaam.Name = "pnlgebruikersnaam";
            this.pnlgebruikersnaam.Size = new System.Drawing.Size(226, 3);
            this.pnlgebruikersnaam.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(289, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gebruikersnaam";
            // 
            // FormGebruiksersNaamVeranderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(686, 461);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.pnlgebruikersnaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGegevensOpslaan);
            this.Controls.Add(this.lbltitel);
            this.Name = "FormGebruiksersNaamVeranderen";
            this.Text = "FormGebruiksersNaamVeranderen";
            this.Load += new System.EventHandler(this.FormGebruiksersNaamVeranderen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Button btnGegevensOpslaan;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Panel pnlgebruikersnaam;
        private System.Windows.Forms.Label label2;
    }
}