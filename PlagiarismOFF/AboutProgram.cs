using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace PlagiarismOFF
{
    public partial class AboutProgram : Form
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        private void AboutProgram_Load(object sender, EventArgs e)
        {
            string inform = "";
            aboutProgLab.Text = "";
            StreamReader srap = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("PlagiarismOFF.About_Program.txt"));
            while (inform != null)
            {
                inform = srap.ReadLine();
                if (inform != null)
                    aboutProgLab.Text += inform + "\r\n";
            }
            srap.Close();
            aboutProgLab.Text += "\r\n\r\n";
            aboutProgLab.Text += @"Copyright (c)  2019  Alexander Sysoev";
        }
    }
}
