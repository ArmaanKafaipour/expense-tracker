using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{

    public class TaxModel
    {
        public TaxRateInfo[] taxRateInfo { get; set; }
        public GeocodeInfo geocodeInfo { get; set; }
        public string termsOfUse { get; set; }
        public string disclaimer { get; set; }
    }

    public class GeocodeInfo
    {
        public string[] matchCodes { get; set; }
        public string formattedAddress { get; set; }
        public string confidence { get; set; }
        public string calcMethod { get; set; }
        public int bufferDistance { get; set; }
    }

    public class TaxRateInfo
    {
        public float rate { get; set; }
        public string jurisdiction { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string tac { get; set; }
    }

}
