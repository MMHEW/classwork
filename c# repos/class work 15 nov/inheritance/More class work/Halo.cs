using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_class_work
{
    internal class Halo : FirstPerson
    {
        
        protected bool areThereForerunner;
        protected bool areThereBrutes;

        public Halo(string obj= "Assault Rifle", string gameName = "halo", string gameDesc="Committing mass genocide against an alien race", bool forerunner = false, bool brutes = false)
        {
            this.objectHolding = obj;
            this.nameOfGame = gameName;
            this.description = gameDesc;
            this.areThereForerunner = forerunner;
            this.areThereBrutes = brutes;
            this.dectriptionOfCharacter = "a towering supersoldier known as a 'Spartan'";
            this.nameOfCharacter = "Master Chief";
        }
    }
}
