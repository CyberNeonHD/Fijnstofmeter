
namespace FijnstofGIP.FormsMenu
{
    partial class FormDataTabelvorm
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
            this.dgvGegevens = new System.Windows.Forms.DataGridView();
            this.cmbWelkeMeter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZoekstring = new System.Windows.Forms.TextBox();
            this.pnlZoekstring = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbWelkVeld = new System.Windows.Forms.ComboBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGegevens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGegevens
            // 
            this.dgvGegevens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvGegevens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGegevens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGegevens.Location = new System.Drawing.Point(12, 130);
            this.dgvGegevens.Name = "dgvGegevens";
            this.dgvGegevens.RowHeadersWidth = 51;
            this.dgvGegevens.Size = new System.Drawing.Size(783, 398);
            this.dgvGegevens.TabIndex = 5;
            // 
            // cmbWelkeMeter
            // 
            this.cmbWelkeMeter.AccessibleDescription = "";
            this.cmbWelkeMeter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbWelkeMeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.cmbWelkeMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWelkeMeter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWelkeMeter.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbWelkeMeter.FormattingEnabled = true;
            this.cmbWelkeMeter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbWelkeMeter.ItemHeight = 14;
            this.cmbWelkeMeter.Location = new System.Drawing.Point(271, 19);
            this.cmbWelkeMeter.Name = "cmbWelkeMeter";
            this.cmbWelkeMeter.Size = new System.Drawing.Size(119, 22);
            this.cmbWelkeMeter.TabIndex = 80;
            this.cmbWelkeMeter.Tag = "Hier kan je kiezen in welk veld je wil zoeken";
            this.cmbWelkeMeter.SelectionChangeCommitted += new System.EventHandler(this.cmbWelkeMeter_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 23);
            this.label6.TabIndex = 86;
            this.label6.Text = "Kies hier de meter die u wilt inladen";
            // 
            // txtZoekstring
            // 
            this.txtZoekstring.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZoekstring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtZoekstring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZoekstring.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZoekstring.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoekstring.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtZoekstring.Location = new System.Drawing.Point(271, 88);
            this.txtZoekstring.MaxLength = 20;
            this.txtZoekstring.Multiline = true;
            this.txtZoekstring.Name = "txtZoekstring";
            this.txtZoekstring.Size = new System.Drawing.Size(119, 20);
            this.txtZoekstring.TabIndex = 82;
            this.txtZoekstring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZoekstring.Click += new System.EventHandler(this.txtZoekstring_Click);
            this.txtZoekstring.TextChanged += new System.EventHandler(this.txtZoekstring_TextChanged);
            this.txtZoekstring.Enter += new System.EventHandler(this.txtZoekstring_Enter);
            this.txtZoekstring.Leave += new System.EventHandler(this.txtZoekstring_Leave);
            // 
            // pnlZoekstring
            // 
            this.pnlZoekstring.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlZoekstring.BackColor = System.Drawing.Color.White;
            this.pnlZoekstring.Location = new System.Drawing.Point(274, 107);
            this.pnlZoekstring.Margin = new System.Windows.Forms.Padding(0);
            this.pnlZoekstring.Name = "pnlZoekstring";
            this.pnlZoekstring.Size = new System.Drawing.Size(115, 3);
            this.pnlZoekstring.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 23);
            this.label8.TabIndex = 84;
            this.label8.Text = "Hier kan u uw zoekstring invullen";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "Kies een veld voor het zoeken";
            // 
            // cmbWelkVeld
            // 
            this.cmbWelkVeld.AccessibleDescription = "";
            this.cmbWelkVeld.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbWelkVeld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.cmbWelkVeld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWelkVeld.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWelkVeld.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbWelkVeld.FormattingEnabled = true;
            this.cmbWelkVeld.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbWelkVeld.ItemHeight = 14;
            this.cmbWelkVeld.Location = new System.Drawing.Point(271, 60);
            this.cmbWelkVeld.Name = "cmbWelkVeld";
            this.cmbWelkVeld.Size = new System.Drawing.Size(119, 22);
            this.cmbWelkVeld.TabIndex = 81;
            this.cmbWelkVeld.Tag = "Hier kan je kiezen in welk veld je wil zoeken";
            this.cmbWelkVeld.SelectionChangeCommitted += new System.EventHandler(this.cmbWelkVeld_SelectionChangeCommitted);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(780, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 87;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormDataTabelvorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(807, 540);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbWelkeMeter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZoekstring);
            this.Controls.Add(this.pnlZoekstring);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbWelkVeld);
            this.Controls.Add(this.dgvGegevens);
            this.Name = "FormDataTabelvorm";
            this.Text = "FormDataTabelvorm";
            this.Load += new System.EventHandler(this.FormDataTabelvorm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGegevens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGegevens;
        private System.Windows.Forms.ComboBox cmbWelkeMeter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZoekstring;
        private System.Windows.Forms.Panel pnlZoekstring;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbWelkVeld;
        private FontAwesome.Sharp.IconPictureBox btnClose;
    }
}