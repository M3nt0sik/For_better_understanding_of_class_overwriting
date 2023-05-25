using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_better_understanding_of_class_overwriting
{
    internal class Locksmith
    {
        public void OpenSave(Safe safe)
        {
            safe.PickLock(this);
            string safeContents = safe.Open(Combination);
            ReturnContents(safeContents, owner);
        }

        public string? Combination { private get; set; }

        protected void ReturnContents(string safecontent, SafeOwner owner)
        {
            owner.ReciveContents(safecontent);
        }
    }
}
