
namespace FijnstofGIP
{
    partial class Laadscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laadscherm));
            this.LaadschermPB = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.LaadschermTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLaden = new System.Windows.Forms.Label();
            this.MenuLogo = new System.Windows.Forms.PictureBox();
            this.TxtTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LaadschermPB
            // 
            this.LaadschermPB.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("LaadschermPB.AnimationFunction")));
            this.LaadschermPB.AnimationSpeed = 500;
            this.LaadschermPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.LaadschermPB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LaadschermPB.Font = new System.Drawing.Font("Myanmar Text", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaadschermPB.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LaadschermPB.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.LaadschermPB.InnerMargin = 2;
            this.LaadschermPB.InnerWidth = -1;
            this.LaadschermPB.Location = new System.Drawing.Point(47, 122);
            this.LaadschermPB.MarqueeAnimationSpeed = 2000;
            this.LaadschermPB.Name = "LaadschermPB";
            this.LaadschermPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.LaadschermPB.OuterMargin = -25;
            this.LaadschermPB.OuterWidth = 26;
            this.LaadschermPB.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.LaadschermPB.ProgressWidth = 8;
            this.LaadschermPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LaadschermPB.Size = new System.Drawing.Size(150, 150);
            this.LaadschermPB.StartAngle = 270;
            this.LaadschermPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LaadschermPB.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LaadschermPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LaadschermPB.SubscriptText = "";
            this.LaadschermPB.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LaadschermPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LaadschermPB.SuperscriptText = "";
            this.LaadschermPB.TabIndex = 0;
            this.LaadschermPB.TextMargin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.LaadschermPB.Value = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(45, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gemaakt door Kalex";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LaadschermTimer
            // 
            this.LaadschermTimer.Enabled = true;
            this.LaadschermTimer.Tick += new System.EventHandler(this.LaadschermTimer_Tick);
            // 
            // lblLaden
            // 
            this.lblLaden.AutoSize = true;
            this.lblLaden.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaden.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLaden.Location = new System.Drawing.Point(66, 275);
            this.lblLaden.Name = "lblLaden";
            this.lblLaden.Size = new System.Drawing.Size(115, 37);
            this.lblLaden.TabIndex = 1;
            this.lblLaden.Text = "Inladen....";
            // 
            // MenuLogo
            // 
            this.MenuLogo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.MenuLogo.Image = global::FijnstofGIP.Properties.Resources.output_onlinepngtools;
            this.MenuLogo.Location = new System.Drawing.Point(26, 3);
            this.MenuLogo.Name = "MenuLogo";
            this.MenuLogo.Size = new System.Drawing.Size(194, 140);
            this.MenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuLogo.TabIndex = 2;
            this.MenuLogo.TabStop = false;
            // 
            // TxtTimer
            // 
            this.TxtTimer.Interval = 500;
            this.TxtTimer.Tick += new System.EventHandler(this.TxtTimer_Tick);
            // 
            // Laadscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(255, 378);
            this.Controls.Add(this.lblLaden);
            this.Controls.Add(this.LaadschermPB);
            this.Controls.Add(this.MenuLogo);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laadscherm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laadscherm";
            this.Load += new System.EventHandler(this.Laadscherm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar LaadschermPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer LaadschermTimer;
        private System.Windows.Forms.Label lblLaden;
        private System.Windows.Forms.PictureBox MenuLogo;
        private System.Windows.Forms.Timer TxtTimer;
    }
}