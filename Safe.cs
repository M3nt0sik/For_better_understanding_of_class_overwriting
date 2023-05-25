using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_better_understanding_of_class_overwriting
{
    internal class Safe
    {
        private string content = "cenne klejnpty";
        private string saveCombination = "12345";

        public string Open(string combination)
        {
            if(combination == saveCombination)
            {
                return content;
            }
            return "";
        }

        public void PickLock(Locksmith lockpicker) 
        {
            lockpicker.Combination = saveCombination;
        }
    }
}
