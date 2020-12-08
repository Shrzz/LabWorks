namespace MDI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MdiMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddObjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTankMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddHelicopterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBTRMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSubmarineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddShipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenu
            // 
            this.MdiMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.WindowMenuItem,
            this.AddObjectMenuItem});
            this.MdiMenu.Location = new System.Drawing.Point(0, 0);
            this.MdiMenu.MdiWindowListItem = this.WindowMenuItem;
            this.MdiMenu.Name = "MdiMenu";
            this.MdiMenu.Size = new System.Drawing.Size(800, 28);
            this.MdiMenu.TabIndex = 0;
            this.MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileMenuItem.Text = "&File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(216, 26);
            this.NewMenuItem.Text = "&New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ExitMenuItem.Text = "&Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascadeMenuItem,
            this.WindowTileMenu});
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(76, 24);
            this.WindowMenuItem.Text = "&Window";
            // 
            // WindowCascadeMenuItem
            // 
            this.WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            this.WindowCascadeMenuItem.Size = new System.Drawing.Size(139, 26);
            this.WindowCascadeMenuItem.Text = "&Cascade";
            this.WindowCascadeMenuItem.Click += new System.EventHandler(this.WindowCascadeMenuItem_Click);
            // 
            // WindowTileMenu
            // 
            this.WindowTileMenu.Name = "WindowTileMenu";
            this.WindowTileMenu.Size = new System.Drawing.Size(139, 26);
            this.WindowTileMenu.Text = "&Tile";
            this.WindowTileMenu.Click += new System.EventHandler(this.WindowTileMenu_Click);
            // 
            // AddObjectMenuItem
            // 
            this.AddObjectMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTankMenuItem,
            this.AddHelicopterMenuItem,
            this.AddBTRMenuItem,
            this.AddSubmarineMenuItem,
            this.AddShipMenuItem});
            this.AddObjectMenuItem.Name = "AddObjectMenuItem";
            this.AddObjectMenuItem.Size = new System.Drawing.Size(140, 24);
            this.AddObjectMenuItem.Text = "Добавить объект";
            // 
            // AddTankMenuItem
            // 
            this.AddTankMenuItem.Name = "AddTankMenuItem";
            this.AddTankMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AddTankMenuItem.Text = "Танк";
            this.AddTankMenuItem.Click += new System.EventHandler(this.AddTankMenuItem_Click);
            // 
            // AddHelicopterMenuItem
            // 
            this.AddHelicopterMenuItem.Name = "AddHelicopterMenuItem";
            this.AddHelicopterMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AddHelicopterMenuItem.Text = "Вертолёт";
            this.AddHelicopterMenuItem.Click += new System.EventHandler(this.AddHelicopterMenuItem_Click);
            // 
            // AddBTRMenuItem
            // 
            this.AddBTRMenuItem.Name = "AddBTRMenuItem";
            this.AddBTRMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AddBTRMenuItem.Text = "БТР";
            this.AddBTRMenuItem.Click += new System.EventHandler(this.AddBTRMenuItem_Click);
            // 
            // AddSubmarineMenuItem
            // 
            this.AddSubmarineMenuItem.Name = "AddSubmarineMenuItem";
            this.AddSubmarineMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AddSubmarineMenuItem.Text = "Подводная лодка";
            this.AddSubmarineMenuItem.Click += new System.EventHandler(this.AddSubmarineMenuItem_Click);
            // 
            // AddShipMenuItem
            // 
            this.AddShipMenuItem.Name = "AddShipMenuItem";
            this.AddShipMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AddShipMenuItem.Text = "Корабль";
            this.AddShipMenuItem.Click += new System.EventHandler(this.AddShipMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MdiMenu.ResumeLayout(false);
            this.MdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowCascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowTileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddObjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTankMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddHelicopterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddBTRMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSubmarineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddShipMenuItem;
    }
}

