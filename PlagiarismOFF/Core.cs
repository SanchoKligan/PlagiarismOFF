using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Reflection;

namespace PlagiarismOFF
{
    internal abstract class Core
    {
        private bool commcheck = false;
        protected int wordcount = -1;

        private string Id(string shingle)
        {
            int index = 0;
            List<string> id = new List<string>();
            Regex regex = new Regex(@"(\w|[а-яё])+");
            MatchCollection match = regex.Matches(shingle);
            for (int i = 0; i < match.Count; i++)
                id.Add(match[i].Value);
            regex = new Regex(@"operators|vartypes|keywords|cycles|numbers");
            while (index < id.Count)
            {
                if (regex.IsMatch(id[index]))
                {
                    id.RemoveAt(index);
                    index = 0;
                }
                else
                    index++;
             }
            foreach (string s in id)
               shingle = Regex.Replace(shingle, @"\s+" + s + @"\s+", " identificators ");
            return shingle;
        }

        private string Clean(string shingle, string change, string respath, bool check = true)
        {
            string k = "";
            StreamReader srres = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(respath));
            while (k != null)
            {
                k = srres.ReadLine();
                if (k != null)
                {
                    if (check)
                    {
                        shingle = Regex.Replace(shingle, @"\s+" + k + @"\s+", change);
                    }
                    else
                        shingle = Regex.Replace(shingle, k, change);
                }
            }
            srres.Close();
            return shingle;
        }

        protected string CanonizeCode(string shingle)
        {
            shingle = " " + shingle + " ";
            shingle = shingle.ToLower();
            shingle = Regex.Replace(shingle, @"//.*", "");
            if (Regex.IsMatch(shingle, @"/\*.*", RegexOptions.IgnoreCase) || commcheck == true)
            {
                commcheck = true;
                if (Regex.IsMatch(shingle, @".*\*/", RegexOptions.IgnoreCase))
                    commcheck = false;
                shingle = "/*" + shingle + "*/";
            }
            shingle = Regex.Replace(shingle, @"/\*.*\*/", "");
            shingle = Regex.Replace(shingle, @"("".*"")|('.*')", " ");
            shingle = Regex.Replace(shingle, @"\\|#|;|\{|\}|@", " ");
            shingle = Regex.Replace(shingle, @"-?[0-9]+\.?[0-9]*", " numbers ");
            shingle = Clean(shingle, " operators ", "PlagiarismOFF.Dicts.OperatorsS.txt", false);
            shingle = Clean(shingle, " keywords ", "PlagiarismOFF.Dicts.KeyWords.txt");
            shingle = Regex.Replace(shingle, " for | do | while ", " cycles ");
            shingle = Clean(shingle, " vartypes ", "PlagiarismOFF.Dicts.VarTypes.txt");
            shingle = Clean(shingle, " operators ", "PlagiarismOFF.Dicts.OperatorsW.txt");
            shingle = Id(shingle);
            shingle = Regex.Replace(shingle, @"\s+", " ");
            return shingle;
        }

        protected string Canonize(string shingle, string lang)
        {
            shingle = " " + shingle + " ";
            shingle = shingle.ToLower();
            shingle = Regex.Replace(shingle, @"\W|[0-9]", " ");
            shingle = Clean(shingle, " ", lang);
            shingle = Regex.Replace(shingle, @"\s+", " ");
            return shingle;
        }

        protected List<string> GetShingle(string shingle, List<string> words)
        {
            Regex regex = new Regex("[a-z|а-я|ё]+");
            MatchCollection match = regex.Matches(shingle);
            for (int i = 0; i < match.Count; i++)
                words.Add(match[i].Value);
            return words;
        }

        protected List<string> Hashing(List<string> words, List<string> hash)
        {
            MD5 md5 = MD5.Create();
            string tmp = "";
            if (wordcount > 10)
                wordcount = 10;
            if (words.Count <= wordcount)
            {
                for (int i = 0; i < words.Count; i++)
                    tmp += words[i];
                hash.Add(BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(tmp))).Replace("-", string.Empty));
            }
            else
            {
                for (int i = 0; i < words.Count - (wordcount - 1); i++)
                {
                    tmp = "";
                    for (int j = i; j < i + wordcount; j++)
                    {
                        tmp += words[j];
                    }
                    hash.Add(BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(tmp))).Replace("-", string.Empty));
                }
            }
            return hash;
        }
    }
}