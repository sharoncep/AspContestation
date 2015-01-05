using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TableFlatRate
    {
        public string ID { get; set; }
        public string ServiceCode { get; set; }
        public string Rate { get; set; }
    }

    public class TableFRHProfRate
    {
        public string ID { get; set; }
        public string SERVICE_PROVIDER_NAME { get; set; }
        public string SERVICE_PROVIDER_ID { get; set; }
        public string FLAT_RATE { get; set; }
        public string Speciality { get; set; }
        public string RATE { get; set; }
    }

    public class TableInjuryCodes
    {
        public string ID { get; set; }
        public string InjuryCode { get; set; }
        public string InjuryCodeDesc { get; set; }
        public string InjuryCodeShortDesc { get; set; }

    }

    public class TableMVA_FRH
    {
        public string ID { get; set; }
        public string PCP_NAME { get; set; }
        public string PCP_ID { get; set; }
        public string SUBSCRIBER_ID { get; set; }
        public string MEMBER_NAME { get; set; }
        public string DOS { get; set; }
        public string STATUS { get; set; }
    }

    public class TableMVAAccidentCodes
    {
        public string ID { get; set; }
        public string ICDCodes { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
    }

    public class TableUniPcpDetails
    {
        public string ID { get; set; }
        public string PCPID { get; set; }
        public string PCPName { get; set; }
        public string County { get; set; }
        public string EffectiveDate { get; set; }
        public string TerminatedDate { get; set; }
        public string Status { get; set; }
        public string FeeScheduleLOC { get; set; }
        public string IPAName { get; set; }
        public string PlanName { get; set; }
    }

    public class TableUniProfClaimFeeSchedule
    {
        public string ID { get; set; }
        public string PeriodFrom { get; set; }
        public string PeriodTo { get; set; }
        public string procedure { get; set; }
        public string modifier { get; set; }
        public string ParAllow { get; set; }
        public string Locality { get; set; }
    }

    public class TableFreedomCensus
    {
        public string ID { get; set; }
        public string PCP_Name { get; set; }
        public string Member_Name { get; set; }
        public string Member_ID { get; set; }
        public string Admit_Date { get; set; }
        public string Discharge_Date { get; set; }
        public string Admit_Diagnosis { get; set; }
        public string Facility_Name { get; set; }
    }

    public class TableFRQuestCarveOut
    {
        public string ID { get; set; }
        public string CPT_CODE { get; set; }
        public string REIM_AMOUNT { get; set; }
        public string EFF_YEAR { get; set; }
    }

    public class TableModifierListPayment
    {
        public string ID { get; set; }
        public string Modifier { get; set; }
        public string Allowance { get; set; }
    }

    public class TableContFrdmCapitatedProviders
    {
        public string ID { get; set; }
        public string CapitatedProviders { get; set; }
        public string ProviderID { get; set; }
        public string PlanNumber { get; set; }
        public string IPAName { get; set; }
        public string PlanName { get; set; }
        public string From_Date { get; set; }
        public string To_Date { get; set; }
        public string Speciality_name { get; set; }
        public string Speciality_fund { get; set; }
    }

    public class TableConUNIAnesthesiaFeeSchedule
    {
        public string ID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string ProcedureCode { get; set; }
        public string Unit { get; set; }
        public string ParAllow { get; set; }
        public string Locality { get; set; }
        public string IPA_NAME { get; set; }
        public string PlanName { get; set; }
    }

}
