namespace Drawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewFileToolBarItem = new System.Windows.Forms.ToolStripButton();
            this.OpenFileToolBarItem = new System.Windows.Forms.ToolStripButton();
            this.SaveFileToolBarItem = new System.Windows.Forms.ToolStripButton();
            this.PrintToolBarItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.InfoToolBarItem = new System.Windows.Forms.ToolStripButton();
            this.отображениеОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.FileName = "New picture";
            this.SaveFileDialog1.Filter = "(*.bmp) | *.bmp";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "(*.bmp) | *.bmp";
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.UseEXDialog = true;
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отображениеОконToolStripMenuItem,
            this.InfoMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(800, 28);
            this.MenuMain.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileMenuItem,
            this.OpenFileMenuItem,
            this.SaveFileMenuItem,
            this.PrintMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // NewFileMenuItem
            // 
            this.NewFileMenuItem.Name = "NewFileMenuItem";
            this.NewFileMenuItem.Size = new System.Drawing.Size(224, 26);
            this.NewFileMenuItem.Text = "Новый";
            this.NewFileMenuItem.Click += new System.EventHandler(this.NewFileMenuItem_Click);
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OpenFileMenuItem.Text = "Открыть";
            this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // SaveFileMenuItem
            // 
            this.SaveFileMenuItem.Name = "SaveFileMenuItem";
            this.SaveFileMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveFileMenuItem.Text = "Сохранить";
            this.SaveFileMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Name = "PrintMenuItem";
            this.PrintMenuItem.Size = new System.Drawing.Size(224, 26);
            this.PrintMenuItem.Text = "Печать";
            this.PrintMenuItem.Click += new System.EventHandler(this.PrintMenuItem_Click);
            // 
            // InfoMenuItem
            // 
            this.InfoMenuItem.Name = "InfoMenuItem";
            this.InfoMenuItem.Size = new System.Drawing.Size(62, 24);
            this.InfoMenuItem.Text = "Инфо";
            this.InfoMenuItem.Click += new System.EventHandler(this.InfoMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileToolBarItem,
            this.OpenFileToolBarItem,
            this.SaveFileToolBarItem,
            this.PrintToolBarItem,
            this.toolStripSeparator1,
            this.InfoToolBarItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewFileToolBarItem
            // 
            this.NewFileToolBarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFileToolBarItem.Image = ((System.Drawing.Image)(resources.GetObject("NewFileToolBarItem.Image")));
            this.NewFileToolBarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFileToolBarItem.Name = "NewFileToolBarItem";
            this.NewFileToolBarItem.Size = new System.Drawing.Size(29, 24);
            this.NewFileToolBarItem.Text = "&Создать";
            this.NewFileToolBarItem.Click += new System.EventHandler(this.NewFileToolBarItem_Click);
            // 
            // OpenFileToolBarItem
            // 
            this.OpenFileToolBarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileToolBarItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileToolBarItem.Image")));
            this.OpenFileToolBarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileToolBarItem.Name = "OpenFileToolBarItem";
            this.OpenFileToolBarItem.Size = new System.Drawing.Size(29, 24);
            this.OpenFileToolBarItem.Text = "&Открыть";
            this.OpenFileToolBarItem.Click += new System.EventHandler(this.OpenFileToolBarItem_Click);
            // 
            // SaveFileToolBarItem
            // 
            this.SaveFileToolBarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileToolBarItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileToolBarItem.Image")));
            this.SaveFileToolBarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileToolBarItem.Name = "SaveFileToolBarItem";
            this.SaveFileToolBarItem.Size = new System.Drawing.Size(29, 24);
            this.SaveFileToolBarItem.Text = "&Сохранить";
            this.SaveFileToolBarItem.Click += new System.EventHandler(this.SaveFileToolBarItem_Click);
            // 
            // PrintToolBarItem
            // 
            this.PrintToolBarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToolBarItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolBarItem.Image")));
            this.PrintToolBarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolBarItem.Name = "PrintToolBarItem";
            this.PrintToolBarItem.Size = new System.Drawing.Size(29, 24);
            this.PrintToolBarItem.Text = "&Печать";
            this.PrintToolBarItem.Click += new System.EventHandler(this.PrintToolBarItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // InfoToolBarItem
            // 
            this.InfoToolBarItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InfoToolBarItem.Image = ((System.Drawing.Image)(resources.GetObject("InfoToolBarItem.Image")));
            this.InfoToolBarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InfoToolBarItem.Name = "InfoToolBarItem";
            this.InfoToolBarItem.Size = new System.Drawing.Size(29, 24);
            this.InfoToolBarItem.Text = "Спр&авка";
            // 
            // отображениеОконToolStripMenuItem
            // 
            this.отображениеОконToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HorizontalTileMenuItem,
            this.VerticalTileMenuItem,
            this.CascadeTileMenuItem});
            this.отображениеОконToolStripMenuItem.Name = "отображениеОконToolStripMenuItem";
            this.отображениеОконToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.отображениеОконToolStripMenuItem.Text = "Отображение окон";
            // 
            // HorizontalTileMenuItem
            // 
            this.HorizontalTileMenuItem.Name = "HorizontalTileMenuItem";
            this.HorizontalTileMenuItem.Size = new System.Drawing.Size(224, 26);
            this.HorizontalTileMenuItem.Text = "HorizontalTile";
            this.HorizontalTileMenuItem.Click += new System.EventHandler(this.HorizontalTileMenuItem_Click);
            // 
            // VerticalTileMenuItem
            // 
            this.VerticalTileMenuItem.Name = "VerticalTileMenuItem";
            this.VerticalTileMenuItem.Size = new System.Drawing.Size(224, 26);
            this.VerticalTileMenuItem.Text = "VerticalTile";
            this.VerticalTileMenuItem.Click += new System.EventHandler(this.VerticalTileMenuItem_Click);
            // 
            // CascadeTileMenuItem
            // 
            this.CascadeTileMenuItem.Name = "CascadeTileMenuItem";
            this.CascadeTileMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CascadeTileMenuItem.Text = "Cascade";
            this.CascadeTileMenuItem.Click += new System.EventHandler(this.CascadeTileMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MenuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuMain;
            this.Name = "Form1";
            this.Text = "New picture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.PrintDialog PrintDialog1;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewFileToolBarItem;
        private System.Windows.Forms.ToolStripButton OpenFileToolBarItem;
        private System.Windows.Forms.ToolStripButton SaveFileToolBarItem;
        private System.Windows.Forms.ToolStripButton PrintToolBarItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton InfoToolBarItem;
        private System.Windows.Forms.ToolStripMenuItem InfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отображениеОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorizontalTileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerticalTileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadeTileMenuItem;
    }
}

