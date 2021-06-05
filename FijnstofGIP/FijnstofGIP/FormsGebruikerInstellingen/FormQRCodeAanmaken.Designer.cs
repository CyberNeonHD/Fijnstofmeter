
namespace FijnstofGIP.FormsGebruikerInstellingen
{
    partial class FormQRCodeAanmaken
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
            this.components = new System.ComponentModel.Container();
            this.lbltitel = new System.Windows.Forms.Label();
            this.pnlWWCheckSectie = new System.Windows.Forms.Panel();
            this.btnLockWW = new FontAwesome.Sharp.IconPictureBox();
            this.btnOpenLockWW = new FontAwesome.Sharp.IconPictureBox();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.pnlWW = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.pnlSectieMakenQRCode = new System.Windows.Forms.Panel();
            this.QRBox = new FontAwesome.Sharp.IconPictureBox();
            this.btnAanmakenQR = new System.Windows.Forms.Button();
            this.btnQROpslaan = new System.Windows.Forms.Button();
            this.TipTxt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlWWCheckSectie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLockWW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenLockWW)).BeginInit();
            this.pnlSectieMakenQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).BeginInit();
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
            this.lbltitel.Size = new System.Drawing.Size(189, 34);
            this.lbltitel.TabIndex = 23;
            this.lbltitel.Text = "QR Code aanmaken";
            this.lbltitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlWWCheckSectie
            // 
            this.pnlWWCheckSectie.Controls.Add(this.btnLockWW);
            this.pnlWWCheckSectie.Controls.Add(this.btnOpenLockWW);
            this.pnlWWCheckSectie.Controls.Add(this.txtWW);
            this.pnlWWCheckSectie.Controls.Add(this.pnlWW);
            this.pnlWWCheckSectie.Controls.Add(this.label2);
            this.pnlWWCheckSectie.Controls.Add(this.btnBevestigen);
            this.pnlWWCheckSectie.Location = new System.Drawing.Point(205, 134);
            this.pnlWWCheckSectie.Name = "pnlWWCheckSectie";
            this.pnlWWCheckSectie.Size = new System.Drawing.Size(483, 128);
            this.pnlWWCheckSectie.TabIndex = 25;
            // 
            // btnLockWW
            // 
            this.btnLockWW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLockWW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLockWW.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLockWW.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnLockWW.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLockWW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLockWW.IconSize = 24;
            this.btnLockWW.Location = new System.Drawing.Point(279, 41);
            this.btnLockWW.Name = "btnLockWW";
            this.btnLockWW.Size = new System.Drawing.Size(24, 24);
            this.btnLockWW.TabIndex = 25;
            this.btnLockWW.TabStop = false;
            this.btnLockWW.Click += new System.EventHandler(this.btnLockWW_Click);
            this.btnLockWW.MouseHover += new System.EventHandler(this.btnLockWW_MouseHover);
            // 
            // btnOpenLockWW
            // 
            this.btnOpenLockWW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnOpenLockWW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenLockWW.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpenLockWW.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btnOpenLockWW.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpenLockWW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenLockWW.IconSize = 24;
            this.btnOpenLockWW.Location = new System.Drawing.Point(279, 41);
            this.btnOpenLockWW.Name = "btnOpenLockWW";
            this.btnOpenLockWW.Size = new System.Drawing.Size(24, 24);
            this.btnOpenLockWW.TabIndex = 26;
            this.btnOpenLockWW.TabStop = false;
            this.btnOpenLockWW.Click += new System.EventHandler(this.btnOpenLockWW_Click);
            this.btnOpenLockWW.MouseHover += new System.EventHandler(this.btnOpenLockWW_MouseHover);
            // 
            // txtWW
            // 
            this.txtWW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtWW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWW.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWW.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtWW.Location = new System.Drawing.Point(31, 45);
            this.txtWW.MaxLength = 28;
            this.txtWW.Multiline = true;
            this.txtWW.Name = "txtWW";
            this.txtWW.PasswordChar = '*';
            this.txtWW.Size = new System.Drawing.Size(246, 20);
            this.txtWW.TabIndex = 1;
            this.txtWW.Click += new System.EventHandler(this.txtWW_Click);
            this.txtWW.Enter += new System.EventHandler(this.txtWW_Enter);
            this.txtWW.Leave += new System.EventHandler(this.txtWW_Leave);
            // 
            // pnlWW
            // 
            this.pnlWW.BackColor = System.Drawing.Color.White;
            this.pnlWW.Location = new System.Drawing.Point(34, 64);
            this.pnlWW.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWW.Name = "pnlWW";
            this.pnlWW.Size = new System.Drawing.Size(242, 3);
            this.pnlWW.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(28, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vul hier uw huidig wachtwoord in";
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBevestigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBevestigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestigen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBevestigen.Location = new System.Drawing.Point(281, 79);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(138, 34);
            this.btnBevestigen.TabIndex = 2;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // pnlSectieMakenQRCode
            // 
            this.pnlSectieMakenQRCode.Controls.Add(this.QRBox);
            this.pnlSectieMakenQRCode.Controls.Add(this.btnAanmakenQR);
            this.pnlSectieMakenQRCode.Controls.Add(this.btnQROpslaan);
            this.pnlSectieMakenQRCode.Location = new System.Drawing.Point(173, 61);
            this.pnlSectieMakenQRCode.Name = "pnlSectieMakenQRCode";
            this.pnlSectieMakenQRCode.Size = new System.Drawing.Size(435, 347);
            this.pnlSectieMakenQRCode.TabIndex = 26;
            this.pnlSectieMakenQRCode.Visible = false;
            // 
            // QRBox
            // 
            this.QRBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.QRBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QRBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.QRBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.QRBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.QRBox.IconSize = 268;
            this.QRBox.Location = new System.Drawing.Point(69, 76);
            this.QRBox.Name = "QRBox";
            this.QRBox.Size = new System.Drawing.Size(318, 268);
            this.QRBox.TabIndex = 29;
            this.QRBox.TabStop = false;
            // 
            // btnAanmakenQR
            // 
            this.btnAanmakenQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAanmakenQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAanmakenQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAanmakenQR.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAanmakenQR.Location = new System.Drawing.Point(52, 17);
            this.btnAanmakenQR.Name = "btnAanmakenQR";
            this.btnAanmakenQR.Size = new System.Drawing.Size(129, 34);
            this.btnAanmakenQR.TabIndex = 28;
            this.btnAanmakenQR.Text = "Aanmaken";
            this.btnAanmakenQR.UseVisualStyleBackColor = true;
            this.btnAanmakenQR.Click += new System.EventHandler(this.btnAanmakenQR_Click);
            // 
            // btnQROpslaan
            // 
            this.btnQROpslaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQROpslaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQROpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQROpslaan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQROpslaan.Location = new System.Drawing.Point(276, 17);
            this.btnQROpslaan.Name = "btnQROpslaan";
            this.btnQROpslaan.Size = new System.Drawing.Size(129, 34);
            this.btnQROpslaan.TabIndex = 27;
            this.btnQROpslaan.Text = "Opslaan";
            this.btnQROpslaan.UseVisualStyleBackColor = true;
            this.btnQROpslaan.Click += new System.EventHandler(this.btnQROpslaan_Click);
            // 
            // FormQRCodeAanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(686, 461);
            this.Controls.Add(this.pnlWWCheckSectie);
            this.Controls.Add(this.pnlSectieMakenQRCode);
            this.Controls.Add(this.lbltitel);
            this.Name = "FormQRCodeAanmaken";
            this.Text = "FormQRCodeAanmaken";
            this.pnlWWCheckSectie.ResumeLayout(false);
            this.pnlWWCheckSectie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLockWW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenLockWW)).EndInit();
            this.pnlSectieMakenQRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Panel pnlWWCheckSectie;
        private FontAwesome.Sharp.IconPictureBox btnLockWW;
        private FontAwesome.Sharp.IconPictureBox btnOpenLockWW;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.Panel pnlWW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Panel pnlSectieMakenQRCode;
        private System.Windows.Forms.Button btnQROpslaan;
        private System.Windows.Forms.Button btnAanmakenQR;
        private FontAwesome.Sharp.IconPictureBox QRBox;
        private System.Windows.Forms.ToolTip TipTxt;
    }
}