﻿namespace lab_1
{
    partial class MainForm
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
            this.pictureBoxPaintArea = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaintArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPaintArea
            // 
            this.pictureBoxPaintArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPaintArea.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPaintArea.Name = "pictureBoxPaintArea";
            this.pictureBoxPaintArea.Size = new System.Drawing.Size(798, 585);
            this.pictureBoxPaintArea.TabIndex = 0;
            this.pictureBoxPaintArea.TabStop = false;
            this.pictureBoxPaintArea.Click += new System.EventHandler(this.pictureBoxPaintArea_Click);
            this.pictureBoxPaintArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaintArea_MouseDown);
            this.pictureBoxPaintArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaintArea_MouseMove);
            this.pictureBoxPaintArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaintArea_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 609);
            this.Controls.Add(this.pictureBoxPaintArea);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaintArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPaintArea;
        private System.Windows.Forms.Timer timer1;
    }
}