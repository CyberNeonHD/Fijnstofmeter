
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
            this.SuspendLayout();
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbltitel.Location = new System.Drawing.Point(210, 9);
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
            this.btnGegevensOpslaan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGegevensOpslaan.Location = new System.Drawing.Point(437, 361);
            this.btnGegevensOpslaan.Name = "btnGegevensOpslaan";
            this.btnGegevensOpslaan.Size = new System.Drawing.Size(129, 34);
            this.btnGegevensOpslaan.TabIndex = 9;
            this.btnGegevensOpslaan.Text = "Opslaan";
            this.btnGegevensOpslaan.UseVisualStyleBackColor = true;
            this.btnGegevensOpslaan.Click += new System.EventHandler(this.btnGegevensOpslaan_Click);
            // 
            // FormGebruiksersNaamVeranderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(686, 407);
            this.Controls.Add(this.btnGegevensOpslaan);
            this.Controls.Add(this.lbltitel);
            this.Name = "FormGebruiksersNaamVeranderen";
            this.Text = "FormGebruiksersNaamVeranderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Button btnGegevensOpslaan;
    }
}