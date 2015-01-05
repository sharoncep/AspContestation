using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entities;

namespace Contestation.Freedom
{
    public partial class tblFreedomCensusAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
           
                tableHandler insertHandler = new tableHandler();
                TableFreedomCensus FreedomCensus = new TableFreedomCensus();

                FreedomCensus.PCP_Name = txtPcpName.Text;
                FreedomCensus.Member_Name = txtMemberName.Text;
                FreedomCensus.Member_ID = txtMemberID.Text;
                FreedomCensus.Admit_Date = txtAdmitDate.Text;
                FreedomCensus.Discharge_Date = txtDischargeDate.Text;
                FreedomCensus.Admit_Diagnosis = txtAdmitDg.Text;
                FreedomCensus.Facility_Name = txtFacilityName.Text;

                bool success = insertHandler.InsertFreedomCensus(FreedomCensus, (int)_Contestation.FREEDOM);

                if (success)
                {
                    Response.Redirect("tblFreedomCensus.aspx");
                }
            
        }
    }
}