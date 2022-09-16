using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata_06_Anagrams.Objects;

namespace Kata_06_Anagrams.Configs
{
    static class Startup
    {
        const string TXTFILEPATH = @"..\..\..\InputFile\wordlist.txt";
        private static List<Word> wordList = new List<Word>();

        public static void Import()
        {
            try
            {
                using (var textFile = System.IO.File.OpenText(TXTFILEPATH))
                {

                    Console.WriteLine("File found.");
                    Console.WriteLine("Please wait while importing the words and removing duplicates...");

                    string line = "";

                    while ((line = textFile.ReadLine()) != null)
                    {
                        bool validInsert = true;

                        string tempStringName = line;
                        tempStringName = Clean(tempStringName);
                        //Console.WriteLine("working on " + tempStringName);
                        Word newWord = new Word(tempStringName);

                        /*foreach (Word word in wordList)
                        {
                            if (word.getName().Equals(tempStringName))
                            {
                                Console.WriteLine("\n\n**duplicate found**\n\n");
                                validInsert = false;
                            }
                        }*/

                        //if (validInsert == true)
                        wordList.Add(newWord);

                    }
                    Console.WriteLine("Import ended with success.");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        private static string Clean(string inputName)
        {

            //TODO: remove accents!

            string tempName = inputName.Replace("'", "");
            tempName = tempName.ToLower();

            return tempName;


        }

        public static void WordPrinter()
        {
            foreach (Word word in wordList)
            {
                //Console.WriteLine(word.ToString());
            }
        }

        public static void FinderLauncher()
        {
            Finder.Find(wordList.Distinct().ToList());
        }
    }
}
