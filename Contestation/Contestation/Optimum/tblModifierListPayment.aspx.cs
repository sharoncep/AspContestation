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
    public partial class tblModifierListPayment : System.Web.UI.Page
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
            List<TableModifierListPayment> lstTableModifierListPayment = new List<TableModifierListPayment>();

            tableHandler getTableModifierListPayment = new tableHandler();


            lstTableModifierListPayment = getTableModifierListPayment.getModifierListPayment(txtSearchName.Text, (int)_Contestation.OPTIMUM);


            if (lstTableModifierListPayment != null)
            {
                if (lstTableModifierListPayment.Any())
                {
                    GridViewModifierListPayment.DataSource = lstTableModifierListPayment;
                    GridViewModifierListPayment.DataBind();
                }
                else
                {
                    GridViewModifierListPayment.DataSource = null;
                    GridViewModifierListPayment.DataBind();
                }
            }
            else
            {
                GridViewModifierListPayment.DataSource = null;
                GridViewModifierListPayment.DataBind();
            }
        }

        protected void GridViewModifierListPayment_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewModifierListPayment.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewModifierListPayment_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewModifierListPayment.EditIndex = -1;
            loadData();
        }

        protected void GridViewModifierListPayment_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewModifierListPayment_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewModifierListPayment.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteModifierListPayment(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewModifierListPayment.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewModifierListPayment_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewModifierListPayment.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewModifierListPayment_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableModifierListPayment ModifierListPayment = new TableModifierListPayment();

            Label ID = (Label)GridViewModifierListPayment.Rows[e.RowIndex].FindControl("lblID");
            TextBox Modifier = (TextBox)GridViewModifierListPayment.Rows[e.RowIndex].FindControl("txtModifier");
            TextBox Allowance = (TextBox)GridViewModifierListPayment.Rows[e.RowIndex].FindControl("txtAllowance");

            ModifierListPayment.ID = ID.Text;
            ModifierListPayment.Modifier = Modifier.Text;
            ModifierListPayment.Allowance = Allowance.Text;

            bool success = updateHandler.UpdateModifierListPayment(ModifierListPayment, Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewModifierListPayment.EditIndex = -1;
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