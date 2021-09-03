
namespace FijnstofGIP
{
    partial class Aanmeldscherm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.pnlgebruikersnaam = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.pnlwachtwoord = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAanmelden = new System.Windows.Forms.Button();
            this.btnGeenAccount = new System.Windows.Forms.Button();
            this.btnWWVergeten = new System.Windows.Forms.Button();
            this.iconbtnLock = new FontAwesome.Sharp.IconPictureBox();
            this.iconbtnOpenLock = new FontAwesome.Sharp.IconPictureBox();
            this.btnQRCode = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnOpenLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aanmelden";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtGebruikersnaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGebruikersnaam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikersnaam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtGebruikersnaam.Location = new System.Drawing.Point(52, 129);
            this.txtGebruikersnaam.Multiline = true;
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(216, 20);
            this.txtGebruikersnaam.TabIndex = 1;
            this.txtGebruikersnaam.Click += new System.EventHandler(this.txtGebruikersnaam_Click);
            this.txtGebruikersnaam.Enter += new System.EventHandler(this.txtGebruikersnaam_Enter);
            this.txtGebruikersnaam.Leave += new System.EventHandler(this.txtGebruikersnaam_Leave);
            // 
            // pnlgebruikersnaam
            // 
            this.pnlgebruikersnaam.BackColor = System.Drawing.Color.White;
            this.pnlgebruikersnaam.Location = new System.Drawing.Point(55, 148);
            this.pnlgebruikersnaam.Margin = new System.Windows.Forms.Padding(0);
            this.pnlgebruikersnaam.Name = "pnlgebruikersnaam";
            this.pnlgebruikersnaam.Size = new System.Drawing.Size(212, 3);
            this.pnlgebruikersnaam.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gebruikersnaam";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtWachtwoord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWachtwoord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWachtwoord.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWachtwoord.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtWachtwoord.Location = new System.Drawing.Point(52, 221);
            this.txtWachtwoord.Multiline = true;
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(216, 20);
            this.txtWachtwoord.TabIndex = 2;
            this.txtWachtwoord.Click += new System.EventHandler(this.txtWachtwoord_Click);
            this.txtWachtwoord.Enter += new System.EventHandler(this.txtWachtwoord_Enter);
            this.txtWachtwoord.Leave += new System.EventHandler(this.txtWachtwoord_Leave);
            // 
            // pnlwachtwoord
            // 
            this.pnlwachtwoord.BackColor = System.Drawing.Color.White;
            this.pnlwachtwoord.Location = new System.Drawing.Point(55, 240);
            this.pnlwachtwoord.Margin = new System.Windows.Forms.Padding(0);
            this.pnlwachtwoord.Name = "pnlwachtwoord";
            this.pnlwachtwoord.Size = new System.Drawing.Size(212, 3);
            this.pnlwachtwoord.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(46, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Wachtwoord";
            // 
            // btnAanmelden
            // 
            this.btnAanmelden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAanmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAanmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAanmelden.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAanmelden.Location = new System.Drawing.Point(84, 281);
            this.btnAanmelden.Name = "btnAanmelden";
            this.btnAanmelden.Size = new System.Drawing.Size(140, 42);
            this.btnAanmelden.TabIndex = 3;
            this.btnAanmelden.Text = "Aanmelden";
            this.btnAanmelden.UseVisualStyleBackColor = true;
            this.btnAanmelden.Click += new System.EventHandler(this.btnAanmelden_Click);
            // 
            // btnGeenAccount
            // 
            this.btnGeenAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeenAccount.FlatAppearance.BorderSize = 0;
            this.btnGeenAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnGeenAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeenAccount.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeenAccount.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGeenAccount.Location = new System.Drawing.Point(78, 340);
            this.btnGeenAccount.Name = "btnGeenAccount";
            this.btnGeenAccount.Size = new System.Drawing.Size(154, 25);
            this.btnGeenAccount.TabIndex = 4;
            this.btnGeenAccount.Text = "Ik heb nog geen account";
            this.btnGeenAccount.UseVisualStyleBackColor = true;
            this.btnGeenAccount.Click += new System.EventHandler(this.btnGeenAccount_Click);
            this.btnGeenAccount.Enter += new System.EventHandler(this.btnGeenAccount_Enter);
            this.btnGeenAccount.Leave += new System.EventHandler(this.btnGeenAccount_Leave);
            this.btnGeenAccount.MouseEnter += new System.EventHandler(this.btnGeenAccount_Hover);
            this.btnGeenAccount.MouseLeave += new System.EventHandler(this.btnGeenAccount_GeenHover);
            // 
            // btnWWVergeten
            // 
            this.btnWWVergeten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWWVergeten.FlatAppearance.BorderSize = 0;
            this.btnWWVergeten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnWWVergeten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWWVergeten.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWWVergeten.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnWWVergeten.Location = new System.Drawing.Point(79, 360);
            this.btnWWVergeten.Name = "btnWWVergeten";
            this.btnWWVergeten.Size = new System.Drawing.Size(146, 25);
            this.btnWWVergeten.TabIndex = 5;
            this.btnWWVergeten.Text = "Wachtwoord vergeten?";
            this.btnWWVergeten.UseVisualStyleBackColor = true;
            this.btnWWVergeten.Click += new System.EventHandler(this.btnWWVergeten_Click);
            this.btnWWVergeten.Enter += new System.EventHandler(this.btnWWVergeten_Enter);
            this.btnWWVergeten.Leave += new System.EventHandler(this.btnWWVergeten_Leave);
            this.btnWWVergeten.MouseEnter += new System.EventHandler(this.btnWWVergeten_Hover);
            this.btnWWVergeten.MouseLeave += new System.EventHandler(this.btnWWVergeten_GeenHover);
            // 
            // iconbtnLock
            // 
            this.iconbtnLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconbtnLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnLock.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnLock.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconbtnLock.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnLock.IconSize = 24;
            this.iconbtnLock.Location = new System.Drawing.Point(240, 184);
            this.iconbtnLock.Name = "iconbtnLock";
            this.iconbtnLock.Size = new System.Drawing.Size(24, 24);
            this.iconbtnLock.TabIndex = 11;
            this.iconbtnLock.TabStop = false;
            this.iconbtnLock.Click += new System.EventHandler(this.iconbtnLock_Click);
            // 
            // iconbtnOpenLock
            // 
            this.iconbtnOpenLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconbtnOpenLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnOpenLock.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnOpenLock.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iconbtnOpenLock.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnOpenLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnOpenLock.IconSize = 24;
            this.iconbtnOpenLock.Location = new System.Drawing.Point(241, 184);
            this.iconbtnOpenLock.Name = "iconbtnOpenLock";
            this.iconbtnOpenLock.Size = new System.Drawing.Size(24, 24);
            this.iconbtnOpenLock.TabIndex = 12;
            this.iconbtnOpenLock.TabStop = false;
            this.iconbtnOpenLock.Click += new System.EventHandler(this.iconbtnOpenLock_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQRCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQRCode.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.btnQRCode.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQRCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQRCode.IconSize = 50;
            this.btnQRCode.Location = new System.Drawing.Point(266, 3);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(50, 50);
            this.btnQRCode.TabIndex = 13;
            this.btnQRCode.TabStop = false;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // Aanmeldscherm
            // 
            this.AcceptButton = this.btnAanmelden;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(318, 425);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.btnWWVergeten);
            this.Controls.Add(this.btnGeenAccount);
            this.Controls.Add(this.iconbtnLock);
            this.Controls.Add(this.iconbtnOpenLock);
            this.Controls.Add(this.btnAanmelden);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.pnlwachtwoord);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.pnlgebruikersnaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Aanmeldscherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aanmelden";
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnOpenLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Panel pnlgebruikersnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Panel pnlwachtwoord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAanmelden;
        private FontAwesome.Sharp.IconPictureBox iconbtnLock;
        private FontAwesome.Sharp.IconPictureBox iconbtnOpenLock;
        private System.Windows.Forms.Button btnGeenAccount;
        private System.Windows.Forms.Button btnWWVergeten;
        private FontAwesome.Sharp.IconPictureBox btnQRCode;
    }
}