
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
            this.lblGeenAccount = new System.Windows.Forms.Label();
            this.iconbtnLock = new FontAwesome.Sharp.IconPictureBox();
            this.iconbtnOpenLock = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnOpenLock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aanmelden";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtGebruikersnaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGebruikersnaam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikersnaam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtGebruikersnaam.Location = new System.Drawing.Point(21, 134);
            this.txtGebruikersnaam.Multiline = true;
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(216, 20);
            this.txtGebruikersnaam.TabIndex = 5;
            this.txtGebruikersnaam.Click += new System.EventHandler(this.txtGebruikersnaam_Click);
            // 
            // pnlgebruikersnaam
            // 
            this.pnlgebruikersnaam.BackColor = System.Drawing.Color.White;
            this.pnlgebruikersnaam.Location = new System.Drawing.Point(24, 153);
            this.pnlgebruikersnaam.Margin = new System.Windows.Forms.Padding(0);
            this.pnlgebruikersnaam.Name = "pnlgebruikersnaam";
            this.pnlgebruikersnaam.Size = new System.Drawing.Size(212, 3);
            this.pnlgebruikersnaam.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gebruikersnaam";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtWachtwoord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWachtwoord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWachtwoord.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWachtwoord.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtWachtwoord.Location = new System.Drawing.Point(22, 200);
            this.txtWachtwoord.Multiline = true;
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(216, 20);
            this.txtWachtwoord.TabIndex = 8;
            this.txtWachtwoord.Click += new System.EventHandler(this.txtWachtwoord_Click);
            this.txtWachtwoord.TextChanged += new System.EventHandler(this.txtWachtwoord_TextChanged);
            // 
            // pnlwachtwoord
            // 
            this.pnlwachtwoord.BackColor = System.Drawing.Color.White;
            this.pnlwachtwoord.Location = new System.Drawing.Point(25, 219);
            this.pnlwachtwoord.Margin = new System.Windows.Forms.Padding(0);
            this.pnlwachtwoord.Name = "pnlwachtwoord";
            this.pnlwachtwoord.Size = new System.Drawing.Size(212, 3);
            this.pnlwachtwoord.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(19, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 27);
            this.label9.TabIndex = 7;
            this.label9.Text = "Wachtwoord";
            // 
            // btnAanmelden
            // 
            this.btnAanmelden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAanmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAanmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAanmelden.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAanmelden.Location = new System.Drawing.Point(61, 261);
            this.btnAanmelden.Name = "btnAanmelden";
            this.btnAanmelden.Size = new System.Drawing.Size(129, 34);
            this.btnAanmelden.TabIndex = 10;
            this.btnAanmelden.Text = "Aanmelden";
            this.btnAanmelden.UseVisualStyleBackColor = true;
            this.btnAanmelden.Click += new System.EventHandler(this.btnAanmelden_Click);
            // 
            // lblGeenAccount
            // 
            this.lblGeenAccount.AutoSize = true;
            this.lblGeenAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGeenAccount.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeenAccount.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGeenAccount.Location = new System.Drawing.Point(57, 307);
            this.lblGeenAccount.Name = "lblGeenAccount";
            this.lblGeenAccount.Size = new System.Drawing.Size(138, 20);
            this.lblGeenAccount.TabIndex = 4;
            this.lblGeenAccount.Text = "Ik heb nog geen account";
            this.lblGeenAccount.Click += new System.EventHandler(this.lblGeenAccount_Click);
            this.lblGeenAccount.MouseEnter += new System.EventHandler(this.lblGeenAccount_Hover);
            this.lblGeenAccount.MouseLeave += new System.EventHandler(this.lblGeenAccount_GeenHover);
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
            this.iconbtnLock.Location = new System.Drawing.Point(214, 174);
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
            this.iconbtnOpenLock.Location = new System.Drawing.Point(214, 174);
            this.iconbtnOpenLock.Name = "iconbtnOpenLock";
            this.iconbtnOpenLock.Size = new System.Drawing.Size(24, 24);
            this.iconbtnOpenLock.TabIndex = 12;
            this.iconbtnOpenLock.TabStop = false;
            this.iconbtnOpenLock.Click += new System.EventHandler(this.iconbtnOpenLock_Click);
            // 
            // Aanmeldscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(258, 389);
            this.Controls.Add(this.iconbtnLock);
            this.Controls.Add(this.iconbtnOpenLock);
            this.Controls.Add(this.btnAanmelden);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.pnlwachtwoord);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.pnlgebruikersnaam);
            this.Controls.Add(this.lblGeenAccount);
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
        private System.Windows.Forms.Label lblGeenAccount;
        private FontAwesome.Sharp.IconPictureBox iconbtnLock;
        private FontAwesome.Sharp.IconPictureBox iconbtnOpenLock;
    }
}