namespace MDI
{
    partial class ChildForm
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
            this.ChildTextBox = new System.Windows.Forms.RichTextBox();
            this.ChlidContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChildWindowMenu = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowInfoChildMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChlidContextMenu.SuspendLayout();
            this.ChildWindowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildTextBox
            // 
            this.ChildTextBox.ContextMenuStrip = this.ChlidContextMenu;
            this.ChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildTextBox.Location = new System.Drawing.Point(0, 28);
            this.ChildTextBox.Name = "ChildTextBox";
            this.ChildTextBox.Size = new System.Drawing.Size(800, 422);
            this.ChildTextBox.TabIndex = 0;
            this.ChildTextBox.Text = "";
            // 
            // ChlidContextMenu
            // 
            this.ChlidContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChlidContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyContextMenuItem,
            this.CutContextMenuItem,
            this.PasteContextMenuItem,
            this.DeleteContextMenuItem,
            this.SelectAllContextMenuItem});
            this.ChlidContextMenu.Name = "ChlidContextMenu";
            this.ChlidContextMenu.Size = new System.Drawing.Size(141, 124);
            // 
            // CopyContextMenuItem
            // 
            this.CopyContextMenuItem.Name = "CopyContextMenuItem";
            this.CopyContextMenuItem.Size = new System.Drawing.Size(140, 24);
            this.CopyContextMenuItem.Text = "Copy";
            this.CopyContextMenuItem.Click += new System.EventHandler(this.CopyContextMenuItem_Click);
            // 
            // CutContextMenuItem
            // 
            this.CutContextMenuItem.Name = "CutContextMenuItem";
            this.CutContextMenuItem.Size = new System.Drawing.Size(140, 24);
            this.CutContextMenuItem.Text = "Cut";
            this.CutContextMenuItem.Click += new System.EventHandler(this.CutContextMenuItem_Click);
            // 
            // PasteContextMenuItem
            // 
            this.PasteContextMenuItem.Name = "PasteContextMenuItem";
            this.PasteContextMenuItem.Size = new System.Drawing.Size(140, 24);
            this.PasteContextMenuItem.Text = "Paste";
            this.PasteContextMenuItem.Click += new System.EventHandler(this.PasteContextMenuItem_Click);
            // 
            // DeleteContextMenuItem
            // 
            this.DeleteContextMenuItem.Name = "DeleteContextMenuItem";
            this.DeleteContextMenuItem.Size = new System.Drawing.Size(140, 24);
            this.DeleteContextMenuItem.Text = "Delete";
            this.DeleteContextMenuItem.Click += new System.EventHandler(this.DeleteContextMenuItem_Click);
            // 
            // SelectAllContextMenuItem
            // 
            this.SelectAllContextMenuItem.Name = "SelectAllContextMenuItem";
            this.SelectAllContextMenuItem.Size = new System.Drawing.Size(140, 24);
            this.SelectAllContextMenuItem.Text = "Select All";
            this.SelectAllContextMenuItem.Click += new System.EventHandler(this.SelectAllContextMenuItem_Click);
            // 
            // ChildWindowMenu
            // 
            this.ChildWindowMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChildWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.ShowInfoChildMenuItem});
            this.ChildWindowMenu.Location = new System.Drawing.Point(0, 0);
            this.ChildWindowMenu.Name = "ChildWindowMenu";
            this.ChildWindowMenu.Size = new System.Drawing.Size(800, 28);
            this.ChildWindowMenu.TabIndex = 1;
            this.ChildWindowMenu.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMenuItem,
            this.CutMenuItem,
            this.PasteMenuItem,
            this.DeleteMenuItem,
            this.SelectAllMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(146, 26);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.Size = new System.Drawing.Size(146, 26);
            this.CutMenuItem.Text = "Cut";
            this.CutMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.Size = new System.Drawing.Size(146, 26);
            this.PasteMenuItem.Text = "Paste";
            this.PasteMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(146, 26);
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // SelectAllMenuItem
            // 
            this.SelectAllMenuItem.Name = "SelectAllMenuItem";
            this.SelectAllMenuItem.Size = new System.Drawing.Size(146, 26);
            this.SelectAllMenuItem.Text = "Select All";
            this.SelectAllMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // ShowInfoChildMenuItem
            // 
            this.ShowInfoChildMenuItem.Name = "ShowInfoChildMenuItem";
            this.ShowInfoChildMenuItem.Size = new System.Drawing.Size(202, 24);
            this.ShowInfoChildMenuItem.Text = "Отобразить информацию";
            this.ShowInfoChildMenuItem.Click += new System.EventHandler(this.ShowInfoChildMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildTextBox);
            this.Controls.Add(this.ChildWindowMenu);
            this.MainMenuStrip = this.ChildWindowMenu;
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ChlidContextMenu.ResumeLayout(false);
            this.ChildWindowMenu.ResumeLayout(false);
            this.ChildWindowMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox ChildTextBox;
        private System.Windows.Forms.MenuStrip ChildWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMenuItem;
        private System.Windows.Forms.ContextMenuStrip ChlidContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowInfoChildMenuItem;
    }
}