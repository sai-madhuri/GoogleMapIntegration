using System;
using System.Collections.Generic;
using System.Text;

namespace BankTask
{
    public partial class PartialClass
    {
        public string Name;

        public void Display(string name)
        {
            Console.WriteLine("Name in partial class : " + name);
        }
    }
}
