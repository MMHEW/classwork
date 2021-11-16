using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLbKg
{
    internal class Hospital
    {
        public delegate string ConverterDelegate();
        private bool _inLB;
        private double _weight;
        public Patients _pt;
        public Hospital(Patients pt)
        {
            _pt = pt;
        }



        public string TransformWeight()
        {
            if (_pt.inLB)
            {
                _pt.inLB = false;
                return ($"{_pt.weight *= 0.04} KG");
            }
            return ($"{_pt.weight *= 2.2} LBS");
        }
           

    }
}
