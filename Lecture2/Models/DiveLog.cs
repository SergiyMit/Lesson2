using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2.Models
{
    public class DiveLog : DiveMeasurement
    {
        private int IdDive;
        public int WeightsAmount { get; set; }
        public string WetsuitType { get; set; }
        public decimal OxygenAtStart { get; set; }
        public decimal OxygenAtEnd { get; set; }
        public string DiveSite { get; set; }

        public DiveLog(int weightsamout, string wetsuittype, decimal oxygenatstart, decimal oxygenatend, string divesite, int maxdivedeep, int divetime, int watertemperature, Diver diver)
        : base(maxdivedeep, divetime, watertemperature, diver)
        {
            WeightsAmount = weightsamout;
            WetsuitType = wetsuittype;
            OxygenAtStart = oxygenatstart;
            OxygenAtEnd = oxygenatend;
        }
       public decimal CalculateOxygenUsage()
        {
            decimal OxygenUsage = this.OxygenAtStart - this.OxygenAtEnd;
            return OxygenUsage;
        }
    }
}
