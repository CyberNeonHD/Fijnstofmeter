
namespace FijnstofGIP.FormsGebruikerInstellingen
{
    partial class FormEmailVeranderen
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
            this.pnlWWCheckSectie = new System.Windows.Forms.Panel();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.pnlWW = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.btnGegevensOpslaan = new System.Windows.Forms.Button();
            this.lbltitel = new System.Windows.Forms.Label();
            this.pnlEmailSectie = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLockWW = new FontAwesome.Sharp.IconPictureBox();
            this.btnOpenLockWW = new FontAwesome.Sharp.IconPictureBox();
            this.TipTxt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlWWCheckSectie.SuspendLayout();
            this.pnlEmailSectie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLockWW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenLockWW)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWWCheckSectie
            // 
            this.pnlWWCheckSectie.Controls.Add(this.btnLockWW);
            this.pnlWWCheckSectie.Controls.Add(this.btnOpenLockWW);
            this.pnlWWCheckSectie.Controls.Add(this.txtWW);
            this.pnlWWCheckSectie.Controls.Add(this.pnlWW);
            this.pnlWWCheckSectie.Controls.Add(this.label2);
            this.pnlWWCheckSectie.Controls.Add(this.btnBevestigen);
            this.pnlWWCheckSectie.Location = new System.Drawing.Point(152, 150);
            this.pnlWWCheckSectie.Name = "pnlWWCheckSectie";
            this.pnlWWCheckSectie.Size = new System.Drawing.Size(425, 128);
            this.pnlWWCheckSectie.TabIndex = 24;
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
            // btnGegevensOpslaan
            // 
            this.btnGegevensOpslaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGegevensOpslaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGegevensOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGegevensOpslaan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGegevensOpslaan.Location = new System.Drawing.Point(448, 426);
            this.btnGegevensOpslaan.Name = "btnGegevensOpslaan";
            this.btnGegevensOpslaan.Size = new System.Drawing.Size(129, 34);
            this.btnGegevensOpslaan.TabIndex = 23;
            this.btnGegevensOpslaan.Text = "Opslaan";
            this.btnGegevensOpslaan.UseVisualStyleBackColor = true;
            this.btnGegevensOpslaan.Click += new System.EventHandler(this.btnGegevensOpslaan_Click);
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbltitel.Location = new System.Drawing.Point(265, 9);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltitel.Size = new System.Drawing.Size(169, 34);
            this.lbltitel.TabIndex = 22;
            this.lbltitel.Text = "Email veranderen";
            this.lbltitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlEmailSectie
            // 
            this.pnlEmailSectie.Controls.Add(this.txtEmail);
            this.pnlEmailSectie.Controls.Add(this.pnlEmail);
            this.pnlEmailSectie.Controls.Add(this.label1);
            this.pnlEmailSectie.Location = new System.Drawing.Point(152, 150);
            this.pnlEmailSectie.Name = "pnlEmailSectie";
            this.pnlEmailSectie.Size = new System.Drawing.Size(425, 128);
            this.pnlEmailSectie.TabIndex = 25;
            this.pnlEmailSectie.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.Location = new System.Drawing.Point(31, 45);
            this.txtEmail.MaxLength = 28;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Location = new System.Drawing.Point(34, 64);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(242, 3);
            this.pnlEmail.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vul hier uw nieuwe email in";
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
            // FormEmailVeranderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(686, 461);
            this.Controls.Add(this.btnGegevensOpslaan);
            this.Controls.Add(this.lbltitel);
            this.Controls.Add(this.pnlWWCheckSectie);
            this.Controls.Add(this.pnlEmailSectie);
            this.Name = "FormEmailVeranderen";
            this.Text = "FormEmailVeranderen";
            this.pnlWWCheckSectie.ResumeLayout(false);
            this.pnlWWCheckSectie.PerformLayout();
            this.pnlEmailSectie.ResumeLayout(false);
            this.pnlEmailSectie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLockWW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenLockWW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWWCheckSectie;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.Panel pnlWW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Button btnGegevensOpslaan;
        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Panel pnlEmailSectie;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox btnLockWW;
        private FontAwesome.Sharp.IconPictureBox btnOpenLockWW;
        private System.Windows.Forms.ToolTip TipTxt;
    }
}