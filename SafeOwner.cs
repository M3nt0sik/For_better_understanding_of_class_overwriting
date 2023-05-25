using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_better_understanding_of_class_overwriting
{
    internal class SafeOwner
    {
        private string valuables = "";

        public void ReciveContents(string safeContents)
        {
            valuables = safeContents; ;
            Console.Write($"Moje {valuables} Dziekuje za zwrot!");
        }
    }
}