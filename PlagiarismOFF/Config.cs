using System;
using System.IO;
using System.Windows.Forms;

namespace PlagiarismOFF
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(MainMenu.conpath, string.Empty);
            StreamWriter swcon = new StreamWriter(MainMenu.conpath);
            swcon.WriteLine(catTORLPath.Text);
            swcon.WriteLine(catTOELPath.Text);
            swcon.WriteLine(catPCPath.Text);
            swcon.Close();
            Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            StreamReader srcon = new StreamReader(MainMenu.conpath);
            catTORLPath.Text = srcon.ReadLine();
            catTOELPath.Text = srcon.ReadLine();
            catPCPath.Text = srcon.ReadLine();
            srcon.Close();
        }

        private void Cancel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}