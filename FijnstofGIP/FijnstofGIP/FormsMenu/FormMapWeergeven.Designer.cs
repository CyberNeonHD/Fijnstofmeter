
namespace FijnstofGIP.FormsMenu
{
    partial class FormMapWeergeven
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
            this.GoogleMap = new GMap.NET.WindowsForms.GMapControl();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // GoogleMap
            // 
            this.GoogleMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoogleMap.Bearing = 0F;
            this.GoogleMap.CanDragMap = true;
            this.GoogleMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.GoogleMap.GrayScaleMode = false;
            this.GoogleMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GoogleMap.LevelsKeepInMemmory = 5;
            this.GoogleMap.Location = new System.Drawing.Point(12, 21);
            this.GoogleMap.MarkersEnabled = true;
            this.GoogleMap.MaxZoom = 2;
            this.GoogleMap.MinZoom = 2;
            this.GoogleMap.MouseWheelZoomEnabled = true;
            this.GoogleMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GoogleMap.Name = "GoogleMap";
            this.GoogleMap.NegativeMode = false;
            this.GoogleMap.PolygonsEnabled = true;
            this.GoogleMap.RetryLoadTile = 0;
            this.GoogleMap.RoutesEnabled = true;
            this.GoogleMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GoogleMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GoogleMap.ShowTileGridLines = false;
            this.GoogleMap.Size = new System.Drawing.Size(783, 516);
            this.GoogleMap.TabIndex = 0;
            this.GoogleMap.Zoom = 0D;
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
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMapWeergeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(807, 540);
            this.Controls.Add(this.GoogleMap);
            this.Controls.Add(this.btnClose);
            this.Name = "FormMapWeergeven";
            this.Text = "FormMapWeergeven";
            this.Load += new System.EventHandler(this.FormMapWeergeven_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GoogleMap;
        private FontAwesome.Sharp.IconPictureBox btnClose;
    }
}