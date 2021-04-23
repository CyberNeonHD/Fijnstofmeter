
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LaadschermTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LaadschermPB
            // 
            this.LaadschermPB.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("LaadschermPB.AnimationFunction")));
            this.LaadschermPB.AnimationSpeed = 500;
            this.LaadschermPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.LaadschermPB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LaadschermPB.Font = new System.Drawing.Font("Myanmar Text", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaadschermPB.ForeColor = System.Drawing.Color.Red;
            this.LaadschermPB.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.LaadschermPB.InnerMargin = 2;
            this.LaadschermPB.InnerWidth = -1;
            this.LaadschermPB.Location = new System.Drawing.Point(47, 101);
            this.LaadschermPB.MarqueeAnimationSpeed = 2000;
            this.LaadschermPB.Name = "LaadschermPB";
            this.LaadschermPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.LaadschermPB.OuterMargin = -25;
            this.LaadschermPB.OuterWidth = 26;
            this.LaadschermPB.ProgressColor = System.Drawing.Color.Red;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fijnstofmeter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(74, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inladen...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gemaakt door Kobbe en Alex";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LaadschermTimer
            // 
            this.LaadschermTimer.Enabled = true;
            this.LaadschermTimer.Tick += new System.EventHandler(this.LaadschermTimer_Tick);
            // 
            // Laadscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(255, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaadschermPB);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laadscherm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laadscherm";
            this.Load += new System.EventHandler(this.Laadscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar LaadschermPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer LaadschermTimer;
    }
}