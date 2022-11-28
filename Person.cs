using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDataBinding
{
    class Person
    {
        private string nameValue;
        private double ageValue;
        public String Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }
        public double Age
        {
            get { return ageValue; }
            set
            {
                if (value != ageValue)
                {
                    ageValue = value;
                }
            }

        }
    }
}
