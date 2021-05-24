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
        public int OxygenAtStart { get; set; }
        public int OxygenAtEnd { get; set; }
        public string DiveSite { get; set; }

        public DiveLog(int weightsamout, string wetsuittype, int oxygenatstart, int oxygenatend, string divesite, int maxdivedeep, int divetime, int watertemperature, Diver diver)
        : base(maxdivedeep, divetime, watertemperature, diver)
        {
            WeightsAmount = weightsamout;
            WetsuitType = wetsuittype;
            OxygenAtStart = oxygenatstart;
            OxygenAtEnd = oxygenatend;
        }

    }
}
