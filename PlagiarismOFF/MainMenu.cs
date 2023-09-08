using System;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PlagiarismOFF
{
    public partial class MainMenu : Form
    {
        internal readonly static string conpath = Directory.GetCurrentDirectory() + @"\Config.txt", sjpath = Directory.GetCurrentDirectory() + @"\Statistics_Journal.csv";
        private OpenFileDialog ofl = new OpenFileDialog();
        private int filecount = 0;

        internal ProgressBar ProgUpdate(ProgressBar checkprog)
        {
            chkProg = checkprog;
            if (chkProg.Value == 0)
            {
                chkProg.Visible = true;
                Application.DoEvents();
            }
            chkProg.Value += 1;
            return chkProg;
        }

        private void GetVisible(int position, bool error = true)
        {
            if (position == 0)
            {
                if (error)
                {
                    catChoose.Text = "Выбрать категорию...";
                    catChoose.Visible = false;
                    GetVisible(1, true);
                }
                else
                {
                    catChoose.Text = "Выбрать категорию...";
                    catChoose.Visible = true;
                    GetVisible(1, true);
                }
            }
            if (position == 1)
            {
                if (error)
                {
                    chkStart.Visible = false;
                    GetVisible(2);
                }
                else
                {
                    chkStart.Visible = true;
                    GetVisible(2);
                }
            }
            if (position == 2)
            {
                chkProg.Visible = false;
                labRes.Visible = false;
                matchLab.Text = "Совпадений не найдено...";
                matchBox.Items.Clear();
            }
        }

        private void ChooseFile()
        {
            string checkext = @"[^\\/:\*\?<>\|]+\.(txt|c|cpp|cs|jav|java|cc|cxx|inl|j|tcc)$";
            if (ofl.ShowDialog() == DialogResult.OK)
            {
                if (Regex.IsMatch(ofl.FileName, checkext))
                {
                    FileError.Clear();
                    CatError.Clear();
                    labFlChoose.Text = ofl.FileName;
                    GetVisible(0, false);
                }
                else
                {
                    FileError.SetError(labFlChoose, "Неверный тип файла!");
                    CatError.Clear();
                    labFlChoose.Text = "Файл не выбран!";
                    GetVisible(0);
                }
            }
        }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void FlClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FlChoose_Click(object sender, EventArgs e)
        {
            ChooseFile();
        }

        private void CatChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader srcon = new StreamReader(conpath);
            string path = null;
            filecount = 0;
            for (int i = 0; i <= catChoose.SelectedIndex; i++)
            {
                path = srcon.ReadLine();
            }
            srcon.Close();
            if (path == null || path == "")
            {
                GetVisible(1);
                CatError.SetError(catChoose, "Не указан путь к каталогу!");
            }
            else
            {
                if (Directory.Exists(path) == false)
                {
                    GetVisible(1);
                    CatError.SetError(catChoose, "Неверно указан путь к каталогу!");
                }
                else
                {
                    foreach (string file in Directory.GetFiles(path, "*" + Path.GetExtension(ofl.FileName)))
                    {
                        filecount++;
                    }
                    if (filecount == 0)
                    {
                        GetVisible(1);
                        CatError.SetError(catChoose, "В каталоге нет файлов для проверки!");
                    }
                    else
                    {
                        CatError.Clear();
                        GetVisible(1, false);
                    }
                }
            }
        }

        private void OptSett_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.ShowDialog();
        }

        private void ChkStart_Click(object sender, EventArgs e)
        {
            GetVisible(2);
            StreamReader srconfig = new StreamReader(conpath);
            Checker checker;
            string dirname = srconfig.ReadLine(), catname = "";
            if (catChoose.SelectedIndex == 0)
            {
                checker = new Checker(ofl.FileName, dirname, chkProg, filecount, "PlagiarismOFF.Dicts.Rus.txt");
                catname = "Текст на русском языке";
            }
            else
            {
                dirname = srconfig.ReadLine();
                if (catChoose.SelectedIndex == 1)
                {
                    checker = new Checker(ofl.FileName, dirname, chkProg, filecount, "PlagiarismOFF.Dicts.Eng.txt");
                    catname = "Текст на английском языке";
                }
                else
                {
                    dirname = srconfig.ReadLine();
                    checker = new Checker(ofl.FileName, dirname, chkProg, filecount);
                    catname = "Программный код";
                }
            }
            srconfig.Close();
            string result = checker.Check() + "%";
            Thread.Sleep(475);
            labRes.Text = "Уникальность файла составляет " + result;
            if (checker.matchlist.Count > 0)
            {
                matchLab.Text = "Найдены совпадения с файлами:";
                for (int i = 0; i < checker.matchlist.Count; i++)
                    matchBox.Items.Add(checker.matchlist[i]);
            }
            File.AppendAllText(sjpath, DateTime.Now.ToShortDateString() + ";" + DateTime.Now.ToLongTimeString() + ";" + ofl.FileName + ";" + catname + ";" + result + "\r\n", Encoding.GetEncoding(1251));
            labRes.Visible = true;
        }

        private void FlChoose2_Click(object sender, EventArgs e)
        {
            ChooseFile();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (!File.Exists(conpath))
                File.Create(conpath).Close();
            if (!File.Exists(sjpath))
                File.Create(sjpath).Close();
        }

        private void AboutProg_Click(object sender, EventArgs e)
        {
            AboutProgram aboutprog = new AboutProgram();
            aboutprog.ShowDialog();
        }

        private void OptOpJrn_Click(object sender, EventArgs e)
        {
            StatisticsJournal sj = new StatisticsJournal();
            sj.ShowDialog();
        }
    }
}