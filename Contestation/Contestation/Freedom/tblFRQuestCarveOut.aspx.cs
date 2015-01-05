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
    public partial class tblFRQuestCarveOut : System.Web.UI.Page
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
            List<TableFRQuestCarveOut> lstFRQuestCarveOut = new List<TableFRQuestCarveOut>();

            tableHandler getFRQuestCarveOut = new tableHandler();


            lstFRQuestCarveOut = getFRQuestCarveOut.getFRQuestCarveOut(txtSearchName.Text, (int)_Contestation.FREEDOM);

            
            if (lstFRQuestCarveOut != null)
            {
                if (lstFRQuestCarveOut.Any())
                {
                    GridViewFRQuestCarveOut.DataSource = lstFRQuestCarveOut;
                    GridViewFRQuestCarveOut.DataBind();
                }
                else
                {
                    GridViewFRQuestCarveOut.DataSource = null;
                    GridViewFRQuestCarveOut.DataBind();
                }
            }
            else
            {
                GridViewFRQuestCarveOut.DataSource = null;
                GridViewFRQuestCarveOut.DataBind();
            }
        }

        protected void GridViewFRQuestCarveOut_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewFRQuestCarveOut.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewFRQuestCarveOut_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewFRQuestCarveOut.EditIndex = -1;
            loadData();
        }

        protected void GridViewFRQuestCarveOut_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }

        protected void GridViewFRQuestCarveOut_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewFRQuestCarveOut.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteFRQuestCarveOut(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewFRQuestCarveOut.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewFRQuestCarveOut_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewFRQuestCarveOut.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewFRQuestCarveOut_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableFRQuestCarveOut FRQuestCarveOut = new TableFRQuestCarveOut();

            Label ID = (Label)GridViewFRQuestCarveOut.Rows[e.RowIndex].FindControl("lblID");
            TextBox CPT_CODE = (TextBox)GridViewFRQuestCarveOut.Rows[e.RowIndex].FindControl("txtCPT_CODE");
            TextBox REIM_AMOUNT = (TextBox)GridViewFRQuestCarveOut.Rows[e.RowIndex].FindControl("txtREIM_AMOUNT");
            TextBox EFF_YEAR = (TextBox)GridViewFRQuestCarveOut.Rows[e.RowIndex].FindControl("txtEFF_YEAR");

            FRQuestCarveOut.ID = ID.Text;
            FRQuestCarveOut.CPT_CODE = CPT_CODE.Text;
            FRQuestCarveOut.REIM_AMOUNT = REIM_AMOUNT.Text;
            FRQuestCarveOut.EFF_YEAR = EFF_YEAR.Text;

            bool success = updateHandler.UpdateFRQuestCarveOut(FRQuestCarveOut, Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewFRQuestCarveOut.EditIndex = -1;
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