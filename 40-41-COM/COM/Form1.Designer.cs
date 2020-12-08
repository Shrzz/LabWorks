namespace lr40_41
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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьШаблонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadTemplateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTemplateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultTemplateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkCodeNeeded = new System.Windows.Forms.CheckBox();
            this.WorkNumberTextBox = new System.Windows.Forms.TextBox();
            this.WorkNumberLabel = new System.Windows.Forms.Label();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.AimLabel = new System.Windows.Forms.Label();
            this.EquipmentLabel = new System.Windows.Forms.Label();
            this.GroupNumberLabel = new System.Windows.Forms.Label();
            this.GroupNumberTextBox = new System.Windows.Forms.TextBox();
            this.FITextBox = new System.Windows.Forms.TextBox();
            this.FILabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.TopicRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AimRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EquipmentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fbdReportPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChangeReportPath = new System.Windows.Forms.Button();
            this.lbReportPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(414, 384);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(171, 23);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Создать файл";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            this.OpenFileDialog1.Multiselect = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.файлToolStripMenuItem.Text = " Файл";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сделатьШаблонToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // сделатьШаблонToolStripMenuItem
            // 
            this.сделатьШаблонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadTemplateMenuItem,
            this.SaveTemplateMenuItem,
            this.DefaultTemplateMenuItem});
            this.сделатьШаблонToolStripMenuItem.Name = "сделатьШаблонToolStripMenuItem";
            this.сделатьШаблонToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.сделатьШаблонToolStripMenuItem.Text = "Шаблон";
            // 
            // LoadTemplateMenuItem
            // 
            this.LoadTemplateMenuItem.Name = "LoadTemplateMenuItem";
            this.LoadTemplateMenuItem.Size = new System.Drawing.Size(270, 26);
            this.LoadTemplateMenuItem.Text = "Загрузить";
            this.LoadTemplateMenuItem.Click += new System.EventHandler(this.LoadTemplateMenuItem_Click);
            // 
            // SaveTemplateMenuItem
            // 
            this.SaveTemplateMenuItem.Name = "SaveTemplateMenuItem";
            this.SaveTemplateMenuItem.Size = new System.Drawing.Size(270, 26);
            this.SaveTemplateMenuItem.Text = "Сохранить";
            // 
            // DefaultTemplateMenuItem
            // 
            this.DefaultTemplateMenuItem.Name = "DefaultTemplateMenuItem";
            this.DefaultTemplateMenuItem.Size = new System.Drawing.Size(270, 26);
            this.DefaultTemplateMenuItem.Text = "Загружать по умолчанию";
            // 
            // chkCodeNeeded
            // 
            this.chkCodeNeeded.AutoSize = true;
            this.chkCodeNeeded.Location = new System.Drawing.Point(414, 357);
            this.chkCodeNeeded.Name = "chkCodeNeeded";
            this.chkCodeNeeded.Size = new System.Drawing.Size(161, 21);
            this.chkCodeNeeded.TabIndex = 2;
            this.chkCodeNeeded.Text = "Нужно вставить код";
            this.chkCodeNeeded.UseVisualStyleBackColor = true;
            // 
            // WorkNumberTextBox
            // 
            this.WorkNumberTextBox.Location = new System.Drawing.Point(12, 48);
            this.WorkNumberTextBox.Name = "WorkNumberTextBox";
            this.WorkNumberTextBox.Size = new System.Drawing.Size(239, 22);
            this.WorkNumberTextBox.TabIndex = 3;
            // 
            // WorkNumberLabel
            // 
            this.WorkNumberLabel.AutoSize = true;
            this.WorkNumberLabel.Location = new System.Drawing.Point(12, 28);
            this.WorkNumberLabel.Name = "WorkNumberLabel";
            this.WorkNumberLabel.Size = new System.Drawing.Size(104, 17);
            this.WorkNumberLabel.TabIndex = 4;
            this.WorkNumberLabel.Text = "Номер работы";
            // 
            // TopicLabel
            // 
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Location = new System.Drawing.Point(12, 209);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(95, 17);
            this.TopicLabel.TabIndex = 5;
            this.TopicLabel.Text = "Тема работы";
            // 
            // AimLabel
            // 
            this.AimLabel.AutoSize = true;
            this.AimLabel.Location = new System.Drawing.Point(12, 307);
            this.AimLabel.Name = "AimLabel";
            this.AimLabel.Size = new System.Drawing.Size(95, 17);
            this.AimLabel.TabIndex = 7;
            this.AimLabel.Text = "Цель работы";
            // 
            // EquipmentLabel
            // 
            this.EquipmentLabel.AutoSize = true;
            this.EquipmentLabel.Location = new System.Drawing.Point(12, 405);
            this.EquipmentLabel.Name = "EquipmentLabel";
            this.EquipmentLabel.Size = new System.Drawing.Size(85, 17);
            this.EquipmentLabel.TabIndex = 9;
            this.EquipmentLabel.Text = "Оснащение";
            // 
            // GroupNumberLabel
            // 
            this.GroupNumberLabel.AutoSize = true;
            this.GroupNumberLabel.Location = new System.Drawing.Point(12, 73);
            this.GroupNumberLabel.Name = "GroupNumberLabel";
            this.GroupNumberLabel.Size = new System.Drawing.Size(101, 17);
            this.GroupNumberLabel.TabIndex = 12;
            this.GroupNumberLabel.Text = "Номер группы";
            // 
            // GroupNumberTextBox
            // 
            this.GroupNumberTextBox.Location = new System.Drawing.Point(12, 93);
            this.GroupNumberTextBox.Name = "GroupNumberTextBox";
            this.GroupNumberTextBox.Size = new System.Drawing.Size(239, 22);
            this.GroupNumberTextBox.TabIndex = 13;
            // 
            // FITextBox
            // 
            this.FITextBox.Location = new System.Drawing.Point(12, 138);
            this.FITextBox.Name = "FITextBox";
            this.FITextBox.Size = new System.Drawing.Size(239, 22);
            this.FITextBox.TabIndex = 14;
            // 
            // FILabel
            // 
            this.FILabel.AutoSize = true;
            this.FILabel.Location = new System.Drawing.Point(12, 118);
            this.FILabel.Name = "FILabel";
            this.FILabel.Size = new System.Drawing.Size(144, 17);
            this.FILabel.TabIndex = 15;
            this.FILabel.Text = "Фамилия, инициалы";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 164);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(127, 17);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Дата выполнения";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(12, 184);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(239, 22);
            this.DateTextBox.TabIndex = 17;
            // 
            // TopicRichTextBox
            // 
            this.TopicRichTextBox.Location = new System.Drawing.Point(12, 229);
            this.TopicRichTextBox.Name = "TopicRichTextBox";
            this.TopicRichTextBox.Size = new System.Drawing.Size(239, 75);
            this.TopicRichTextBox.TabIndex = 20;
            this.TopicRichTextBox.Text = "";
            // 
            // AimRichTextBox
            // 
            this.AimRichTextBox.Location = new System.Drawing.Point(12, 327);
            this.AimRichTextBox.Name = "AimRichTextBox";
            this.AimRichTextBox.Size = new System.Drawing.Size(239, 75);
            this.AimRichTextBox.TabIndex = 21;
            this.AimRichTextBox.Text = "";
            // 
            // EquipmentRichTextBox
            // 
            this.EquipmentRichTextBox.Location = new System.Drawing.Point(12, 425);
            this.EquipmentRichTextBox.Name = "EquipmentRichTextBox";
            this.EquipmentRichTextBox.Size = new System.Drawing.Size(239, 75);
            this.EquipmentRichTextBox.TabIndex = 22;
            this.EquipmentRichTextBox.Text = "";
            // 
            // btnChangeReportPath
            // 
            this.btnChangeReportPath.Location = new System.Drawing.Point(378, 118);
            this.btnChangeReportPath.Name = "btnChangeReportPath";
            this.btnChangeReportPath.Size = new System.Drawing.Size(197, 23);
            this.btnChangeReportPath.TabIndex = 23;
            this.btnChangeReportPath.Text = "Изменить путь";
            this.btnChangeReportPath.UseVisualStyleBackColor = true;
            this.btnChangeReportPath.Click += new System.EventHandler(this.btnPathSave_Click);
            // 
            // lbReportPath
            // 
            this.lbReportPath.AutoSize = true;
            this.lbReportPath.Location = new System.Drawing.Point(375, 73);
            this.lbReportPath.Name = "lbReportPath";
            this.lbReportPath.Size = new System.Drawing.Size(0, 17);
            this.lbReportPath.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Текущий путь к отчёту:";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = ".docx |*.docx";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 484);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 512);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbReportPath);
            this.Controls.Add(this.btnChangeReportPath);
            this.Controls.Add(this.EquipmentRichTextBox);
            this.Controls.Add(this.AimRichTextBox);
            this.Controls.Add(this.TopicRichTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.FILabel);
            this.Controls.Add(this.FITextBox);
            this.Controls.Add(this.GroupNumberTextBox);
            this.Controls.Add(this.GroupNumberLabel);
            this.Controls.Add(this.EquipmentLabel);
            this.Controls.Add(this.AimLabel);
            this.Controls.Add(this.TopicLabel);
            this.Controls.Add(this.WorkNumberLabel);
            this.Controls.Add(this.WorkNumberTextBox);
            this.Controls.Add(this.chkCodeNeeded);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа 40-41";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkCodeNeeded;
        private System.Windows.Forms.TextBox WorkNumberTextBox;
        private System.Windows.Forms.Label WorkNumberLabel;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.Label AimLabel;
        private System.Windows.Forms.Label EquipmentLabel;
        private System.Windows.Forms.Label GroupNumberLabel;
        private System.Windows.Forms.TextBox GroupNumberTextBox;
        private System.Windows.Forms.TextBox FITextBox;
        private System.Windows.Forms.Label FILabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьШаблонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadTemplateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTemplateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DefaultTemplateMenuItem;
        private System.Windows.Forms.RichTextBox TopicRichTextBox;
        private System.Windows.Forms.RichTextBox AimRichTextBox;
        private System.Windows.Forms.RichTextBox EquipmentRichTextBox;
        private System.Windows.Forms.FolderBrowserDialog fbdReportPath;
        private System.Windows.Forms.Button btnChangeReportPath;
        private System.Windows.Forms.Label lbReportPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.Splitter splitter1;
    }
}

