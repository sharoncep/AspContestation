using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entities;

namespace Contestation.Freedom
{
    public partial class tblContFrdmCapitatedProvidersAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //    StringBuilder scripts = new StringBuilder();
            //    scripts.Append("<script type='text/javascript'>");
            //    scripts.Append("$().ready(function() {");
            //    scripts.Append("$('#txtFromDate').datepicker();");
            //    scripts.Append("});");
            //    scripts.Append("</script>");


            //    Page.ClientScript.RegisterStartupScript(txtFromDate.GetType(), txtFromDate.ClientID + "_ReadyScript", scripts.ToString());
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            tableHandler insertHandler = new tableHandler();
            TableContFrdmCapitatedProviders ContFrdmCapitatedProviders = new TableContFrdmCapitatedProviders();

            ContFrdmCapitatedProviders.CapitatedProviders = txtCapProv.Text;
            ContFrdmCapitatedProviders.ProviderID = txtProviderID.Text;
            ContFrdmCapitatedProviders.PlanNumber = txtPlanNo.Text;
            ContFrdmCapitatedProviders.IPAName = txtIPAName.Text;
            ContFrdmCapitatedProviders.PlanName = txtPlanName.Text;
            ContFrdmCapitatedProviders.From_Date = txtFromDate.Text == "" ? null : txtFromDate.Text;
            ContFrdmCapitatedProviders.To_Date = txtToDate.Text == "" ? null : txtToDate.Text;
            ContFrdmCapitatedProviders.Speciality_name = txtSpecName.Text;
            ContFrdmCapitatedProviders.Speciality_fund = txtSpecFund.Text;

            bool success = insertHandler.InsertContFrdmCapitatedProviders(ContFrdmCapitatedProviders, (int)_Contestation.FREEDOM);

            if (success)
            {
                Response.Redirect("tblContFrdmCapitatedProviders.aspx");
            }

        }
    }
}