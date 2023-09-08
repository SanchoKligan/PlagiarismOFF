namespace PlagiarismOFF
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MPanel = new System.Windows.Forms.MenuStrip();
            this.fl = new System.Windows.Forms.ToolStripMenuItem();
            this.flChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.flClose = new System.Windows.Forms.ToolStripMenuItem();
            this.opt = new System.Windows.Forms.ToolStripMenuItem();
            this.optOpJrn = new System.Windows.Forms.ToolStripMenuItem();
            this.optSett = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProg = new System.Windows.Forms.ToolStripMenuItem();
            this.catChoose = new System.Windows.Forms.ComboBox();
            this.chkStart = new System.Windows.Forms.Button();
            this.labFlChoose = new System.Windows.Forms.Label();
            this.flChoose2 = new System.Windows.Forms.Button();
            this.CatError = new System.Windows.Forms.ErrorProvider(this.components);
            this.FileError = new System.Windows.Forms.ErrorProvider(this.components);
            this.labRes = new System.Windows.Forms.Label();
            this.chkProg = new System.Windows.Forms.ProgressBar();
            this.matchBox = new System.Windows.Forms.ListBox();
            this.matchLab = new System.Windows.Forms.Label();
            this.MPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileError)).BeginInit();
            this.SuspendLayout();
            // 
            // MPanel
            // 
            this.MPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fl,
            this.opt,
            this.aboutProg});
            this.MPanel.Location = new System.Drawing.Point(0, 0);
            this.MPanel.Name = "MPanel";
            this.MPanel.Size = new System.Drawing.Size(800, 28);
            this.MPanel.TabIndex = 0;
            this.MPanel.Text = "MPanel";
            // 
            // fl
            // 
            this.fl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flChoose,
            this.toolStripSeparator1,
            this.flClose});
            this.fl.Name = "fl";
            this.fl.Size = new System.Drawing.Size(57, 24);
            this.fl.Text = "Файл";
            // 
            // flChoose
            // 
            this.flChoose.Name = "flChoose";
            this.flChoose.Size = new System.Drawing.Size(144, 26);
            this.flChoose.Text = "Выбрать";
            this.flChoose.Click += new System.EventHandler(this.FlChoose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // flClose
            // 
            this.flClose.Name = "flClose";
            this.flClose.Size = new System.Drawing.Size(144, 26);
            this.flClose.Text = "Выход";
            this.flClose.Click += new System.EventHandler(this.FlClose_Click);
            // 
            // opt
            // 
            this.opt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optOpJrn,
            this.optSett});
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(68, 24);
            this.opt.Text = "Опции";
            // 
            // optOpJrn
            // 
            this.optOpJrn.Name = "optOpJrn";
            this.optOpJrn.Size = new System.Drawing.Size(216, 26);
            this.optOpJrn.Text = "Журнал статистики";
            this.optOpJrn.Click += new System.EventHandler(this.OptOpJrn_Click);
            // 
            // optSett
            // 
            this.optSett.Name = "optSett";
            this.optSett.Size = new System.Drawing.Size(216, 26);
            this.optSett.Text = "Настройки";
            this.optSett.Click += new System.EventHandler(this.OptSett_Click);
            // 
            // aboutProg
            // 
            this.aboutProg.Name = "aboutProg";
            this.aboutProg.Size = new System.Drawing.Size(116, 24);
            this.aboutProg.Text = "О программе";
            this.aboutProg.Click += new System.EventHandler(this.AboutProg_Click);
            // 
            // catChoose
            // 
            this.catChoose.FormattingEnabled = true;
            this.catChoose.Items.AddRange(new object[] {
            "Текст на русском языке",
            "Текст на английском языке",
            "Программный код"});
            this.catChoose.Location = new System.Drawing.Point(12, 116);
            this.catChoose.Name = "catChoose";
            this.catChoose.Size = new System.Drawing.Size(296, 24);
            this.catChoose.TabIndex = 3;
            this.catChoose.Text = "Выбрать категорию...";
            this.catChoose.Visible = false;
            this.catChoose.SelectedIndexChanged += new System.EventHandler(this.CatChoose_SelectedIndexChanged);
            // 
            // chkStart
            // 
            this.chkStart.Location = new System.Drawing.Point(12, 178);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(296, 28);
            this.chkStart.TabIndex = 4;
            this.chkStart.Text = "Запустить проверку";
            this.chkStart.UseVisualStyleBackColor = true;
            this.chkStart.Visible = false;
            this.chkStart.Click += new System.EventHandler(this.ChkStart_Click);
            // 
            // labFlChoose
            // 
            this.labFlChoose.AutoSize = true;
            this.labFlChoose.Location = new System.Drawing.Point(148, 61);
            this.labFlChoose.Name = "labFlChoose";
            this.labFlChoose.Size = new System.Drawing.Size(121, 17);
            this.labFlChoose.TabIndex = 5;
            this.labFlChoose.Text = "Файл не выбран!";
            // 
            // flChoose2
            // 
            this.flChoose2.Location = new System.Drawing.Point(12, 56);
            this.flChoose2.Name = "flChoose2";
            this.flChoose2.Size = new System.Drawing.Size(130, 27);
            this.flChoose2.TabIndex = 6;
            this.flChoose2.Text = "Выбрать файл...";
            this.flChoose2.UseVisualStyleBackColor = true;
            this.flChoose2.Click += new System.EventHandler(this.FlChoose2_Click);
            // 
            // CatError
            // 
            this.CatError.ContainerControl = this;
            // 
            // FileError
            // 
            this.FileError.ContainerControl = this;
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(12, 311);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(48, 17);
            this.labRes.TabIndex = 7;
            this.labRes.Text = "Result";
            this.labRes.Visible = false;
            // 
            // chkProg
            // 
            this.chkProg.Location = new System.Drawing.Point(12, 254);
            this.chkProg.Name = "chkProg";
            this.chkProg.Size = new System.Drawing.Size(296, 23);
            this.chkProg.TabIndex = 8;
            this.chkProg.Visible = false;
            // 
            // matchBox
            // 
            this.matchBox.FormattingEnabled = true;
            this.matchBox.ItemHeight = 16;
            this.matchBox.Location = new System.Drawing.Point(341, 148);
            this.matchBox.Name = "matchBox";
            this.matchBox.Size = new System.Drawing.Size(447, 180);
            this.matchBox.TabIndex = 9;
            // 
            // matchLab
            // 
            this.matchLab.AutoSize = true;
            this.matchLab.Location = new System.Drawing.Point(338, 119);
            this.matchLab.Name = "matchLab";
            this.matchLab.Size = new System.Drawing.Size(180, 17);
            this.matchLab.TabIndex = 10;
            this.matchLab.Text = "Совпадений не найдено...";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.matchLab);
            this.Controls.Add(this.matchBox);
            this.Controls.Add(this.chkProg);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.flChoose2);
            this.Controls.Add(this.labFlChoose);
            this.Controls.Add(this.chkStart);
            this.Controls.Add(this.catChoose);
            this.Controls.Add(this.MPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MPanel;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "PlagiarismOFF";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MPanel.ResumeLayout(false);
            this.MPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MPanel;
        private System.Windows.Forms.ToolStripMenuItem fl;
        private System.Windows.Forms.ToolStripMenuItem flChoose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem flClose;
        private System.Windows.Forms.ToolStripMenuItem opt;
        private System.Windows.Forms.ToolStripMenuItem optOpJrn;
        private System.Windows.Forms.ToolStripMenuItem optSett;
        private System.Windows.Forms.ComboBox catChoose;
        private System.Windows.Forms.Button chkStart;
        private System.Windows.Forms.Label labFlChoose;
        private System.Windows.Forms.Button flChoose2;
        private System.Windows.Forms.ErrorProvider CatError;
        private System.Windows.Forms.ErrorProvider FileError;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.ProgressBar chkProg;
        private System.Windows.Forms.ListBox matchBox;
        private System.Windows.Forms.Label matchLab;
        private System.Windows.Forms.ToolStripMenuItem aboutProg;
    }
}

