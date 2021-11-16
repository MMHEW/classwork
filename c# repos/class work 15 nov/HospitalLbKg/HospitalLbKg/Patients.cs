using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLbKg
{
    
    internal class Patients
    {
        
        public double weight;
        public string name;
        public bool inLB;
        public Patients(double weight, string name, bool inLB)
        {
            this.weight = weight;
            this.name = name;
            this.inLB = inLB;   
        }
        
        
        
        public void Converter()
        {
            if (this.inLB)
            {
                this.inLB = false;
                this.weight *= .04;

            }
            this.inLB = true;
            this.weight *= 2.20462;
        }

    }
}
