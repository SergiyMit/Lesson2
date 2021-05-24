using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2.Models
{
    public class DiveMeasurement
    {
        private int IdMeasurement;
        public Diver Diver { get; set; }
        public int MaxDiveDeep { get; set; }
        public int DiveTime { get; set; }
        public decimal WaterTemperature { get; set; }
        public DateTime DateOfDive { get; set; }
        public DiveMeasurement(int maxdivedeep, int divetime, decimal watertemperature, Diver diver)
        {
            Diver = diver;
            MaxDiveDeep = maxdivedeep;
            DiveTime = divetime;
            WaterTemperature = watertemperature;
        }
        public Boolean IsDeepExceed()
        {
            return false;
        }

    }
}
