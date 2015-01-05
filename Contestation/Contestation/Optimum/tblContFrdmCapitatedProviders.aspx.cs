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
    public partial class tblContFrdmCapitatedProviders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadData();
            }
        }

        private void loadData()
        {
            List<TableContFrdmCapitatedProviders> lstTableContFrdmCapitatedProviders = new List<TableContFrdmCapitatedProviders>();

            tableHandler getTableContFrdmCapitatedProviders = new tableHandler();


            lstTableContFrdmCapitatedProviders = getTableContFrdmCapitatedProviders.getContFrdmCapitatedProviders(txtSearchName.Text, (int)_Contestation.OPTIMUM);

            if (lstTableContFrdmCapitatedProviders != null)
            {
                if (lstTableContFrdmCapitatedProviders.Any())
                {
                    GridViewContFrdmCapitatedProviders.DataSource = lstTableContFrdmCapitatedProviders;
                    GridViewContFrdmCapitatedProviders.DataBind();
                }
                else
                {
                    GridViewContFrdmCapitatedProviders.DataSource = null;
                    GridViewContFrdmCapitatedProviders.DataBind();
                }
            }
            else
            {
                GridViewContFrdmCapitatedProviders.DataSource = null;
                GridViewContFrdmCapitatedProviders.DataBind();
            }
        }

        protected void GridViewContFrdmCapitatedProviders_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewContFrdmCapitatedProviders.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewContFrdmCapitatedProviders_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewContFrdmCapitatedProviders.EditIndex = -1;
            loadData();
        }

        protected void GridViewContFrdmCapitatedProviders_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewContFrdmCapitatedProviders_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteContFrdmCapitatedProviders(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewContFrdmCapitatedProviders.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewContFrdmCapitatedProviders_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewContFrdmCapitatedProviders.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewContFrdmCapitatedProviders_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableContFrdmCapitatedProviders ContFrdmCapitatedProviders = new TableContFrdmCapitatedProviders();

            Label ID = (Label)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("lblID");
            TextBox CapitatedProviders = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtCapitatedProviders");
            TextBox ProviderID = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtProviderID");
            TextBox PlanNumber = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtPlanNumber");
            TextBox IPAName = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtIPAName");
            TextBox PlanName = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtPlanName");
            TextBox From_Date = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtFrom_Date");
            TextBox To_Date = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtTo_Date");
            TextBox Speciality_name = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtSpeciality_name");
            TextBox Speciality_fund = (TextBox)GridViewContFrdmCapitatedProviders.Rows[e.RowIndex].FindControl("txtSpeciality_fund");

            ContFrdmCapitatedProviders.ID = ID.Text;
            ContFrdmCapitatedProviders.CapitatedProviders = CapitatedProviders.Text;
            ContFrdmCapitatedProviders.ProviderID = ProviderID.Text;
            ContFrdmCapitatedProviders.PlanNumber = PlanNumber.Text;
            ContFrdmCapitatedProviders.IPAName = IPAName.Text;
            ContFrdmCapitatedProviders.PlanName = PlanName.Text;
            ContFrdmCapitatedProviders.From_Date = From_Date.Text;
            ContFrdmCapitatedProviders.To_Date = To_Date.Text;
            ContFrdmCapitatedProviders.Speciality_name = Speciality_name.Text;
            ContFrdmCapitatedProviders.Speciality_fund = Speciality_fund.Text;

            bool success = updateHandler.UpdateContFrdmCapitatedProviders(ContFrdmCapitatedProviders, Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewContFrdmCapitatedProviders.EditIndex = -1;
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Record updated successfully!');", true);
                loadData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}