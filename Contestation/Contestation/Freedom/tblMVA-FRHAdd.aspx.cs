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
    public partial class tblMVA_FRHAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            tableHandler insertHandler = new tableHandler();
            TableMVA_FRH MVA_FRH = new TableMVA_FRH();

            MVA_FRH.PCP_NAME = txtPcpName.Text;
            MVA_FRH.PCP_ID = txtPcpID.Text;
            MVA_FRH.SUBSCRIBER_ID = txtSubID.Text;
            MVA_FRH.MEMBER_NAME = txtMemberName.Text;
            MVA_FRH.DOS = txtDos.Text;

            bool success = insertHandler.InsertMVA_FRH(MVA_FRH, (int)_Contestation.FREEDOM);

            if (success)
            {
                Response.Redirect("tblMVA-FRH.aspx");
            }

        }
    }
}