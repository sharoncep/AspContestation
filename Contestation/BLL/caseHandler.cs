using System.Collections.Generic;
using System.Data;
using DAL;
using Entities;

namespace BLL
{
    public class caseHandler
    {
        // Handle to the dbOperations class
        dbOperations caseDb = null;

        public caseHandler()
        {
            caseDb = new dbOperations();
        }

        #region Freedom

        // This fuction does not contain any business logic, it simply returns the 
        // list of Data, we can put some logic here if needed
        public List<contestationCases> getCaseDetails(int caseNo, string pcpID, string pcpCounty, string fromDate, string toDate, string claimType, int DbID)
        {
            return caseDb.getCaseDetails(caseNo, pcpID, pcpCounty, fromDate, toDate, claimType, DbID);
        }

        public List<pcpCounty> getPcpCounty(int DbID)
        {
            return caseDb.getPcpCounty(DbID);
        }

        public List<pcpNames> getPcpNames(string pcpCounty, string claimType, int DbID)
        {
            return caseDb.getPcpNames(pcpCounty, claimType, DbID);
        }

        public bool insertResults(resultsObjects result, string username, string userId, int DbID)
        {
            return caseDb.insertResults(result, username, userId, DbID);
        }

        #endregion

    }

    public class resultHandler
    {
        dbOperations resultDb = null;

        public resultHandler()
        {
            resultDb = new dbOperations();
        }

        public List<resultsObjects> getResultDetails(string fromDate, string toDate, int DbID)
        {
            return resultDb.getCaseDetails(fromDate, toDate, DbID);
        }

        public DataTable getExcelResultDetails(string fromDate, string toDate, int DbID)
        {
            return resultDb.getCaseDetailsExcel(fromDate, toDate, DbID);
        }
    }
}
