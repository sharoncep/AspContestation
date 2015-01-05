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
    public partial class tblUniPcpDetailsAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            tableHandler insertHandler = new tableHandler();
            TableUniPcpDetails UniPcpDetails = new TableUniPcpDetails();

            UniPcpDetails.PCPID = txtPcpID.Text;
            UniPcpDetails.PCPName = txtPcpName.Text;
            UniPcpDetails.County = txtCounty.Text;
            UniPcpDetails.EffectiveDate = txtEffectiveDate.Text;
            UniPcpDetails.TerminatedDate = txtTerminatedDate.Text;
            UniPcpDetails.Status = txtStatus.Text;
            UniPcpDetails.FeeScheduleLOC = txtFeeScheduleLoc.Text;
            UniPcpDetails.IPAName = txtIpaName.Text;
            UniPcpDetails.PlanName = txtPlanName.Text;

            bool success = insertHandler.InsertUniPcpDetails(UniPcpDetails, (int)_Contestation.FREEDOM);

            if (success)
            {
                Response.Redirect("tblUniPcpDetails.aspx");
            }

        }
    }
}