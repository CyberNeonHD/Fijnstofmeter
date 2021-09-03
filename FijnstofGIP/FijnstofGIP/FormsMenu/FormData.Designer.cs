namespace FijnstofGIP.FormsMenu
{
    partial class FormData
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
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecordToevoegen = new System.Windows.Forms.Button();
            this.btnRecordBewaren = new System.Windows.Forms.Button();
            this.btnRecordVerwijderen = new System.Windows.Forms.Button();
            this.btnLaatsteRecord = new System.Windows.Forms.Button();
            this.btnVolgendRecord = new System.Windows.Forms.Button();
            this.btnVorigRecord = new System.Windows.Forms.Button();
            this.btnEersteRecord = new System.Windows.Forms.Button();
            this.lblPM2_5 = new System.Windows.Forms.Label();
            this.lblVochtigheid = new System.Windows.Forms.Label();
            this.lblTemperatuur = new System.Windows.Forms.Label();
            this.lblMeterID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMeterID = new System.Windows.Forms.TextBox();
            this.pnlMeterID = new System.Windows.Forms.Panel();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.pnlDatum = new System.Windows.Forms.Panel();
            this.txtPM2_5 = new System.Windows.Forms.TextBox();
            this.pnl2_5 = new System.Windows.Forms.Panel();
            this.txtPM10 = new System.Windows.Forms.TextBox();
            this.pnlPM10 = new System.Windows.Forms.Panel();
            this.txtTijdstip = new System.Windows.Forms.TextBox();
            this.pnlTijdstip = new System.Windows.Forms.Panel();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.pnlTemp = new System.Windows.Forms.Panel();
            this.txtVochtigheid = new System.Windows.Forms.TextBox();
            this.pnlVochtigheid = new System.Windows.Forms.Panel();
            this.txtLuchtdruk = new System.Windows.Forms.TextBox();
            this.pnlLuchtdruk = new System.Windows.Forms.Panel();
            this.cmbWelkVeld = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtZoekstring = new System.Windows.Forms.TextBox();
            this.pnlZoekstring = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbWelkeMeter = new System.Windows.Forms.ComboBox();
            this.txtGegevensID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(784, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 18;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(320, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 43);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data verwerken";
            // 
            // btnRecordToevoegen
            // 
            this.btnRecordToevoegen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRecordToevoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordToevoegen.Location = new System.Drawing.Point(418, 36);
            this.btnRecordToevoegen.Name = "btnRecordToevoegen";
            this.btnRecordToevoegen.Size = new System.Drawing.Size(181, 42);
            this.btnRecordToevoegen.TabIndex = 18;
            this.btnRecordToevoegen.Text = "Record toevoegen";
            this.btnRecordToevoegen.UseVisualStyleBackColor = true;
            this.btnRecordToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnRecordBewaren
            // 
            this.btnRecordBewaren.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRecordBewaren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordBewaren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordBewaren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordBewaren.Location = new System.Drawing.Point(605, 36);
            this.btnRecordBewaren.Name = "btnRecordBewaren";
            this.btnRecordBewaren.Size = new System.Drawing.Size(181, 42);
            this.btnRecordBewaren.TabIndex = 19;
            this.btnRecordBewaren.Text = "Record aanpassen";
            this.btnRecordBewaren.UseVisualStyleBackColor = true;
            this.btnRecordBewaren.Click += new System.EventHandler(this.btnRecordBewaren_Click);
            // 
            // btnRecordVerwijderen
            // 
            this.btnRecordVerwijderen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRecordVerwijderen.AutoSize = true;
            this.btnRecordVerwijderen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordVerwijderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordVerwijderen.Location = new System.Drawing.Point(44, 36);
            this.btnRecordVerwijderen.Name = "btnRecordVerwijderen";
            this.btnRecordVerwijderen.Size = new System.Drawing.Size(181, 42);
            this.btnRecordVerwijderen.TabIndex = 16;
            this.btnRecordVerwijderen.Text = "Record verwijderen";
            this.btnRecordVerwijderen.UseVisualStyleBackColor = true;
            this.btnRecordVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnLaatsteRecord
            // 
            this.btnLaatsteRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLaatsteRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaatsteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaatsteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaatsteRecord.Location = new System.Drawing.Point(605, 47);
            this.btnLaatsteRecord.Name = "btnLaatsteRecord";
            this.btnLaatsteRecord.Size = new System.Drawing.Size(181, 42);
            this.btnLaatsteRecord.TabIndex = 4;
            this.btnLaatsteRecord.Text = "Laatste record";
            this.btnLaatsteRecord.UseVisualStyleBackColor = true;
            this.btnLaatsteRecord.Click += new System.EventHandler(this.btnLaatste_Click);
            // 
            // btnVolgendRecord
            // 
            this.btnVolgendRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVolgendRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolgendRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolgendRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolgendRecord.Location = new System.Drawing.Point(418, 47);
            this.btnVolgendRecord.Name = "btnVolgendRecord";
            this.btnVolgendRecord.Size = new System.Drawing.Size(181, 42);
            this.btnVolgendRecord.TabIndex = 3;
            this.btnVolgendRecord.Text = "Volgend record";
            this.btnVolgendRecord.UseVisualStyleBackColor = true;
            this.btnVolgendRecord.Click += new System.EventHandler(this.btnVolgend_Click);
            // 
            // btnVorigRecord
            // 
            this.btnVorigRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVorigRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVorigRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVorigRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVorigRecord.Location = new System.Drawing.Point(231, 47);
            this.btnVorigRecord.Name = "btnVorigRecord";
            this.btnVorigRecord.Size = new System.Drawing.Size(181, 42);
            this.btnVorigRecord.TabIndex = 2;
            this.btnVorigRecord.Text = "Vorig Record";
            this.btnVorigRecord.UseVisualStyleBackColor = true;
            this.btnVorigRecord.Click += new System.EventHandler(this.btnVorige_Click);
            // 
            // btnEersteRecord
            // 
            this.btnEersteRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEersteRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEersteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEersteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEersteRecord.Location = new System.Drawing.Point(44, 47);
            this.btnEersteRecord.Name = "btnEersteRecord";
            this.btnEersteRecord.Size = new System.Drawing.Size(181, 42);
            this.btnEersteRecord.TabIndex = 1;
            this.btnEersteRecord.Text = "Eerste Record";
            this.btnEersteRecord.UseVisualStyleBackColor = true;
            this.btnEersteRecord.Click += new System.EventHandler(this.btnEerste_Click);
            // 
            // lblPM2_5
            // 
            this.lblPM2_5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPM2_5.AutoSize = true;
            this.lblPM2_5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPM2_5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPM2_5.Location = new System.Drawing.Point(288, 269);
            this.lblPM2_5.Name = "lblPM2_5";
            this.lblPM2_5.Size = new System.Drawing.Size(61, 29);
            this.lblPM2_5.TabIndex = 24;
            this.lblPM2_5.Text = "PM 2.5";
            // 
            // lblVochtigheid
            // 
            this.lblVochtigheid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVochtigheid.AutoSize = true;
            this.lblVochtigheid.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVochtigheid.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblVochtigheid.Location = new System.Drawing.Point(430, 269);
            this.lblVochtigheid.Name = "lblVochtigheid";
            this.lblVochtigheid.Size = new System.Drawing.Size(96, 29);
            this.lblVochtigheid.TabIndex = 23;
            this.lblVochtigheid.Text = "Vochtigheid";
            // 
            // lblTemperatuur
            // 
            this.lblTemperatuur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTemperatuur.AutoSize = true;
            this.lblTemperatuur.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatuur.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTemperatuur.Location = new System.Drawing.Point(429, 207);
            this.lblTemperatuur.Name = "lblTemperatuur";
            this.lblTemperatuur.Size = new System.Drawing.Size(103, 29);
            this.lblTemperatuur.TabIndex = 22;
            this.lblTemperatuur.Text = "Temperatuur";
            // 
            // lblMeterID
            // 
            this.lblMeterID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMeterID.AutoSize = true;
            this.lblMeterID.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeterID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMeterID.Location = new System.Drawing.Point(108, 144);
            this.lblMeterID.Name = "lblMeterID";
            this.lblMeterID.Size = new System.Drawing.Size(69, 29);
            this.lblMeterID.TabIndex = 20;
            this.lblMeterID.Text = "MeterID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(143, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "PM 10";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(565, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Luchtdruk";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(143, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tijdstip";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(288, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Datum";
            // 
            // txtMeterID
            // 
            this.txtMeterID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMeterID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtMeterID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMeterID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMeterID.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeterID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMeterID.Location = new System.Drawing.Point(110, 176);
            this.txtMeterID.MaxLength = 45;
            this.txtMeterID.Multiline = true;
            this.txtMeterID.Name = "txtMeterID";
            this.txtMeterID.Size = new System.Drawing.Size(159, 20);
            this.txtMeterID.TabIndex = 8;
            this.txtMeterID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMeterID.Click += new System.EventHandler(this.txtMeterID_Click);
            this.txtMeterID.Enter += new System.EventHandler(this.txtMeterID_Enter);
            // 
            // pnlMeterID
            // 
            this.pnlMeterID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlMeterID.BackColor = System.Drawing.Color.White;
            this.pnlMeterID.Location = new System.Drawing.Point(113, 195);
            this.pnlMeterID.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMeterID.Name = "pnlMeterID";
            this.pnlMeterID.Size = new System.Drawing.Size(155, 2);
            this.pnlMeterID.TabIndex = 43;
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatum.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtDatum.Location = new System.Drawing.Point(290, 235);
            this.txtDatum.MaxLength = 45;
            this.txtDatum.Multiline = true;
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(88, 20);
            this.txtDatum.TabIndex = 10;
            this.txtDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDatum.Click += new System.EventHandler(this.txtDatum_Click);
            this.txtDatum.Enter += new System.EventHandler(this.txtDatum_Enter);
            // 
            // pnlDatum
            // 
            this.pnlDatum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlDatum.BackColor = System.Drawing.Color.White;
            this.pnlDatum.Location = new System.Drawing.Point(293, 253);
            this.pnlDatum.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDatum.Name = "pnlDatum";
            this.pnlDatum.Size = new System.Drawing.Size(84, 2);
            this.pnlDatum.TabIndex = 49;
            // 
            // txtPM2_5
            // 
            this.txtPM2_5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPM2_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtPM2_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPM2_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPM2_5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPM2_5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPM2_5.Location = new System.Drawing.Point(290, 295);
            this.txtPM2_5.MaxLength = 45;
            this.txtPM2_5.Multiline = true;
            this.txtPM2_5.Name = "txtPM2_5";
            this.txtPM2_5.Size = new System.Drawing.Size(88, 20);
            this.txtPM2_5.TabIndex = 13;
            this.txtPM2_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPM2_5.Click += new System.EventHandler(this.txtPM2_5_Click);
            this.txtPM2_5.Enter += new System.EventHandler(this.txtPM2_5_Enter);
            // 
            // pnl2_5
            // 
            this.pnl2_5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl2_5.BackColor = System.Drawing.Color.White;
            this.pnl2_5.Location = new System.Drawing.Point(293, 314);
            this.pnl2_5.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2_5.Name = "pnl2_5";
            this.pnl2_5.Size = new System.Drawing.Size(84, 2);
            this.pnl2_5.TabIndex = 57;
            // 
            // txtPM10
            // 
            this.txtPM10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPM10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtPM10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPM10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPM10.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPM10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPM10.Location = new System.Drawing.Point(145, 296);
            this.txtPM10.MaxLength = 45;
            this.txtPM10.Multiline = true;
            this.txtPM10.Name = "txtPM10";
            this.txtPM10.Size = new System.Drawing.Size(88, 20);
            this.txtPM10.TabIndex = 12;
            this.txtPM10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPM10.Click += new System.EventHandler(this.txtPM10_Click);
            this.txtPM10.Enter += new System.EventHandler(this.txtPM10_Enter);
            // 
            // pnlPM10
            // 
            this.pnlPM10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPM10.BackColor = System.Drawing.Color.White;
            this.pnlPM10.Location = new System.Drawing.Point(148, 314);
            this.pnlPM10.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPM10.Name = "pnlPM10";
            this.pnlPM10.Size = new System.Drawing.Size(84, 2);
            this.pnlPM10.TabIndex = 59;
            // 
            // txtTijdstip
            // 
            this.txtTijdstip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTijdstip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtTijdstip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTijdstip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTijdstip.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTijdstip.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTijdstip.Location = new System.Drawing.Point(145, 235);
            this.txtTijdstip.MaxLength = 45;
            this.txtTijdstip.Multiline = true;
            this.txtTijdstip.Name = "txtTijdstip";
            this.txtTijdstip.Size = new System.Drawing.Size(88, 20);
            this.txtTijdstip.TabIndex = 9;
            this.txtTijdstip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTijdstip.Click += new System.EventHandler(this.txtTijdstip_Click);
            this.txtTijdstip.Enter += new System.EventHandler(this.txtTijdstip_Enter);
            // 
            // pnlTijdstip
            // 
            this.pnlTijdstip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTijdstip.BackColor = System.Drawing.Color.White;
            this.pnlTijdstip.Location = new System.Drawing.Point(148, 253);
            this.pnlTijdstip.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTijdstip.Name = "pnlTijdstip";
            this.pnlTijdstip.Size = new System.Drawing.Size(84, 4);
            this.pnlTijdstip.TabIndex = 63;
            // 
            // txtTemp
            // 
            this.txtTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTemp.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTemp.Location = new System.Drawing.Point(432, 234);
            this.txtTemp.MaxLength = 45;
            this.txtTemp.Multiline = true;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(88, 20);
            this.txtTemp.TabIndex = 11;
            this.txtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTemp.Click += new System.EventHandler(this.txtTemp_Click);
            this.txtTemp.Enter += new System.EventHandler(this.txtTemp_Enter);
            // 
            // pnlTemp
            // 
            this.pnlTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTemp.BackColor = System.Drawing.Color.White;
            this.pnlTemp.Location = new System.Drawing.Point(435, 253);
            this.pnlTemp.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(84, 3);
            this.pnlTemp.TabIndex = 65;
            // 
            // txtVochtigheid
            // 
            this.txtVochtigheid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVochtigheid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtVochtigheid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVochtigheid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVochtigheid.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVochtigheid.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtVochtigheid.Location = new System.Drawing.Point(431, 295);
            this.txtVochtigheid.MaxLength = 45;
            this.txtVochtigheid.Multiline = true;
            this.txtVochtigheid.Name = "txtVochtigheid";
            this.txtVochtigheid.Size = new System.Drawing.Size(88, 20);
            this.txtVochtigheid.TabIndex = 14;
            this.txtVochtigheid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVochtigheid.Click += new System.EventHandler(this.txtVochtigheid_Click);
            this.txtVochtigheid.Enter += new System.EventHandler(this.txtVochtigheid_Enter);
            // 
            // pnlVochtigheid
            // 
            this.pnlVochtigheid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlVochtigheid.BackColor = System.Drawing.Color.White;
            this.pnlVochtigheid.Location = new System.Drawing.Point(434, 314);
            this.pnlVochtigheid.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVochtigheid.Name = "pnlVochtigheid";
            this.pnlVochtigheid.Size = new System.Drawing.Size(84, 3);
            this.pnlVochtigheid.TabIndex = 67;
            // 
            // txtLuchtdruk
            // 
            this.txtLuchtdruk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLuchtdruk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtLuchtdruk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLuchtdruk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuchtdruk.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuchtdruk.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtLuchtdruk.Location = new System.Drawing.Point(567, 295);
            this.txtLuchtdruk.MaxLength = 45;
            this.txtLuchtdruk.Multiline = true;
            this.txtLuchtdruk.Name = "txtLuchtdruk";
            this.txtLuchtdruk.Size = new System.Drawing.Size(88, 20);
            this.txtLuchtdruk.TabIndex = 15;
            this.txtLuchtdruk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLuchtdruk.Click += new System.EventHandler(this.txtLuchtdruk_Click);
            this.txtLuchtdruk.Enter += new System.EventHandler(this.txtLuchtdruk_Enter);
            // 
            // pnlLuchtdruk
            // 
            this.pnlLuchtdruk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlLuchtdruk.BackColor = System.Drawing.Color.White;
            this.pnlLuchtdruk.Location = new System.Drawing.Point(570, 314);
            this.pnlLuchtdruk.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLuchtdruk.Name = "pnlLuchtdruk";
            this.pnlLuchtdruk.Size = new System.Drawing.Size(84, 3);
            this.pnlLuchtdruk.TabIndex = 69;
            // 
            // cmbWelkVeld
            // 
            this.cmbWelkVeld.AccessibleDescription = "";
            this.cmbWelkVeld.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbWelkVeld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.cmbWelkVeld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWelkVeld.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWelkVeld.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbWelkVeld.FormattingEnabled = true;
            this.cmbWelkVeld.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbWelkVeld.ItemHeight = 15;
            this.cmbWelkVeld.Location = new System.Drawing.Point(635, 61);
            this.cmbWelkVeld.Name = "cmbWelkVeld";
            this.cmbWelkVeld.Size = new System.Drawing.Size(119, 23);
            this.cmbWelkVeld.TabIndex = 6;
            this.cmbWelkVeld.Tag = "Hier kan je kiezen in welk veld je wil zoeken";
            this.cmbWelkVeld.SelectionChangeCommitted += new System.EventHandler(this.cmbWelkVeld_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(361, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 29);
            this.label7.TabIndex = 74;
            this.label7.Text = "Kies een veld voor het zoeken";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(361, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 29);
            this.label8.TabIndex = 75;
            this.label8.Text = "Hier kan u uw zoekstring invullen";
            // 
            // txtZoekstring
            // 
            this.txtZoekstring.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZoekstring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtZoekstring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZoekstring.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZoekstring.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoekstring.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtZoekstring.Location = new System.Drawing.Point(635, 89);
            this.txtZoekstring.MaxLength = 20;
            this.txtZoekstring.Multiline = true;
            this.txtZoekstring.Name = "txtZoekstring";
            this.txtZoekstring.Size = new System.Drawing.Size(119, 20);
            this.txtZoekstring.TabIndex = 7;
            this.txtZoekstring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZoekstring.Click += new System.EventHandler(this.txtZoekstring_Click);
            this.txtZoekstring.TextChanged += new System.EventHandler(this.txtZoekstring_TextChanged);
            this.txtZoekstring.Enter += new System.EventHandler(this.txtZoekstring_Enter);
            // 
            // pnlZoekstring
            // 
            this.pnlZoekstring.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlZoekstring.BackColor = System.Drawing.Color.White;
            this.pnlZoekstring.Location = new System.Drawing.Point(638, 108);
            this.pnlZoekstring.Margin = new System.Windows.Forms.Padding(0);
            this.pnlZoekstring.Name = "pnlZoekstring";
            this.pnlZoekstring.Size = new System.Drawing.Size(115, 3);
            this.pnlZoekstring.TabIndex = 77;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(231, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 42);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Records blanco maken";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(361, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 29);
            this.label6.TabIndex = 79;
            this.label6.Text = "Kies hier de meter die u wilt inladen";
            // 
            // cmbWelkeMeter
            // 
            this.cmbWelkeMeter.AccessibleDescription = "";
            this.cmbWelkeMeter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbWelkeMeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.cmbWelkeMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWelkeMeter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWelkeMeter.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbWelkeMeter.FormattingEnabled = true;
            this.cmbWelkeMeter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbWelkeMeter.ItemHeight = 15;
            this.cmbWelkeMeter.Location = new System.Drawing.Point(635, 20);
            this.cmbWelkeMeter.Name = "cmbWelkeMeter";
            this.cmbWelkeMeter.Size = new System.Drawing.Size(119, 23);
            this.cmbWelkeMeter.TabIndex = 5;
            this.cmbWelkeMeter.Tag = "Hier kan je kiezen in welk veld je wil zoeken";
            this.cmbWelkeMeter.SelectionChangeCommitted += new System.EventHandler(this.cmbWelkeMeter_SelectionChangeCommitted);
            // 
            // txtGegevensID
            // 
            this.txtGegevensID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGegevensID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtGegevensID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGegevensID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGegevensID.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGegevensID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtGegevensID.Location = new System.Drawing.Point(110, 121);
            this.txtGegevensID.MaxLength = 45;
            this.txtGegevensID.Multiline = true;
            this.txtGegevensID.Name = "txtGegevensID";
            this.txtGegevensID.Size = new System.Drawing.Size(68, 20);
            this.txtGegevensID.TabIndex = 81;
            this.txtGegevensID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGegevensID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnVorigRecord);
            this.panel1.Controls.Add(this.btnEersteRecord);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnVolgendRecord);
            this.panel1.Controls.Add(this.btnLaatsteRecord);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 101);
            this.panel1.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnRecordVerwijderen);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnRecordToevoegen);
            this.panel2.Controls.Add(this.btnRecordBewaren);
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 100);
            this.panel2.TabIndex = 83;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtGegevensID);
            this.panel3.Controls.Add(this.lblMeterID);
            this.panel3.Controls.Add(this.lblTemperatuur);
            this.panel3.Controls.Add(this.lblVochtigheid);
            this.panel3.Controls.Add(this.cmbWelkeMeter);
            this.panel3.Controls.Add(this.lblPM2_5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtZoekstring);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pnlZoekstring);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pnlMeterID);
            this.panel3.Controls.Add(this.cmbWelkVeld);
            this.panel3.Controls.Add(this.txtMeterID);
            this.panel3.Controls.Add(this.txtLuchtdruk);
            this.panel3.Controls.Add(this.pnlDatum);
            this.panel3.Controls.Add(this.pnlLuchtdruk);
            this.panel3.Controls.Add(this.txtDatum);
            this.panel3.Controls.Add(this.txtVochtigheid);
            this.panel3.Controls.Add(this.pnl2_5);
            this.panel3.Controls.Add(this.pnlVochtigheid);
            this.panel3.Controls.Add(this.txtPM2_5);
            this.panel3.Controls.Add(this.txtTemp);
            this.panel3.Controls.Add(this.pnlPM10);
            this.panel3.Controls.Add(this.pnlTemp);
            this.panel3.Controls.Add(this.txtPM10);
            this.panel3.Controls.Add(this.txtTijdstip);
            this.panel3.Controls.Add(this.pnlTijdstip);
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 338);
            this.panel3.TabIndex = 84;
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(807, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "FormData";
            this.Text = "FormData";
            this.Load += new System.EventHandler(this.FormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecordToevoegen;
        private System.Windows.Forms.Button btnRecordBewaren;
        private System.Windows.Forms.Button btnRecordVerwijderen;
        private System.Windows.Forms.Button btnLaatsteRecord;
        private System.Windows.Forms.Button btnVolgendRecord;
        private System.Windows.Forms.Button btnVorigRecord;
        private System.Windows.Forms.Button btnEersteRecord;
        private System.Windows.Forms.Label lblPM2_5;
        private System.Windows.Forms.Label lblVochtigheid;
        private System.Windows.Forms.Label lblTemperatuur;
        private System.Windows.Forms.Label lblMeterID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMeterID;
        private System.Windows.Forms.Panel pnlMeterID;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Panel pnlDatum;
        private System.Windows.Forms.TextBox txtPM2_5;
        private System.Windows.Forms.Panel pnl2_5;
        private System.Windows.Forms.TextBox txtPM10;
        private System.Windows.Forms.Panel pnlPM10;
        private System.Windows.Forms.TextBox txtTijdstip;
        private System.Windows.Forms.Panel pnlTijdstip;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Panel pnlTemp;
        private System.Windows.Forms.TextBox txtVochtigheid;
        private System.Windows.Forms.Panel pnlVochtigheid;
        private System.Windows.Forms.TextBox txtLuchtdruk;
        private System.Windows.Forms.Panel pnlLuchtdruk;
        private System.Windows.Forms.ComboBox cmbWelkVeld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtZoekstring;
        private System.Windows.Forms.Panel pnlZoekstring;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbWelkeMeter;
        private System.Windows.Forms.TextBox txtGegevensID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}