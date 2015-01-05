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
    public partial class tblFRHProfRateAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            tableHandler insertHandler = new tableHandler();
            TableFRHProfRate FRHProfRate = new TableFRHProfRate();

            FRHProfRate.SERVICE_PROVIDER_NAME = txtServProName.Text;
            FRHProfRate.SERVICE_PROVIDER_ID = txtServProID.Text;
            FRHProfRate.FLAT_RATE = txtFlatRate.Text;
            FRHProfRate.Speciality = txtSpeciality.Text;
            FRHProfRate.RATE = txtRate.Text;

            bool success = insertHandler.InsertFRHProfRate(FRHProfRate, (int)_Contestation.OPTIMUM);

            if (success)
            {
                Response.Redirect("tblFRHProfRate.aspx");
            }
            //lblMessage.Text = "Record inserted successfully!";

        }
    }
}