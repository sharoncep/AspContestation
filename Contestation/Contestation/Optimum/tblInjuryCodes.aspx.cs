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
    public partial class tblInjuryCodes : System.Web.UI.Page
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
            List<TableInjuryCodes> lstTableInjuryCodes = new List<TableInjuryCodes>();

            tableHandler getTableInjuryCodes = new tableHandler();


            lstTableInjuryCodes = getTableInjuryCodes.getInjuryCodes(txtSearchName.Text, (int)_Contestation.OPTIMUM);


            if (lstTableInjuryCodes != null)
            {
                if (lstTableInjuryCodes.Any())
                {
                    GridViewTblInjuryCodes.DataSource = lstTableInjuryCodes;
                    GridViewTblInjuryCodes.DataBind();
                }
                else
                {
                    GridViewTblInjuryCodes.DataSource = null;
                    GridViewTblInjuryCodes.DataBind();
                }
            }
            else
            {
                GridViewTblInjuryCodes.DataSource = null;
                GridViewTblInjuryCodes.DataBind();
            }
        }

        protected void GridViewTblInjuryCodes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewTblInjuryCodes.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewTblInjuryCodes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewTblInjuryCodes.EditIndex = -1;
            loadData();
        }

        protected void GridViewTblInjuryCodes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewTblInjuryCodes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewTblInjuryCodes.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteInjuryCodes(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewTblInjuryCodes.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewTblInjuryCodes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewTblInjuryCodes.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewTblInjuryCodes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableInjuryCodes InjuryCodes = new TableInjuryCodes();

            Label ID = (Label)GridViewTblInjuryCodes.Rows[e.RowIndex].FindControl("lblID");
            TextBox txtInjuryCode = (TextBox)GridViewTblInjuryCodes.Rows[e.RowIndex].FindControl("txtInjuryCode");
            TextBox txtInjuryCodeDesc = (TextBox)GridViewTblInjuryCodes.Rows[e.RowIndex].FindControl("txtInjuryCodeDesc");
            TextBox txtInjuryCodeShortDesc = (TextBox)GridViewTblInjuryCodes.Rows[e.RowIndex].FindControl("txtInjuryCodeShortDesc");

            InjuryCodes.ID = ID.Text;
            InjuryCodes.InjuryCode = txtInjuryCode.Text;
            InjuryCodes.InjuryCodeDesc = txtInjuryCodeDesc.Text;
            InjuryCodes.InjuryCodeShortDesc = txtInjuryCodeShortDesc.Text;

            bool success = updateHandler.UpdateInjuryCodes(InjuryCodes, Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewTblInjuryCodes.EditIndex = -1;
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