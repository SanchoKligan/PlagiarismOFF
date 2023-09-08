using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PlagiarismOFF
{
    internal class Checker : Core
    {
        internal List<string> matchlist = new List<string>();
        private string filename = "", lang = "", dirname = "", shingle = "";
        private List<string> words = new List<string>(), hash1 = new List<string>(), hash2 = new List<string>();
        private int count = 0, filecount = 0;
        private double result = 0.0;
        private bool check = true;
        private ProgressBar chkprog;
        private MainMenu mainmenu = new MainMenu();

        internal Checker(string filename, string dirname, ProgressBar chkprog, int filecount, string lang)
        {
            this.filename = filename;
            this.dirname = dirname;
            this.lang = lang;
            this.chkprog = chkprog;
            this.filecount = filecount;
        }

        internal Checker(string filename, string dirname, ProgressBar chkprog, int filecount)
        {
            this.filename = filename;
            this.dirname = dirname;
            this.chkprog = chkprog;
            this.filecount = filecount;
            check = false;
        }

        private void GetLength(string file)
        {
            shingle = "";
            words.Clear();
            StreamReader srfile = new StreamReader(file, Encoding.GetEncoding(1251));
            while (shingle != null)
            {
                shingle = srfile.ReadLine();
                if (shingle != null)
                {
                    if (check)
                        shingle = Canonize(shingle, lang);
                    else
                        shingle = CanonizeCode(shingle);
                    words = GetShingle(shingle, words);
                }
            }
            srfile.Close();
            if (wordcount == -1)
                wordcount = words.Count;
            if (words.Count < wordcount)
                wordcount = words.Count;
        }

        private void Compare(string file)
        {
            int matches = 0;
            hash2.Clear();
            hash2 = GetHash(hash2, file);
            foreach (string each in hash1)
                if (hash2.Contains(each))
                    matches++;
            if (matches > 0)
                matchlist.Add(file);
            result += matches * 2 / Convert.ToDouble(hash1.Count + hash2.Count) * 100;
            count++;
            chkprog = mainmenu.ProgUpdate(chkprog);
        }

        private List<string> GetHash(List<string> hash, string file)
        {
            GetLength(file);
            hash = Hashing(words, hash);
            return hash;
        }

        internal string Check()
        {
            chkprog.Value = 0;
            chkprog.Maximum = (filecount + 1) * 2;
            GetLength(filename);
            chkprog = mainmenu.ProgUpdate(chkprog);
            if (check)
                foreach (string file in Directory.GetFiles(dirname, "*.txt"))
                {
                    GetLength(file);
                    chkprog = mainmenu.ProgUpdate(chkprog);
                }
            else
                foreach (string file in Directory.GetFiles(dirname, "*" + Path.GetExtension(filename)))
                {
                    GetLength(file);
                    chkprog = mainmenu.ProgUpdate(chkprog);
                }
            hash1 = GetHash(hash1, filename);
            chkprog = mainmenu.ProgUpdate(chkprog);
            if (check)
                foreach (string file in Directory.GetFiles(dirname, "*.txt"))
                    Compare(file);
            else
                foreach (string file in Directory.GetFiles(dirname, "*" + Path.GetExtension(filename)))
                    Compare(file);
            wordcount = -1;
            return Convert.ToString(Math.Round(100 - (result / count), 2));
        }
    }
}