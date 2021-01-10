using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Strom a = new Strom("wind", false, "Zul'rajas");
            a.announce();

            Pupil b = new Pupil("Mezil-Kree");
            Strom abc = b.castwindstrom();
            abc.announce();

            Mage c = new Mage("Gul’dan");
            Strom de = c.castrainstrom();
            de.announce();

            Archmage d = new Archmage("Nielas Aran");
            Strom dk = d.castalightening();
            dk.announce();

            Strom dm = d.castwindstrom();
            dm.announce();

        }
    }
}
