using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw
{
    internal class Resultat
    {
        private string Title; 
        private  int Count; 
        public string title { get { return Title; } set { title = value; } }
        public int count { get { return Count; } set { count = value; } }

        public Resultat(string title, int count)
        {
            Title = title;
            Count = count;

        }
    }
}
