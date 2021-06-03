
namespace FijnstofGIP.FormsMenu
{
    partial class FormCSVToevoegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCSVToevoegen));
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.dgCSV = new System.Windows.Forms.DataGridView();
            this.meterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM2_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatuur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vochtigheid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luchtdruk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tijdstip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.btnSelecteren = new System.Windows.Forms.Button();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTekst
            // 
            resources.ApplyResources(this.txtTekst, "txtTekst");
            this.txtTekst.Name = "txtTekst";
            // 
            // dgCSV
            // 
            this.dgCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meterID,
            this.PM2_5,
            this.PM10,
            this.temperatuur,
            this.vochtigheid,
            this.luchtdruk,
            this.tijdstip,
            this.datum});
            resources.ApplyResources(this.dgCSV, "dgCSV");
            this.dgCSV.Name = "dgCSV";
            // 
            // meterID
            // 
            this.meterID.DataPropertyName = "meterID";
            resources.ApplyResources(this.meterID, "meterID");
            this.meterID.Name = "meterID";
            this.meterID.ReadOnly = true;
            // 
            // PM2_5
            // 
            this.PM2_5.DataPropertyName = "PM2_5";
            resources.ApplyResources(this.PM2_5, "PM2_5");
            this.PM2_5.Name = "PM2_5";
            this.PM2_5.ReadOnly = true;
            // 
            // PM10
            // 
            this.PM10.DataPropertyName = "PM10";
            resources.ApplyResources(this.PM10, "PM10");
            this.PM10.Name = "PM10";
            this.PM10.ReadOnly = true;
            // 
            // temperatuur
            // 
            this.temperatuur.DataPropertyName = "temperatuur";
            resources.ApplyResources(this.temperatuur, "temperatuur");
            this.temperatuur.Name = "temperatuur";
            this.temperatuur.ReadOnly = true;
            // 
            // vochtigheid
            // 
            this.vochtigheid.DataPropertyName = "vochtigheid";
            resources.ApplyResources(this.vochtigheid, "vochtigheid");
            this.vochtigheid.Name = "vochtigheid";
            this.vochtigheid.ReadOnly = true;
            // 
            // luchtdruk
            // 
            this.luchtdruk.DataPropertyName = "luchtdruk";
            resources.ApplyResources(this.luchtdruk, "luchtdruk");
            this.luchtdruk.Name = "luchtdruk";
            this.luchtdruk.ReadOnly = true;
            // 
            // tijdstip
            // 
            this.tijdstip.DataPropertyName = "tijdstip";
            resources.ApplyResources(this.tijdstip, "tijdstip");
            this.tijdstip.Name = "tijdstip";
            this.tijdstip.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.DataPropertyName = "datum";
            resources.ApplyResources(this.datum, "datum");
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Name = "label2";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnOpslaan, "btnOpslaan");
            this.btnOpslaan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnSluiten, "BtnSluiten");
            this.BtnSluiten.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // btnSelecteren
            // 
            this.btnSelecteren.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSelecteren, "btnSelecteren");
            this.btnSelecteren.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSelecteren.Name = "btnSelecteren";
            this.btnSelecteren.UseVisualStyleBackColor = true;
            this.btnSelecteren.Click += new System.EventHandler(this.btnSelecteren_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormCSVToevoegen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelecteren);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgCSV);
            this.Controls.Add(this.txtTekst);
            this.Name = "FormCSVToevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.dgCSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.DataGridView dgCSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button BtnSluiten;
        private System.Windows.Forms.Button btnSelecteren;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM2_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM10;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatuur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vochtigheid;
        private System.Windows.Forms.DataGridViewTextBoxColumn luchtdruk;
        private System.Windows.Forms.DataGridViewTextBoxColumn tijdstip;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
    }
}