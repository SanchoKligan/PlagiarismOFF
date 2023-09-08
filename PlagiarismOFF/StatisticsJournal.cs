using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PlagiarismOFF
{
    public partial class StatisticsJournal : Form
    {
        public StatisticsJournal()
        {
            InitializeComponent();
        }

        private void StatJrnCl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StatisticsJournal_Load(object sender, EventArgs e)
        {
            StreamReader srsj = new StreamReader(MainMenu.sjpath, Encoding.GetEncoding(1251));
            Regex regex = new Regex(@"[^;]+");
            MatchCollection match;
            string statistics = "";
            int strcount = 0;
            while (statistics != null)
            {
                statistics = srsj.ReadLine();
                if (statistics != null)
                {
                    match = regex.Matches(statistics);
                    sjTable.Rows.Add();
                    sjTable.Rows[strcount].SetValues(match[0].Value, match[1].Value, match[2].Value, match[3].Value, match[4].Value);
                    strcount++;
                }
            }
            srsj.Close();
        }

        private void StstJrnClr_Click(object sender, EventArgs e)
        {
            sjTable.Rows.Clear();
            File.WriteAllText(MainMenu.sjpath, string.Empty);
        }
    }
}