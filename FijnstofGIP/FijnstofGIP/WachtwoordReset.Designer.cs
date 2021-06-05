
namespace FijnstofGIP
{
    partial class WachtwoordReset
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCodeVersturen = new System.Windows.Forms.Button();
            this.btnTerugkeren = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCodeIndienen = new System.Windows.Forms.Button();
            this.pnlEmailSectie = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.pnlCodeSectie = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.btnNieuweCode = new System.Windows.Forms.Button();
            this.pnlWWVeranderenSectie = new System.Windows.Forms.Panel();
            this.iconbtnLock = new FontAwesome.Sharp.IconPictureBox();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.pnlWW = new System.Windows.Forms.Panel();
            this.iconbtnLockBevestigen = new FontAwesome.Sharp.IconPictureBox();
            this.txtWWBevestigen = new System.Windows.Forms.TextBox();
            this.pnlWWBevestigen = new System.Windows.Forms.Panel();
            this.iconbtnOpenLockBevestigen = new FontAwesome.Sharp.IconPictureBox();
            this.iconbtnOpenLock = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWWBevestigen = new System.Windows.Forms.Button();
            this.pnlEmailSectie.SuspendLayout();
            this.pnlCodeSectie.SuspendLayout();
            this.pnlWWVeranderenSectie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnLockBevestigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnOpenLockBevestigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnOpenLock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 50;
            this.label1.Text = "Wachtwoord vergeten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(28, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vul hier uw e-mail van uw account in";
            // 
            // btnCodeVersturen
            // 
            this.btnCodeVersturen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCodeVersturen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodeVersturen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodeVersturen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCodeVersturen.Location = new System.Drawing.Point(281, 79);
            this.btnCodeVersturen.Name = "btnCodeVersturen";
            this.btnCodeVersturen.Size = new System.Drawing.Size(138, 34);
            this.btnCodeVersturen.TabIndex = 2;
            this.btnCodeVersturen.Text = "Code versturen";
            this.btnCodeVersturen.UseVisualStyleBackColor = true;
            this.btnCodeVersturen.Click += new System.EventHandler(this.btnCodeVersturen_Click);
            // 
            // btnTerugkeren
            // 
            this.btnTerugkeren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerugkeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerugkeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerugkeren.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTerugkeren.Location = new System.Drawing.Point(389, 190);
            this.btnTerugkeren.Name = "btnTerugkeren";
            this.btnTerugkeren.Size = new System.Drawing.Size(138, 34);
            this.btnTerugkeren.TabIndex = 11;
            this.btnTerugkeren.Text = "Terugkeren";
            this.btnTerugkeren.UseVisualStyleBackColor = true;
            this.btnTerugkeren.Click += new System.EventHandler(this.btnTerugkeren_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(29, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vul hier de code in:";
            // 
            // btnCodeIndienen
            // 
            this.btnCodeIndienen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCodeIndienen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodeIndienen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodeIndienen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCodeIndienen.Location = new System.Drawing.Point(281, 74);
            this.btnCodeIndienen.Name = "btnCodeIndienen";
            this.btnCodeIndienen.Size = new System.Drawing.Size(85, 34);
            this.btnCodeIndienen.TabIndex = 2;
            this.btnCodeIndienen.Text = "Indienen";
            this.btnCodeIndienen.UseVisualStyleBackColor = true;
            this.btnCodeIndienen.Click += new System.EventHandler(this.btnCodeIndienen_Click);
            // 
            // pnlEmailSectie
            // 
            this.pnlEmailSectie.Controls.Add(this.txtEmail);
            this.pnlEmailSectie.Controls.Add(this.pnlEmail);
            this.pnlEmailSectie.Controls.Add(this.label2);
            this.pnlEmailSectie.Controls.Add(this.btnCodeVersturen);
            this.pnlEmailSectie.Location = new System.Drawing.Point(108, 56);
            this.pnlEmailSectie.Name = "pnlEmailSectie";
            this.pnlEmailSectie.Size = new System.Drawing.Size(425, 128);
            this.pnlEmailSectie.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
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
            // pnlCodeSectie
            // 
            this.pnlCodeSectie.Controls.Add(this.txtCode);
            this.pnlCodeSectie.Controls.Add(this.pnlCode);
            this.pnlCodeSectie.Controls.Add(this.btnNieuweCode);
            this.pnlCodeSectie.Controls.Add(this.label3);
            this.pnlCodeSectie.Controls.Add(this.btnCodeIndienen);
            this.pnlCodeSectie.Location = new System.Drawing.Point(108, 56);
            this.pnlCodeSectie.Name = "pnlCodeSectie";
            this.pnlCodeSectie.Size = new System.Drawing.Size(425, 128);
            this.pnlCodeSectie.TabIndex = 17;
            this.pnlCodeSectie.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCode.Location = new System.Drawing.Point(170, 41);
            this.txtCode.MaxLength = 28;
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // pnlCode
            // 
            this.pnlCode.BackColor = System.Drawing.Color.White;
            this.pnlCode.Location = new System.Drawing.Point(173, 60);
            this.pnlCode.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(96, 3);
            this.pnlCode.TabIndex = 24;
            // 
            // btnNieuweCode
            // 
            this.btnNieuweCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNieuweCode.FlatAppearance.BorderSize = 0;
            this.btnNieuweCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNieuweCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNieuweCode.Font = new System.Drawing.Font("Myanmar Text", 8.25F);
            this.btnNieuweCode.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNieuweCode.Location = new System.Drawing.Point(288, 3);
            this.btnNieuweCode.Name = "btnNieuweCode";
            this.btnNieuweCode.Size = new System.Drawing.Size(131, 25);
            this.btnNieuweCode.TabIndex = 19;
            this.btnNieuweCode.Text = "Code niet ontvangen?";
            this.btnNieuweCode.UseVisualStyleBackColor = true;
            this.btnNieuweCode.Click += new System.EventHandler(this.btnNieuweCode_Click);
            // 
            // pnlWWVeranderenSectie
            // 
            this.pnlWWVeranderenSectie.Controls.Add(this.iconbtnLock);
            this.pnlWWVeranderenSectie.Controls.Add(this.txtWW);
            this.pnlWWVeranderenSectie.Controls.Add(this.pnlWW);
            this.pnlWWVeranderenSectie.Controls.Add(this.iconbtnLockBevestigen);
            this.pnlWWVeranderenSectie.Controls.Add(this.txtWWBevestigen);
            this.pnlWWVeranderenSectie.Controls.Add(this.pnlWWBevestigen);
            this.pnlWWVeranderenSectie.Controls.Add(this.iconbtnOpenLockBevestigen);
            this.pnlWWVeranderenSectie.Controls.Add(this.iconbtnOpenLock);
            this.pnlWWVeranderenSectie.Controls.Add(this.label5);
            this.pnlWWVeranderenSectie.Controls.Add(this.label4);
            this.pnlWWVeranderenSectie.Controls.Add(this.btnWWBevestigen);
            this.pnlWWVeranderenSectie.Location = new System.Drawing.Point(12, 49);
            this.pnlWWVeranderenSectie.Name = "pnlWWVeranderenSectie";
            this.pnlWWVeranderenSectie.Size = new System.Drawing.Size(521, 135);
            this.pnlWWVeranderenSectie.TabIndex = 18;
            this.pnlWWVeranderenSectie.Visible = false;
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
            this.iconbtnLock.Location = new System.Drawing.Point(351, 11);
            this.iconbtnLock.Name = "iconbtnLock";
            this.iconbtnLock.Size = new System.Drawing.Size(24, 24);
            this.iconbtnLock.TabIndex = 19;
            this.iconbtnLock.TabStop = false;
            this.iconbtnLock.Click += new System.EventHandler(this.iconbtnLock_Click);
            // 
            // txtWW
            // 
            this.txtWW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtWW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWW.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWW.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtWW.Location = new System.Drawing.Point(190, 33);
            this.txtWW.MaxLength = 28;
            this.txtWW.Multiline = true;
            this.txtWW.Name = "txtWW";
            this.txtWW.PasswordChar = '*';
            this.txtWW.Size = new System.Drawing.Size(179, 20);
            this.txtWW.TabIndex = 1;
            this.txtWW.Click += new System.EventHandler(this.txtWW_Click);
            this.txtWW.Enter += new System.EventHandler(this.txtWW_Enter);
            this.txtWW.Leave += new System.EventHandler(this.txtWW_Leave);
            // 
            // pnlWW
            // 
            this.pnlWW.BackColor = System.Drawing.Color.White;
            this.pnlWW.Location = new System.Drawing.Point(193, 52);
            this.pnlWW.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWW.Name = "pnlWW";
            this.pnlWW.Size = new System.Drawing.Size(175, 3);
            this.pnlWW.TabIndex = 22;
            // 
            // iconbtnLockBevestigen
            // 
            this.iconbtnLockBevestigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconbtnLockBevestigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnLockBevestigen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnLockBevestigen.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconbtnLockBevestigen.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnLockBevestigen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnLockBevestigen.IconSize = 24;
            this.iconbtnLockBevestigen.Location = new System.Drawing.Point(352, 69);
            this.iconbtnLockBevestigen.Name = "iconbtnLockBevestigen";
            this.iconbtnLockBevestigen.Size = new System.Drawing.Size(24, 24);
            this.iconbtnLockBevestigen.TabIndex = 21;
            this.iconbtnLockBevestigen.TabStop = false;
            this.iconbtnLockBevestigen.Click += new System.EventHandler(this.iconbtnLockBevestigen_Click);
            // 
            // txtWWBevestigen
            // 
            this.txtWWBevestigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtWWBevestigen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWWBevestigen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWWBevestigen.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWWBevestigen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtWWBevestigen.Location = new System.Drawing.Point(191, 88);
            this.txtWWBevestigen.MaxLength = 28;
            this.txtWWBevestigen.Multiline = true;
            this.txtWWBevestigen.Name = "txtWWBevestigen";
            this.txtWWBevestigen.PasswordChar = '*';
            this.txtWWBevestigen.Size = new System.Drawing.Size(179, 20);
            this.txtWWBevestigen.TabIndex = 2;
            this.txtWWBevestigen.Click += new System.EventHandler(this.txtWWBevestigen_Click);
            this.txtWWBevestigen.Enter += new System.EventHandler(this.txtWWBevestigen_Enter);
            this.txtWWBevestigen.Leave += new System.EventHandler(this.txtWWBevestigen_Leave);
            // 
            // pnlWWBevestigen
            // 
            this.pnlWWBevestigen.BackColor = System.Drawing.Color.White;
            this.pnlWWBevestigen.Location = new System.Drawing.Point(194, 107);
            this.pnlWWBevestigen.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWWBevestigen.Name = "pnlWWBevestigen";
            this.pnlWWBevestigen.Size = new System.Drawing.Size(175, 3);
            this.pnlWWBevestigen.TabIndex = 20;
            // 
            // iconbtnOpenLockBevestigen
            // 
            this.iconbtnOpenLockBevestigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconbtnOpenLockBevestigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnOpenLockBevestigen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnOpenLockBevestigen.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iconbtnOpenLockBevestigen.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnOpenLockBevestigen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnOpenLockBevestigen.IconSize = 24;
            this.iconbtnOpenLockBevestigen.Location = new System.Drawing.Point(352, 69);
            this.iconbtnOpenLockBevestigen.Name = "iconbtnOpenLockBevestigen";
            this.iconbtnOpenLockBevestigen.Size = new System.Drawing.Size(24, 24);
            this.iconbtnOpenLockBevestigen.TabIndex = 22;
            this.iconbtnOpenLockBevestigen.TabStop = false;
            this.iconbtnOpenLockBevestigen.Click += new System.EventHandler(this.iconbtnOpenLockBevestigen_Click);
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
            this.iconbtnOpenLock.Location = new System.Drawing.Point(351, 11);
            this.iconbtnOpenLock.Name = "iconbtnOpenLock";
            this.iconbtnOpenLock.Size = new System.Drawing.Size(24, 24);
            this.iconbtnOpenLock.TabIndex = 20;
            this.iconbtnOpenLock.TabStop = false;
            this.iconbtnOpenLock.Click += new System.EventHandler(this.iconbtnOpenLock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wachtwoord bevestigen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nieuw Wachtwoord:";
            // 
            // btnWWBevestigen
            // 
            this.btnWWBevestigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWWBevestigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWWBevestigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWWBevestigen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWWBevestigen.Location = new System.Drawing.Point(412, 90);
            this.btnWWBevestigen.Name = "btnWWBevestigen";
            this.btnWWBevestigen.Size = new System.Drawing.Size(103, 34);
            this.btnWWBevestigen.TabIndex = 3;
            this.btnWWBevestigen.Text = "Bevestigen";
            this.btnWWBevestigen.UseVisualStyleBackColor = true;
            this.btnWWBevestigen.Click += new System.EventHandler(this.btnWWBevestigen_Click);
            // 
            // WachtwoordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(540, 232);
            this.Controls.Add(this.btnTerugkeren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlWWVeranderenSectie);
            this.Controls.Add(this.pnlEmailSectie);
            this.Controls.Add(this.pnlCodeSectie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WachtwoordReset";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wachtwoord vergeten";
            this.pnlEmailSectie.ResumeLayout(false);
            this.pnlEmailSectie.PerformLayout();
            this.pnlCodeSectie.ResumeLayout(false);
            this.pnlCodeSectie.PerformLayout();
            this.pnlWWVeranderenSectie.ResumeLayout(false);
            this.pnlWWVeranderenSectie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnLockBevestigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnOpenLockBevestigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnOpenLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCodeVersturen;
        private System.Windows.Forms.Button btnTerugkeren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCodeIndienen;
        private System.Windows.Forms.Panel pnlEmailSectie;
        private System.Windows.Forms.Panel pnlCodeSectie;
        private System.Windows.Forms.Panel pnlWWVeranderenSectie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWWBevestigen;
        private System.Windows.Forms.Button btnNieuweCode;
        private FontAwesome.Sharp.IconPictureBox iconbtnLock;
        private FontAwesome.Sharp.IconPictureBox iconbtnOpenLock;
        private FontAwesome.Sharp.IconPictureBox iconbtnLockBevestigen;
        private FontAwesome.Sharp.IconPictureBox iconbtnOpenLockBevestigen;
        private System.Windows.Forms.TextBox txtWWBevestigen;
        private System.Windows.Forms.Panel pnlWWBevestigen;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.Panel pnlWW;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel pnlCode;
    }
}