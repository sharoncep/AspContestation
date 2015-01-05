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
    public partial class tblFlatRateAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            tableHandler insertHandler = new tableHandler();
            TableFlatRate flatRate = new TableFlatRate();

            flatRate.ServiceCode = txtServiceCode.Text;
            flatRate.Rate = txtRate.Text;

            bool success = insertHandler.InsertFlatRate(flatRate, (int)_Contestation.OPTIMUM);

            if (success)
            {
                Server.Transfer("tblFlatRate.aspx");
            }


        }
    }
}