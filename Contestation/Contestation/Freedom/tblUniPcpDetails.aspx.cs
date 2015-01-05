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
    public partial class tblUniPcpDetails : System.Web.UI.Page
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
            List<TableUniPcpDetails> lstTableUniPcpDetails = new List<TableUniPcpDetails>();

            tableHandler getTableUniPcpDetails = new tableHandler();


            lstTableUniPcpDetails = getTableUniPcpDetails.getUniPcpDetails(txtSearchName.Text, (int)_Contestation.FREEDOM);


            if (lstTableUniPcpDetails != null)
            {
                if (lstTableUniPcpDetails.Any())
                {
                    GridViewUniPcpDetails.DataSource = lstTableUniPcpDetails;
                    GridViewUniPcpDetails.DataBind();
                }
                else
                {
                    GridViewUniPcpDetails.DataSource = null;
                    GridViewUniPcpDetails.DataBind();
                }
            }
            else
            {
                GridViewUniPcpDetails.DataSource = null;
                GridViewUniPcpDetails.DataBind();
            }
        }

        protected void GridViewUniPcpDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewUniPcpDetails.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewUniPcpDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewUniPcpDetails.EditIndex = -1;
            loadData();
        }

        protected void GridViewUniPcpDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewUniPcpDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteUniPcpDetails(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewUniPcpDetails.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewUniPcpDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUniPcpDetails.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewUniPcpDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableUniPcpDetails UniPcpDetails = new TableUniPcpDetails();

            Label ID = (Label)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("lblID");
            TextBox txtPCPID = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtPCPID");
            TextBox txtPCPName = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtPCPName");
            TextBox txtCounty = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtCounty");
            TextBox txtEffectiveDate = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtEffectiveDate");
            TextBox txtTerminatedDate = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtTerminatedDate");
            TextBox txtStatus = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtStatus");
            TextBox txtFeeScheduleLOC = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtFeeScheduleLOC");
            TextBox txtIPAName = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtIPAName");
            TextBox txtPlanName = (TextBox)GridViewUniPcpDetails.Rows[e.RowIndex].FindControl("txtPlanName");

            UniPcpDetails.ID = ID.Text;
            UniPcpDetails.PCPID = txtPCPID.Text;
            UniPcpDetails.PCPName = txtPCPName.Text;
            UniPcpDetails.County = txtCounty.Text;
            UniPcpDetails.EffectiveDate = txtEffectiveDate.Text == "" ? null : txtEffectiveDate.Text;
            UniPcpDetails.TerminatedDate = txtTerminatedDate.Text == "" ? null : txtTerminatedDate.Text;
            UniPcpDetails.Status = txtStatus.Text;
            UniPcpDetails.FeeScheduleLOC = txtFeeScheduleLOC.Text;
            UniPcpDetails.IPAName = txtIPAName.Text;
            UniPcpDetails.PlanName = txtPlanName.Text;

            bool success = updateHandler.UpdateUniPcpDetails(UniPcpDetails, Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewUniPcpDetails.EditIndex = -1;
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