
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnBladeren = new System.Windows.Forms.Button();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.dgvGegevens = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGegevens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTekst
            // 
            resources.ApplyResources(this.txtTekst, "txtTekst");
            this.txtTekst.Name = "txtTekst";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Name = "label2";
            // 
            // btnOpslaan
            // 
            resources.ApplyResources(this.btnOpslaan, "btnOpslaan");
            this.btnOpslaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpslaan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnBladeren
            // 
            resources.ApplyResources(this.btnBladeren, "btnBladeren");
            this.btnBladeren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBladeren.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBladeren.Name = "btnBladeren";
            this.btnBladeren.UseVisualStyleBackColor = true;
            this.btnBladeren.Click += new System.EventHandler(this.btnBladeren_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvGegevens
            // 
            resources.ApplyResources(this.dgvGegevens, "dgvGegevens");
            this.dgvGegevens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGegevens.Name = "dgvGegevens";
            // 
            // FormCSVToevoegen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.dgvGegevens);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBladeren);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTekst);
            this.Name = "FormCSVToevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGegevens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnBladeren;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.DataGridView dgvGegevens;
    }
}