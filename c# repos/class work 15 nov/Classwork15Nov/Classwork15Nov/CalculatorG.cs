using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork15Nov
{
    internal class CalculatorG <T,U> where T : struct, U
    {
        
        private T _first { get; set; }
        private U _second { get; set; }

        public CalculatorG (T first, U second)
        {
            _first =  first ;
            _second = second;
        }

        public T Add()
        {
            return (dynamic) _first + _second;
        }

    }
}
//abstract : VideoGames 
//First-Person : VideoGames
//Halo : First-Person