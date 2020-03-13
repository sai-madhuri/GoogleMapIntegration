using System;
using System.Collections.Generic;
using System.Text;

namespace BankTask
{
    public partial class PartialClass
    {
        public void Read()
        {
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Display(name);
        }
    }
}
