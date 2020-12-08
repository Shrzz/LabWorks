namespace Drawing
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ChildPictureBox = new System.Windows.Forms.PictureBox();
            this.StatusBar1 = new System.Windows.Forms.StatusStrip();
            this.CurrentPositionStatusBarItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.LineColorDialog = new System.Windows.Forms.ColorDialog();
            this.BackgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.BrushSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.ChildToolStrip = new System.Windows.Forms.ToolStrip();
            this.LineColorItemTS = new System.Windows.Forms.ToolStripButton();
            this.BackgroundColorItemTS = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChildPictureBox)).BeginInit();
            this.StatusBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeNumeric)).BeginInit();
            this.ChildToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildPictureBox
            // 
            this.ChildPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPictureBox.Location = new System.Drawing.Point(0, 27);
            this.ChildPictureBox.Name = "ChildPictureBox";
            this.ChildPictureBox.Size = new System.Drawing.Size(800, 423);
            this.ChildPictureBox.TabIndex = 5;
            this.ChildPictureBox.TabStop = false;
            // 
            // StatusBar1
            // 
            this.StatusBar1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentPositionStatusBarItem});
            this.StatusBar1.Location = new System.Drawing.Point(0, 424);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Size = new System.Drawing.Size(800, 26);
            this.StatusBar1.TabIndex = 6;
            this.StatusBar1.Text = "statusStrip1";
            // 
            // CurrentPositionStatusBarItem
            // 
            this.CurrentPositionStatusBarItem.Name = "CurrentPositionStatusBarItem";
            this.CurrentPositionStatusBarItem.Size = new System.Drawing.Size(151, 20);
            this.CurrentPositionStatusBarItem.Text = "toolStripStatusLabel1";
            // 
            // BackgroundColorDialog
            // 
            this.BackgroundColorDialog.Color = System.Drawing.Color.White;
            // 
            // BrushSizeNumeric
            // 
            this.BrushSizeNumeric.Location = new System.Drawing.Point(337, 2);
            this.BrushSizeNumeric.Name = "BrushSizeNumeric";
            this.BrushSizeNumeric.Size = new System.Drawing.Size(95, 22);
            this.BrushSizeNumeric.TabIndex = 8;
            // 
            // ChildToolStrip
            // 
            this.ChildToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChildToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineColorItemTS,
            this.BackgroundColorItemTS});
            this.ChildToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ChildToolStrip.Name = "ChildToolStrip";
            this.ChildToolStrip.Size = new System.Drawing.Size(800, 27);
            this.ChildToolStrip.TabIndex = 9;
            this.ChildToolStrip.Text = "toolStrip1";
            // 
            // LineColorItemTS
            // 
            this.LineColorItemTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LineColorItemTS.Image = ((System.Drawing.Image)(resources.GetObject("LineColorItemTS.Image")));
            this.LineColorItemTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineColorItemTS.Name = "LineColorItemTS";
            this.LineColorItemTS.Size = new System.Drawing.Size(94, 24);
            this.LineColorItemTS.Text = "Цвет линии";
            this.LineColorItemTS.Click += new System.EventHandler(this.LineColorItemTS_Click);
            // 
            // BackgroundColorItemTS
            // 
            this.BackgroundColorItemTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackgroundColorItemTS.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundColorItemTS.Image")));
            this.BackgroundColorItemTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackgroundColorItemTS.Name = "BackgroundColorItemTS";
            this.BackgroundColorItemTS.Size = new System.Drawing.Size(86, 24);
            this.BackgroundColorItemTS.Text = "Цвет фона";
            this.BackgroundColorItemTS.Click += new System.EventHandler(this.BackgroundColorItemTS_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrushSizeNumeric);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.ChildPictureBox);
            this.Controls.Add(this.ChildToolStrip);
            this.Name = "Form2";
            this.Text = "frmChild";
            ((System.ComponentModel.ISupportInitialize)(this.ChildPictureBox)).EndInit();
            this.StatusBar1.ResumeLayout(false);
            this.StatusBar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeNumeric)).EndInit();
            this.ChildToolStrip.ResumeLayout(false);
            this.ChildToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusBar1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentPositionStatusBarItem;
        private System.Windows.Forms.ColorDialog LineColorDialog;
        private System.Windows.Forms.ColorDialog BackgroundColorDialog;
        private System.Windows.Forms.NumericUpDown BrushSizeNumeric;
        private System.Windows.Forms.ToolStrip ChildToolStrip;
        private System.Windows.Forms.ToolStripButton LineColorItemTS;
        private System.Windows.Forms.ToolStripButton BackgroundColorItemTS;
        public System.Windows.Forms.PictureBox ChildPictureBox;
    }
}