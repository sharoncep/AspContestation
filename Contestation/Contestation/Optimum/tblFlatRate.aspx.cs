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
    public partial class tblFlatRate : System.Web.UI.Page
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
            List<TableFlatRate> lstFlatRate = new List<TableFlatRate>();

            tableHandler getFlatRate = new tableHandler();


            lstFlatRate = getFlatRate.getFlatRate(txtSearchName.Text, (int)_Contestation.OPTIMUM);

            if (lstFlatRate != null)
            {
                if (lstFlatRate.Any())
                {
                    GridViewFlatRate.DataSource = lstFlatRate;
                    GridViewFlatRate.DataBind();
                }
                else
                {
                    GridViewFlatRate.DataSource = null;
                    GridViewFlatRate.DataBind();
                }
            }
            else
            {
                GridViewFlatRate.DataSource = null;
                GridViewFlatRate.DataBind();
            }
        }

        protected void GridViewFlatRate_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewFlatRate.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewFlatRate_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewFlatRate.EditIndex = -1;
            loadData();
        }

        protected void GridViewFlatRate_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewFlatRate_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewFlatRate.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteFlatRate(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewFlatRate.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewFlatRate_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewFlatRate.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewFlatRate_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableFlatRate flatRate = new TableFlatRate();

            Label ID = (Label)GridViewFlatRate.Rows[e.RowIndex].FindControl("lblID");
            TextBox ServiceCode = (TextBox)GridViewFlatRate.Rows[e.RowIndex].FindControl("txtServiceCode");
            TextBox Rate = (TextBox)GridViewFlatRate.Rows[e.RowIndex].FindControl("txtRate");

            flatRate.ID = ID.Text;
            flatRate.ServiceCode = ServiceCode.Text;
            flatRate.Rate = Rate.Text;


            bool success = updateHandler.UpdateFlatRate(flatRate, Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewFlatRate.EditIndex = -1;
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Record updated successfully!');", true);
                loadData();
            }

            //lblMessage.Text = "Record updated successfully!";
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}