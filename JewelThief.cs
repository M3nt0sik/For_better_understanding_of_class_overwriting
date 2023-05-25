using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_better_understanding_of_class_overwriting
{
    internal class JewelThief: Locksmith
    {
        private string stolenJewels;

        protected void ReturnContents(string safeContents, SafeOwner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"Kradne oszczednosci! Ukradlem {stolenJewels}");

        }

    }
}
