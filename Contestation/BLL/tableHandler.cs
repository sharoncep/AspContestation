using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class tableHandler
    {
        dbOperations tableDetails = null;

        public tableHandler()
        {
            tableDetails = new dbOperations();
        }

        #region FlatRate

        public List<TableFlatRate> getFlatRate(string SearchName, int DbID)
        {
            return tableDetails.getFlatRate(SearchName, DbID);
        }

        public bool DeleteFlatRate(long ID, string username, int DbID)
        {
            return tableDetails.deleteFlatRate(ID, username, DbID);
        }

        public bool UpdateFlatRate(TableFlatRate flatRate, string username, int DbID)
        {
            return tableDetails.updateFlatRate(flatRate, username, DbID);
        }

        public bool InsertFlatRate(TableFlatRate flatRate, int DbID)
        {
            return tableDetails.insertFlatRate(flatRate, DbID);
        }

        #endregion

        #region FRHProfRate

        public List<TableFRHProfRate> getFRHProfRate(string SearchName, int DbID)
        {
            return tableDetails.getFRHProfRate(SearchName, DbID);
        }

        public bool DeleteFRHProfRate(long ID, string username, int DbID)
        {
            return tableDetails.deleteFRHProfRate(ID, username, DbID);
        }

        public bool UpdateFRHProfRate(TableFRHProfRate FRHProfRate, string username, int DbID)
        {
            return tableDetails.updateFRHProfRate(FRHProfRate, username, DbID);
        }

        public bool InsertFRHProfRate(TableFRHProfRate FRHProfRate, int DbID)
        {
            return tableDetails.insertFRHProfRate(FRHProfRate, DbID);
        }

        #endregion

        #region InjuryCodes

        public List<TableInjuryCodes> getInjuryCodes(string SearchName, int DbID)
        {
            return tableDetails.getInjuryCodes(SearchName, DbID);
        }

        public bool DeleteInjuryCodes(long ID, string username, int DbID)
        {
            return tableDetails.deleteInjuryCodes(ID, username, DbID);
        }

        public bool UpdateInjuryCodes(TableInjuryCodes InjuryCodes, string username, int DbID)
        {
            return tableDetails.updateInjuryCodes(InjuryCodes, username, DbID);
        }

        public bool InsertInjuryCodes(TableInjuryCodes InjuryCodes, int DbID)
        {
            return tableDetails.insertInjuryCodes(InjuryCodes, DbID);
        }

        #endregion

        #region MVA_FRH

        public List<TableMVA_FRH> getMVA_FRH(string SearchName, int DbID)
        {
            return tableDetails.getMVA_FRH(SearchName, DbID);
        }

        public bool DeleteMVA_FRH(long ID, string username, int DbID)
        {
            return tableDetails.deleteMVA_FRH(ID, username, DbID);
        }

        public bool UpdateMVA_FRH(TableMVA_FRH MVA_FRH, string username, int DbID)
        {
            return tableDetails.updateMVA_FRH(MVA_FRH, username, DbID);
        }

        public bool InsertMVA_FRH(TableMVA_FRH MVA_FRH, int DbID)
        {
            return tableDetails.insertMVA_FRH(MVA_FRH, DbID);
        }

        #endregion

        #region MVAAccidentCodes

        public List<TableMVAAccidentCodes> getMVAAccidentCodes(string SearchName, int DbID)
        {
            return tableDetails.getMVAAccidentCodes(SearchName, DbID);
        }

        public bool DeleteMVAAccidentCodes(long ID, string username, int DbID)
        {
            return tableDetails.deleteMVAAccidentCodes(ID, username, DbID);
        }

        public bool UpdateMVAAccidentCodes(TableMVAAccidentCodes MVAAccidentCodes, string username, int DbID)
        {
            return tableDetails.updateMVAAccidentCodes(MVAAccidentCodes, username, DbID);
        }

        public bool InsertMVAAccidentCodes(TableMVAAccidentCodes MVAAccidentCodes, int DbID)
        {
            return tableDetails.insertMVAAccidentCodes(MVAAccidentCodes, DbID);
        }

        #endregion

        #region UniPcpDetails

        public List<TableUniPcpDetails> getUniPcpDetails(string SearchName, int DbID)
        {
            return tableDetails.getUniPcpDetails(SearchName, DbID);
        }

        public bool DeleteUniPcpDetails(long ID, string username, int DbID)
        {
            return tableDetails.deleteUniPcpDetails(ID, username, DbID);
        }

        public bool UpdateUniPcpDetails(TableUniPcpDetails UniPcpDetails, string username, int DbID)
        {
            return tableDetails.updateUniPcpDetails(UniPcpDetails, username, DbID);
        }

        public bool InsertUniPcpDetails(TableUniPcpDetails UniPcpDetails, int DbID)
        {
            return tableDetails.insertUniPcpDetails(UniPcpDetails, DbID);
        }

        #endregion

        #region UniProfClaimFeeSchedule

        public List<TableUniProfClaimFeeSchedule> getUniProfClaimFeeSchedule(string SearchName, int DbID)
        {
            return tableDetails.getUniProfClaimFeeSchedule(SearchName, DbID);
        }

        public bool DeleteUniProfClaimFeeSchedule(long ID, string username, int DbID)
        {
            return tableDetails.deleteUniProfClaimFeeSchedule(ID, username, DbID);
        }

        public bool UpdateUniProfClaimFeeSchedule(TableUniProfClaimFeeSchedule UniProfClaimFeeSchedule, string username, int DbID)
        {
            return tableDetails.updateUniProfClaimFeeSchedule(UniProfClaimFeeSchedule, username, DbID);
        }

        public bool InsertUniProfClaimFeeSchedule(TableUniProfClaimFeeSchedule UniProfClaimFeeSchedule, int DbID)
        {
            return tableDetails.insertUniProfClaimFeeSchedule(UniProfClaimFeeSchedule, DbID);
        }

        #endregion

        #region FreedomCensus

        public List<TableFreedomCensus> getFreedomCensus(string SearchName, int DbID)
        {
            return tableDetails.getFreedomCensus(SearchName, DbID);
        }

        public bool DeleteFreedomCensus(long ID, string username, int DbID)
        {
            return tableDetails.deleteFreedomCensus(ID, username, DbID);
        }

        public bool UpdateFreedomCensus(TableFreedomCensus FreedomCensus, string username, int DbID)
        {
            return tableDetails.updateFreedomCensus(FreedomCensus, username, DbID);
        }

        public bool InsertFreedomCensus(TableFreedomCensus FreedomCensus, int DbID)
        {
            return tableDetails.insertFreedomCensus(FreedomCensus, DbID);
        }

        #endregion

        #region FRQuestCarveOut

        public List<TableFRQuestCarveOut> getFRQuestCarveOut(string SearchName, int DbID)
        {
            return tableDetails.getFRQuestCarveOut(SearchName, DbID);
        }

        public bool DeleteFRQuestCarveOut(long ID, string username, int DbID)
        {
            return tableDetails.deleteFRQuestCarveOut(ID, username, DbID);
        }

        public bool UpdateFRQuestCarveOut(TableFRQuestCarveOut FRQuestCarveOut, string username, int DbID)
        {
            return tableDetails.updateFRQuestCarveOut(FRQuestCarveOut, username, DbID);
        }

        public bool InsertFRQuestCarveOut(TableFRQuestCarveOut FRQuestCarveOut, int DbID)
        {
            return tableDetails.insertFRQuestCarveOut(FRQuestCarveOut, DbID);
        }

        #endregion

        #region ModifierListPayment

        public List<TableModifierListPayment> getModifierListPayment(string SearchName, int DbID)
        {
            return tableDetails.getModifierListPayment(SearchName, DbID);
        }

        public bool DeleteModifierListPayment(long ID, string username, int DbID)
        {
            return tableDetails.deleteModifierListPayment(ID, username, DbID);
        }

        public bool UpdateModifierListPayment(TableModifierListPayment ModifierListPayment, string username, int DbID)
        {
            return tableDetails.updateModifierListPayment(ModifierListPayment, username, DbID);
        }

        public bool InsertModifierListPayment(TableModifierListPayment ModifierListPayment, int DbID)
        {
            return tableDetails.insertModifierListPayment(ModifierListPayment, DbID);
        }

        #endregion

        #region ContFrdmCapitatedProviders

        public List<TableContFrdmCapitatedProviders> getContFrdmCapitatedProviders(string SearchName, int DbID)
        {
            return tableDetails.getContFrdmCapitatedProviders(SearchName, DbID);
        }

        public bool DeleteContFrdmCapitatedProviders(long ID, string username, int DbID)
        {
            return tableDetails.deleteContFrdmCapitatedProviders(ID, username, DbID);
        }

        public bool UpdateContFrdmCapitatedProviders(TableContFrdmCapitatedProviders ContFrdmCapitatedProviders, string username, int DbID)
        {
            return tableDetails.updateContFrdmCapitatedProviders(ContFrdmCapitatedProviders, username, DbID);
        }

        public bool InsertContFrdmCapitatedProviders(TableContFrdmCapitatedProviders ContFrdmCapitatedProviders, int DbID)
        {
            return tableDetails.insertContFrdmCapitatedProviders(ContFrdmCapitatedProviders, DbID);
        }

        #endregion

        #region ConUNIAnesthesiaFeeSchedule

        public List<TableConUNIAnesthesiaFeeSchedule> getConUNIAnesthesiaFeeSchedule(string SearchName, int DbID)
        {
            return tableDetails.getConUNIAnesthesiaFeeSchedule(SearchName, DbID);
        }

        public bool DeleteConUNIAnesthesiaFeeSchedule(long ID, string username, int DbID)
        {
            return tableDetails.deleteConUNIAnesthesiaFeeSchedule(ID, username, DbID);
        }

        public bool UpdateConUNIAnesthesiaFeeSchedule(TableConUNIAnesthesiaFeeSchedule ConUNIAnesthesiaFeeSchedule, string username, int DbID)
        {
            return tableDetails.updateConUNIAnesthesiaFeeSchedule(ConUNIAnesthesiaFeeSchedule, username, DbID);
        }

        public bool InsertConUNIAnesthesiaFeeSchedule(TableConUNIAnesthesiaFeeSchedule ConUNIAnesthesiaFeeSchedule, int DbID)
        {
            return tableDetails.insertConUNIAnesthesiaFeeSchedule(ConUNIAnesthesiaFeeSchedule, DbID);
        }

        #endregion

    }
}
