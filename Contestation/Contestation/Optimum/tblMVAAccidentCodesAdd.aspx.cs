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
    public partial class tblMVAAccidentCodesAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            tableHandler insertHandler = new tableHandler();
            TableMVAAccidentCodes MVAAccidentCodes = new TableMVAAccidentCodes();

            MVAAccidentCodes.ICDCodes = txtIcdCodes.Text;
            MVAAccidentCodes.LongDescription = txtLongDesc.Text;
            MVAAccidentCodes.ShortDescription = txtShortDesc.Text;

            bool success = insertHandler.InsertMVAAccidentCodes(MVAAccidentCodes, (int)_Contestation.OPTIMUM);

            if (success)
            {
                Response.Redirect("tblMVAAccidentCodes.aspx");
            }

        }
    }
}