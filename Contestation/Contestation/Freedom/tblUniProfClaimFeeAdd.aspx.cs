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
    public partial class tblUniProfClaimFeeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
                tableHandler insertHandler = new tableHandler();
                TableUniProfClaimFeeSchedule UniProfClaimFee = new TableUniProfClaimFeeSchedule();

                UniProfClaimFee.PeriodFrom = txtPeriodFrom.Text;
                UniProfClaimFee.PeriodTo = txtPeriodTo.Text;
                UniProfClaimFee.procedure = txtProcedure.Text;
                UniProfClaimFee.modifier = txtModifier.Text;
                UniProfClaimFee.ParAllow = txtParAllow.Text;
                UniProfClaimFee.Locality = txtLocality.Text;

                bool success = insertHandler.InsertUniProfClaimFeeSchedule(UniProfClaimFee, (int)_Contestation.FREEDOM);

                if (success)
                {
                    Response.Redirect("tblUniProfClaimFee.aspx");
                }
            
        }
    }
}