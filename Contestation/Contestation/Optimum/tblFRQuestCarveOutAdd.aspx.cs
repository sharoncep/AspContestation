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
    public partial class tblFRQuestCarveOutAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            tableHandler insertHandler = new tableHandler();
            TableFRQuestCarveOut FRQuestCarveOut = new TableFRQuestCarveOut();

            FRQuestCarveOut.CPT_CODE = txtCptCode.Text;
            FRQuestCarveOut.REIM_AMOUNT = txtReimAmt.Text;
            FRQuestCarveOut.EFF_YEAR = txtEffYear.Text;

            bool success = insertHandler.InsertFRQuestCarveOut(FRQuestCarveOut, (int)_Contestation.OPTIMUM);

            if (success)
            {
                Response.Redirect("tblFRQuestCarveOut.aspx");
            }
        }

    }
}