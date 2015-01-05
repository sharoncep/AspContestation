using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entities;

namespace Contestation.Optimum
{
    public partial class tblConUNIAnesthesiaFeeScheduleAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            tableHandler insertHandler = new tableHandler();
            TableConUNIAnesthesiaFeeSchedule ConUNIAnesthesiaFeeSchedule = new TableConUNIAnesthesiaFeeSchedule();

            ConUNIAnesthesiaFeeSchedule.FromDate = txtFromDate.Text;
            ConUNIAnesthesiaFeeSchedule.ToDate = txtToDate.Text;
            ConUNIAnesthesiaFeeSchedule.ProcedureCode = txtProcCode.Text;
            ConUNIAnesthesiaFeeSchedule.Unit = txtUnit.Text;
            ConUNIAnesthesiaFeeSchedule.ParAllow = txtParAllow.Text;
            ConUNIAnesthesiaFeeSchedule.Locality = txtLocality.Text;
            ConUNIAnesthesiaFeeSchedule.IPA_NAME = txtIpaName.Text;
            ConUNIAnesthesiaFeeSchedule.PlanName = txtPlanName.Text;

            bool success = insertHandler.InsertConUNIAnesthesiaFeeSchedule(ConUNIAnesthesiaFeeSchedule, (int)_Contestation.OPTIMUM);

            if (success)
            {
                Response.Redirect("tblConUNIAnesthesiaFeeSchedule.aspx");
            }

        }
    }
}