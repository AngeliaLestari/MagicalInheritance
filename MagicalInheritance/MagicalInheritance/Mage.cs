using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalInheritance
{
    class Mage : Pupil
    {

        public Mage(string title) : base(title)
        {

        }

        public virtual Strom castrainstrom ()
        {
            return new Strom("Rain", false, title);
        }

    }
}
