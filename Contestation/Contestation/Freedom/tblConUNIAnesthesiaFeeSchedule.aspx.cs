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
    public partial class tblConUNIAnesthesiaFeeSchedule : System.Web.UI.Page
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
            List<TableConUNIAnesthesiaFeeSchedule> lstTableConUNIAnesthesiaFeeSchedule = new List<TableConUNIAnesthesiaFeeSchedule>();

            tableHandler getTableConUNIAnesthesiaFeeSchedule = new tableHandler();


            lstTableConUNIAnesthesiaFeeSchedule = getTableConUNIAnesthesiaFeeSchedule.getConUNIAnesthesiaFeeSchedule(txtSearchName.Text, (int)_Contestation.FREEDOM);


            if (lstTableConUNIAnesthesiaFeeSchedule != null)
            {
                if (lstTableConUNIAnesthesiaFeeSchedule.Any())
                {
                    GridViewConUNIAnesthesiaFeeSchedule.DataSource = lstTableConUNIAnesthesiaFeeSchedule;
                    GridViewConUNIAnesthesiaFeeSchedule.DataBind();
                }
                else
                {
                    GridViewConUNIAnesthesiaFeeSchedule.DataSource = null;
                    GridViewConUNIAnesthesiaFeeSchedule.DataBind();
                }
            }
            else
            {
                GridViewConUNIAnesthesiaFeeSchedule.DataSource = null;
                GridViewConUNIAnesthesiaFeeSchedule.DataBind();
            }
        }

        protected void GridViewConUNIAnesthesiaFeeSchedule_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewConUNIAnesthesiaFeeSchedule.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewConUNIAnesthesiaFeeSchedule_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewConUNIAnesthesiaFeeSchedule.EditIndex = -1;
            loadData();
        }

        protected void GridViewConUNIAnesthesiaFeeSchedule_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewConUNIAnesthesiaFeeSchedule_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteConUNIAnesthesiaFeeSchedule(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewConUNIAnesthesiaFeeSchedule.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewConUNIAnesthesiaFeeSchedule_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewConUNIAnesthesiaFeeSchedule.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewConUNIAnesthesiaFeeSchedule_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableConUNIAnesthesiaFeeSchedule ConUNIAnesthesiaFeeSchedule = new TableConUNIAnesthesiaFeeSchedule();

            Label ID = (Label)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("lblID");
            TextBox FromDate = (TextBox)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("txtFromDate");
            TextBox ToDate = (TextBox)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("txtToDate");
            TextBox ProcedureCode = (TextBox)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("txtProcedureCode");
            TextBox Unit = (TextBox)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("txtUnit");
            TextBox ParAllow = (TextBox)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("txtParAllow");
            TextBox Locality = (TextBox)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("txtLocality");
            TextBox IPA_NAME = (TextBox)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("txtIPA_NAME");
            TextBox PlanName = (TextBox)GridViewConUNIAnesthesiaFeeSchedule.Rows[e.RowIndex].FindControl("txtPlanName");

            ConUNIAnesthesiaFeeSchedule.ID = ID.Text;
            ConUNIAnesthesiaFeeSchedule.FromDate = FromDate.Text == "" ? null : FromDate.Text;
            ConUNIAnesthesiaFeeSchedule.ToDate = ToDate.Text == "" ? null : ToDate.Text;
            ConUNIAnesthesiaFeeSchedule.ProcedureCode = ProcedureCode.Text;
            ConUNIAnesthesiaFeeSchedule.Unit = Unit.Text;
            ConUNIAnesthesiaFeeSchedule.ParAllow = ParAllow.Text;
            ConUNIAnesthesiaFeeSchedule.Locality = Locality.Text;
            ConUNIAnesthesiaFeeSchedule.IPA_NAME = IPA_NAME.Text;
            ConUNIAnesthesiaFeeSchedule.PlanName = PlanName.Text;

            bool success = updateHandler.UpdateConUNIAnesthesiaFeeSchedule(ConUNIAnesthesiaFeeSchedule, Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewConUNIAnesthesiaFeeSchedule.EditIndex = -1;
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