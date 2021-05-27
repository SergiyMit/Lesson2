using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2.Models
{
    class OxygenCalc
    {
         int TimeOxygen;
         int DeepOxygen;
         int TankOxygen;
         int TankPreassure;

        public decimal CalculateDiveTime (int TankOxygen, int TankPreassure, int DeepOxygen)
        {
            decimal result = (TankOxygen * TankPreassure) / (25 * (1 + (DeepOxygen/10)));
            return result;
        }
        public decimal CalculateDiveOxygen(int TankOxygen, int TimeOxygen, int DeepOxygen)
        {
            decimal result = 50 + ((25 * TimeOxygen * (1 + (DeepOxygen / 10))) / TankOxygen);
            return result;
        }
    }
}
