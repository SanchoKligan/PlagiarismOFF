namespace PlagiarismOFF
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.labCat = new System.Windows.Forms.Label();
            this.labCatTORL = new System.Windows.Forms.Label();
            this.catTORLPath = new System.Windows.Forms.TextBox();
            this.labCatTOEL = new System.Windows.Forms.Label();
            this.catTOELPath = new System.Windows.Forms.TextBox();
            this.labCatPC = new System.Windows.Forms.Label();
            this.catPCPath = new System.Windows.Forms.TextBox();
            this.ok1 = new System.Windows.Forms.Button();
            this.cancel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCat
            // 
            this.labCat.AutoSize = true;
            this.labCat.Location = new System.Drawing.Point(38, 23);
            this.labCat.Name = "labCat";
            this.labCat.Size = new System.Drawing.Size(81, 17);
            this.labCat.TabIndex = 0;
            this.labCat.Text = "Категории:";
            // 
            // labCatTORL
            // 
            this.labCatTORL.AutoSize = true;
            this.labCatTORL.Location = new System.Drawing.Point(61, 61);
            this.labCatTORL.Name = "labCatTORL";
            this.labCatTORL.Size = new System.Drawing.Size(244, 17);
            this.labCatTORL.TabIndex = 1;
            this.labCatTORL.Text = "Путь к \"Текстам на русском языке\":";
            // 
            // catTORLPath
            // 
            this.catTORLPath.Location = new System.Drawing.Point(343, 58);
            this.catTORLPath.Name = "catTORLPath";
            this.catTORLPath.Size = new System.Drawing.Size(407, 22);
            this.catTORLPath.TabIndex = 2;
            // 
            // labCatTOEL
            // 
            this.labCatTOEL.AutoSize = true;
            this.labCatTOEL.Location = new System.Drawing.Point(61, 98);
            this.labCatTOEL.Name = "labCatTOEL";
            this.labCatTOEL.Size = new System.Drawing.Size(267, 17);
            this.labCatTOEL.TabIndex = 3;
            this.labCatTOEL.Text = "Путь к \"Текстам на английском языке\":";
            // 
            // catTOELPath
            // 
            this.catTOELPath.Location = new System.Drawing.Point(343, 95);
            this.catTOELPath.Name = "catTOELPath";
            this.catTOELPath.Size = new System.Drawing.Size(407, 22);
            this.catTOELPath.TabIndex = 4;
            // 
            // labCatPC
            // 
            this.labCatPC.AutoSize = true;
            this.labCatPC.Location = new System.Drawing.Point(61, 132);
            this.labCatPC.Name = "labCatPC";
            this.labCatPC.Size = new System.Drawing.Size(204, 17);
            this.labCatPC.TabIndex = 5;
            this.labCatPC.Text = "Путь к \"Программным кодам\":";
            // 
            // catPCPath
            // 
            this.catPCPath.Location = new System.Drawing.Point(343, 129);
            this.catPCPath.Name = "catPCPath";
            this.catPCPath.Size = new System.Drawing.Size(407, 22);
            this.catPCPath.TabIndex = 6;
            // 
            // ok1
            // 
            this.ok1.Location = new System.Drawing.Point(106, 197);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(133, 28);
            this.ok1.TabIndex = 9;
            this.ok1.Text = "OK";
            this.ok1.UseVisualStyleBackColor = true;
            this.ok1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // cancel1
            // 
            this.cancel1.Location = new System.Drawing.Point(530, 197);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(139, 28);
            this.cancel1.TabIndex = 10;
            this.cancel1.Text = "Отмена";
            this.cancel1.UseVisualStyleBackColor = true;
            this.cancel1.Click += new System.EventHandler(this.Cancel1_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.catPCPath);
            this.Controls.Add(this.labCatPC);
            this.Controls.Add(this.catTOELPath);
            this.Controls.Add(this.labCatTOEL);
            this.Controls.Add(this.catTORLPath);
            this.Controls.Add(this.labCatTORL);
            this.Controls.Add(this.labCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Config";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCat;
        private System.Windows.Forms.Label labCatTORL;
        private System.Windows.Forms.TextBox catTORLPath;
        private System.Windows.Forms.Label labCatTOEL;
        private System.Windows.Forms.TextBox catTOELPath;
        private System.Windows.Forms.Label labCatPC;
        private System.Windows.Forms.TextBox catPCPath;
        private System.Windows.Forms.Button ok1;
        private System.Windows.Forms.Button cancel1;
    }
}