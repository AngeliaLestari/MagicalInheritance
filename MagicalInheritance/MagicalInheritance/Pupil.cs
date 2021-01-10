using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalInheritance
{
    class Pupil
    {

        public string title
        { get; private set; }

        public Pupil(string title1) 
        {
           title = title1 ;
        }

        public Strom castwindstrom() 
        {
            return new Strom("wind", false, title);
        }
        


       

    }
}
