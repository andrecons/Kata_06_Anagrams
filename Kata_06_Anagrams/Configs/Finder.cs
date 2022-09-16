using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata_06_Anagrams.Objects;

namespace Kata_06_Anagrams.Configs
{
    public static class Finder
    {
        public static void Find(List<Word> wordList) 
        {
            foreach (Word word in wordList)
            {
                Console.WriteLine("Looking for " + word.ToString() + " anagrams:");
                char[] firstWordArray = word.ToString().ToCharArray();

                foreach (Word otherWord in wordList)
                {
                    
                    char[] secondWordArray = otherWord.ToString().ToCharArray();

                    if (firstWordArray.Length == secondWordArray.Length)
                    {
                        List<char> firstWordToList = firstWordArray.ToList();
                        List<char> secondWordToList = secondWordArray.ToList();

                        firstWordToList.Sort();
                        secondWordToList.Sort();

                        string firstSortedString = "";
                        string secondSortedString = "";

                        for (int i = 0; i < firstWordArray.Length; i++)
                        {
                            firstSortedString = firstSortedString + firstWordToList[i];
                            secondSortedString = secondSortedString + secondWordToList[i];
                        }

                        if (firstSortedString.Equals(secondSortedString)) {
                            if (!otherWord.ToString().Equals(word.ToString()))
                            {
                                Console.WriteLine(otherWord.ToString());
                                Console.WriteLine("\n");

                            }
                        }
 
                    }

                    
                }

                //Console.WriteLine("\n-----EndOfWord------");
            }
        
        }
    }
}
