using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MagicalInheritance
{
    class Strom
    {
        public string essence
        { get; private set; }

        public bool isstrong
        { get; private set; }

        public string caster
        { get; private set; }

        public Strom(string essence1, bool isstrong1, string caster1)
        {
            essence = essence1;
            isstrong = isstrong1;
            caster = caster1;
        }

      
        public void announce()
        {
        
            if(isstrong == true) 
            
            {
                Console.WriteLine($"{caster} cast a Strong {essence}");
            }
            else 
            {
                Console.WriteLine($"{caster} cast a Weak {essence}");
            }
        }






    }
}
