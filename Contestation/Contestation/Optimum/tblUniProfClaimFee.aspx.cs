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
    public partial class tblUniProfClaimFee : System.Web.UI.Page
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
            List<TableUniProfClaimFeeSchedule> lstTableUniProfClaimFeeSchedule = new List<TableUniProfClaimFeeSchedule>();

            tableHandler getTableUniProfClaimFeeSchedule = new tableHandler();


            lstTableUniProfClaimFeeSchedule = getTableUniProfClaimFeeSchedule.getUniProfClaimFeeSchedule(txtSearchName.Text, (int)_Contestation.OPTIMUM);


            GridViewUniProfClaimFee.DataSource = lstTableUniProfClaimFeeSchedule;
            GridViewUniProfClaimFee.DataBind();

            //if (lstTableUniProfClaimFeeSchedule != null)
            //{
            //    if (lstTableUniProfClaimFeeSchedule.Any())
            //    {
            //        GridViewUniProfClaimFee.DataSource = lstTableUniProfClaimFeeSchedule;
            //        GridViewUniProfClaimFee.DataBind();
            //    }
            //    else
            //    {
            //        GridViewUniProfClaimFee.DataSource = null;
            //        GridViewUniProfClaimFee.DataBind();
            //    }
            //}
            //else
            //{
            //    GridViewUniProfClaimFee.DataSource = null;
            //    GridViewUniProfClaimFee.DataBind();
            //}
        }
        protected void GridViewUniProfClaimFee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewUniProfClaimFee.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewUniProfClaimFee_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewUniProfClaimFee.EditIndex = -1;
            loadData();
        }

        protected void GridViewUniProfClaimFee_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewUniProfClaimFee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewUniProfClaimFee.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteUniProfClaimFeeSchedule(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewUniProfClaimFee.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewUniProfClaimFee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUniProfClaimFee.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewUniProfClaimFee_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableUniProfClaimFeeSchedule UniProfClaimFee = new TableUniProfClaimFeeSchedule();

            Label ID = (Label)GridViewUniProfClaimFee.Rows[e.RowIndex].FindControl("lblID");
            TextBox txtPeriodFrom = (TextBox)GridViewUniProfClaimFee.Rows[e.RowIndex].FindControl("txtPeriodFrom");
            TextBox txtPeriodTo = (TextBox)GridViewUniProfClaimFee.Rows[e.RowIndex].FindControl("txtPeriodTo");
            TextBox txtprocedure = (TextBox)GridViewUniProfClaimFee.Rows[e.RowIndex].FindControl("txtprocedure");
            TextBox txtmodifier = (TextBox)GridViewUniProfClaimFee.Rows[e.RowIndex].FindControl("txtmodifier");
            TextBox txtParAllow = (TextBox)GridViewUniProfClaimFee.Rows[e.RowIndex].FindControl("txtParAllow");
            TextBox txtLocality = (TextBox)GridViewUniProfClaimFee.Rows[e.RowIndex].FindControl("txtLocality");


            UniProfClaimFee.ID = ID.Text;
            UniProfClaimFee.PeriodFrom = txtPeriodFrom.Text == "" ? null : txtPeriodFrom.Text;
            UniProfClaimFee.PeriodTo = txtPeriodTo.Text == "" ? null : txtPeriodTo.Text;
            UniProfClaimFee.procedure = txtprocedure.Text;
            UniProfClaimFee.modifier = txtmodifier.Text;
            UniProfClaimFee.ParAllow = txtParAllow.Text;
            UniProfClaimFee.Locality = txtLocality.Text;

            bool success = updateHandler.UpdateUniProfClaimFeeSchedule(UniProfClaimFee, Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewUniProfClaimFee.EditIndex = -1;
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