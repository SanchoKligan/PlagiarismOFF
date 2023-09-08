namespace PlagiarismOFF
{
    partial class StatisticsJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsJournal));
            this.sjTable = new System.Windows.Forms.DataGridView();
            this.sjClr = new System.Windows.Forms.Button();
            this.sjCl = new System.Windows.Forms.Button();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Results = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sjTable)).BeginInit();
            this.SuspendLayout();
            // 
            // sjTable
            // 
            this.sjTable.AllowUserToOrderColumns = true;
            this.sjTable.BackgroundColor = System.Drawing.Color.White;
            this.sjTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sjTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sjTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dates,
            this.Times,
            this.Files,
            this.Categories,
            this.Results});
            this.sjTable.Location = new System.Drawing.Point(0, 0);
            this.sjTable.Name = "sjTable";
            this.sjTable.ReadOnly = true;
            this.sjTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sjTable.RowTemplate.Height = 24;
            this.sjTable.Size = new System.Drawing.Size(799, 385);
            this.sjTable.TabIndex = 0;
            // 
            // sjClr
            // 
            this.sjClr.Location = new System.Drawing.Point(107, 401);
            this.sjClr.Name = "sjClr";
            this.sjClr.Size = new System.Drawing.Size(125, 28);
            this.sjClr.TabIndex = 1;
            this.sjClr.Text = "Очистить";
            this.sjClr.UseVisualStyleBackColor = true;
            this.sjClr.Click += new System.EventHandler(this.StstJrnClr_Click);
            // 
            // sjCl
            // 
            this.sjCl.Location = new System.Drawing.Point(563, 401);
            this.sjCl.Name = "sjCl";
            this.sjCl.Size = new System.Drawing.Size(123, 28);
            this.sjCl.TabIndex = 2;
            this.sjCl.Text = "Закрыть";
            this.sjCl.UseVisualStyleBackColor = true;
            this.sjCl.Click += new System.EventHandler(this.StatJrnCl_Click);
            // 
            // Dates
            // 
            this.Dates.HeaderText = "Дата";
            this.Dates.Name = "Dates";
            this.Dates.ReadOnly = true;
            this.Dates.Width = 85;
            // 
            // Times
            // 
            this.Times.HeaderText = "Время";
            this.Times.Name = "Times";
            this.Times.ReadOnly = true;
            this.Times.Width = 70;
            // 
            // Files
            // 
            this.Files.HeaderText = "Файл";
            this.Files.Name = "Files";
            this.Files.ReadOnly = true;
            this.Files.Width = 300;
            // 
            // Categories
            // 
            this.Categories.HeaderText = "Категория";
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            this.Categories.Width = 195;
            // 
            // Results
            // 
            this.Results.HeaderText = "Результат проверки";
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Width = 85;
            // 
            // StatisticsJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sjCl);
            this.Controls.Add(this.sjClr);
            this.Controls.Add(this.sjTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatisticsJournal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Журнал статистики";
            this.Load += new System.EventHandler(this.StatisticsJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sjTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sjTable;
        private System.Windows.Forms.Button sjClr;
        private System.Windows.Forms.Button sjCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Times;
        private System.Windows.Forms.DataGridViewTextBoxColumn Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Results;
    }
}