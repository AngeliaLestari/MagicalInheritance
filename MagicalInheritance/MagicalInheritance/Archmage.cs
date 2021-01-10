using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace MagicalInheritance
{
    class Archmage : Mage
    {

       public Archmage (string title):  base(title)
        {

        }

        public override Strom castrainstrom ()
        {
            return new Strom("rain", false, title);
        }

        public Strom castalightening() 
        {
            return new Strom("light", true, title);
        }




    }
}
