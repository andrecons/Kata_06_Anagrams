using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_06_Anagrams.Objects
{
    public class Word
    {
        private string name;

        public Word(string name )
        {
            this.name = name;
        }

        public string getName() 
        {
            return name;
        }

        public string ToString()
        { return name; }
    }
}
