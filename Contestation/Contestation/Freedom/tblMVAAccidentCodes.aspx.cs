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
    public partial class tblMVAAccidentCodes : System.Web.UI.Page
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
            List<TableMVAAccidentCodes> lstTableMVAAccidentCodes = new List<TableMVAAccidentCodes>();

            tableHandler getTableMVAAccidentCodes = new tableHandler();


            lstTableMVAAccidentCodes = getTableMVAAccidentCodes.getMVAAccidentCodes(txtSearchName.Text, (int)_Contestation.FREEDOM);

            
            if (lstTableMVAAccidentCodes != null)
            {
                if (lstTableMVAAccidentCodes.Any())
                {
                    GridViewMVAAccidentCodes.DataSource = lstTableMVAAccidentCodes;
                    GridViewMVAAccidentCodes.DataBind();
                }
                else
                {
                    GridViewMVAAccidentCodes.DataSource = null;
                    GridViewMVAAccidentCodes.DataBind();
                }
            }
            else
            {
                GridViewMVAAccidentCodes.DataSource = null;
                GridViewMVAAccidentCodes.DataBind();
            }
        }

        protected void GridViewMVAAccidentCodes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewMVAAccidentCodes.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewMVAAccidentCodes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewMVAAccidentCodes.EditIndex = -1;
            loadData();
        }

        protected void GridViewMVAAccidentCodes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }

        protected void GridViewMVAAccidentCodes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewMVAAccidentCodes.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteMVAAccidentCodes(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewMVAAccidentCodes.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewMVAAccidentCodes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewMVAAccidentCodes.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewMVAAccidentCodes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableMVAAccidentCodes MVAAccidentCodes = new TableMVAAccidentCodes();

            Label ID = (Label)GridViewMVAAccidentCodes.Rows[e.RowIndex].FindControl("lblID");
            TextBox txtICDCodes = (TextBox)GridViewMVAAccidentCodes.Rows[e.RowIndex].FindControl("txtICDCodes");
            TextBox txtLongDescription = (TextBox)GridViewMVAAccidentCodes.Rows[e.RowIndex].FindControl("txtLongDescription");
            TextBox txtShortDescription = (TextBox)GridViewMVAAccidentCodes.Rows[e.RowIndex].FindControl("txtShortDescription");


            MVAAccidentCodes.ID = ID.Text;
            MVAAccidentCodes.ICDCodes = txtICDCodes.Text;
            MVAAccidentCodes.LongDescription = txtLongDescription.Text;
            MVAAccidentCodes.ShortDescription = txtShortDescription.Text;

            bool success = updateHandler.UpdateMVAAccidentCodes(MVAAccidentCodes, Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewMVAAccidentCodes.EditIndex = -1;
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