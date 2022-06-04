using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Procesare_caractere_fisier
{
    class Procesare
    {
        private int total;
        private int linii;
        private int vocale;
        private int consoane;
        public int Total { get { return total; } }
        public int Linii { get { return linii; } }
        public int Vocale { get { return vocale; } }
        public int Consoane { get { return consoane; } }

        public Procesare()
        {
            total = 0;
            linii = 0;
            vocale = 0;
            consoane = 0;
            string vowels = "AEIOUaeiou";
            string consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            string path = Console.ReadLine();
            string file =@"../../"+path+".txt";
            if(!File.Exists(file))
            {
                using(StreamWriter sw =File.CreateText(file))
                {

                    string[] words = { "Ana are mere", "Ioana are Pere", "Maria are alune" };
                    for(int i=0;i<words.Length;i++)
                    {
                        sw.WriteLine(words[i]);
                        linii++;
                        string word = words[i];
                        for(int j=0;j<word.Length;j++)
                        {
                            if(word[j]!=' ')
                            {
                                int index = vowels.IndexOf(word[j]);
                                if(index>-1)
                                {
                                    vocale++;
                                }
                                else
                                {
                                    index = consonants.IndexOf(word[j]);
                                    if(index>-1)
                                    {
                                        consoane++;
                                    }
                                    else
                                    {
                                        total++;
                                    }
                                }

                            }
                        }
                    }
                    total += consoane + vocale;
                }
            }
            else
            {
                using(StreamReader sr=File.OpenText(file))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        string word = s;
                        linii++;
                        for (int j = 0; j < word.Length; j++)
                        {
                            if (word[j] != ' ')
                            {
                                int index = vowels.IndexOf(word[j]);
                                if (index > -1)
                                {
                                    vocale++;
                                }
                                else
                                {
                                    index = consonants.IndexOf(word[j]);
                                    if (index > -1)
                                    {
                                        consoane++;
                                    }
                                    else
                                    {
                                        total++;
                                    }
                                }

                            }
                        }
                        
                    }
                    total += consoane + vocale;
                }
            }
        }
    }
}
