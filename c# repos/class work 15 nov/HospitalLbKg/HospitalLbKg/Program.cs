using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLbKg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patients pt1 = new Patients(256.5d,"Edward", true );
            
            Hospital hosp = new Hospital(pt1);

            Console.WriteLine(hosp.TransformWeight());

        }
    }
}
