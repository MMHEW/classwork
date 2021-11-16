using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_class_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string description = "Bungie's thrilling conclusion to the halo franchise that sees Master Chief teaming up with the Arbiter to take down the brutes new covenant and the flood.";
            string name = "Halo 3";
            string gun = "Spartan Laser";
            bool forerunners = false;
            bool brutes = true;
            Halo haloGame = new Halo(gun, name ,description, forerunners, brutes);

        }
    }
}
