using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2.Models
{
    public class CertificateLevel
    {
        public int IdLevel { get; private set; }
        public string LevelName { get; set; }
        public int MaxAllowedDeep { get; set; }
        public int RequiredDives { get; set; }
        public string AdditionalInfo { get; set; }

        public CertificateLevel(string levelname, int maxalloweddeep, int requireddives, string additionalinfo)
        {
            LevelName = levelname;
            MaxAllowedDeep = maxalloweddeep;
            RequiredDives = requireddives;
            AdditionalInfo = additionalinfo;
        }

    }
}
