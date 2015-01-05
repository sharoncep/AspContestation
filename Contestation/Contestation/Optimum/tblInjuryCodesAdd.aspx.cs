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
    public partial class tblInjuryCodesAdd : System.Web.UI.Page
    {
        protected void txtAdd_Click(object sender, EventArgs e)
        {

            tableHandler insertHandler = new tableHandler();
            TableInjuryCodes InjuryCodes = new TableInjuryCodes();

            InjuryCodes.InjuryCode = txtInjuryCode.Text;
            InjuryCodes.InjuryCodeDesc = txtDesc.Text;
            InjuryCodes.InjuryCodeShortDesc = txtShortDesc.Text;

            bool success = insertHandler.InsertInjuryCodes(InjuryCodes, (int)_Contestation.OPTIMUM);

            if (success)
            {
                Response.Redirect("tblInjuryCodes.aspx");
            }
        }
    }
}