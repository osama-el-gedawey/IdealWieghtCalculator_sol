using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealWieghtCalculator
{
    public class IdealWieght
    {
        public double Height { get; set; }
        public char Gender { get; set; }
        public double calculate()
        {
            switch(Gender)
            {
                case 'm':
                    return Height-100-((Height-150)/4);
                case 'f':
                    return Height - 100 - ((Height - 150) / 2);
                default:
                    return 0;
            }
        }
    }
}
