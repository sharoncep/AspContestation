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
    public partial class tblFRHProfRate : System.Web.UI.Page
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
            List<TableFRHProfRate> lstTableFRHProfRate = new List<TableFRHProfRate>();

            tableHandler getTableFRHProfRate = new tableHandler();


            lstTableFRHProfRate = getTableFRHProfRate.getFRHProfRate(txtSearchName.Text, (int)_Contestation.OPTIMUM);


            if (lstTableFRHProfRate != null)
            {
                if (lstTableFRHProfRate.Any())
                {
                    GridViewFRHProfRate.DataSource = lstTableFRHProfRate;
                    GridViewFRHProfRate.DataBind();
                }
                else
                {
                    GridViewFRHProfRate.DataSource = null;
                    GridViewFRHProfRate.DataBind();
                }
            }
            else
            {
                GridViewFRHProfRate.DataSource = null;
                GridViewFRHProfRate.DataBind();
            }
        }

        protected void GridViewFRHProfRate_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewFRHProfRate.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewFRHProfRate_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewFRHProfRate.EditIndex = -1;
            loadData();
        }

        protected void GridViewFRHProfRate_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewFRHProfRate_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewFRHProfRate.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteFRHProfRate(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewFRHProfRate.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewFRHProfRate_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewFRHProfRate.EditIndex = e.NewEditIndex;
            loadData();

        }

        protected void GridViewFRHProfRate_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            tableHandler updateHandler = new tableHandler();
            TableFRHProfRate FRHProfRate = new TableFRHProfRate();

            Label ID = (Label)GridViewFRHProfRate.Rows[e.RowIndex].FindControl("lblID");
            TextBox txtSERVICE_PROVIDER_NAME = (TextBox)GridViewFRHProfRate.Rows[e.RowIndex].FindControl("txtSERVICE_PROVIDER_NAME");
            TextBox txtSERVICE_PROVIDER_ID = (TextBox)GridViewFRHProfRate.Rows[e.RowIndex].FindControl("txtSERVICE_PROVIDER_ID");
            TextBox txtFLAT_RATE = (TextBox)GridViewFRHProfRate.Rows[e.RowIndex].FindControl("txtFLAT_RATE");
            TextBox txtSpeciality = (TextBox)GridViewFRHProfRate.Rows[e.RowIndex].FindControl("txtSpeciality");
            TextBox txtRATE = (TextBox)GridViewFRHProfRate.Rows[e.RowIndex].FindControl("txtRATE");

            FRHProfRate.ID = ID.Text;
            FRHProfRate.SERVICE_PROVIDER_NAME = txtSERVICE_PROVIDER_NAME.Text;
            FRHProfRate.SERVICE_PROVIDER_ID = txtSERVICE_PROVIDER_ID.Text;
            FRHProfRate.FLAT_RATE = txtFLAT_RATE.Text;
            FRHProfRate.Speciality = txtSpeciality.Text;
            FRHProfRate.RATE = txtRATE.Text;


            bool success = updateHandler.UpdateFRHProfRate(FRHProfRate, Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewFRHProfRate.EditIndex = -1;
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