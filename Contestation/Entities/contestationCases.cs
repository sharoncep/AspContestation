using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class contestationCases
    {
        public string ID { get; set; }
        public string pcpID { get; set; }
        public string pcpName { get; set; }
        public string subscriberID { get; set; }
        public string memberName { get; set; }
        public string claimType { get; set; }
        public string claimID { get; set; }
        public string billTypePos { get; set; }
        public string serviceCode { get; set; }
        public string serviceBegin { get; set; }
        public string serviceEnd { get; set; }
        public string checkDate { get; set; }

        public string serviceCodeModi { get; set; }
        public string lineNo { get; set; }

        public string units { get; set; }
        public string drgCode { get; set; }
        public string providerID { get; set; }
        public string providerName { get; set; }
        public string billedAmount { get; set; }
        public string paidAmount { get; set; }
        public string reason { get; set; }
    }

}
