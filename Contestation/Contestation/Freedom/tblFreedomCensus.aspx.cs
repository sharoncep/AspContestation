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
    public partial class tblFreedomCensus : System.Web.UI.Page
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
            List<TableFreedomCensus> lstFreedomCensus = new List<TableFreedomCensus>();

            tableHandler getFreedomCensus = new tableHandler();


            lstFreedomCensus = getFreedomCensus.getFreedomCensus(txtSearchName.Text, (int)_Contestation.FREEDOM);


            if (lstFreedomCensus != null)
            {
                if (lstFreedomCensus.Any())
                {
                    GridViewFreedomCensus.DataSource = lstFreedomCensus;
                    GridViewFreedomCensus.DataBind();
                }
                else
                {
                    GridViewFreedomCensus.DataSource = null;
                    GridViewFreedomCensus.DataBind();
                }
            }
            else
            {
                GridViewFreedomCensus.DataSource = null;
                GridViewFreedomCensus.DataBind();
            }
        }

        protected void GridViewFreedomCensus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewFreedomCensus.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewFreedomCensus_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewFreedomCensus.EditIndex = -1;
            loadData();
        }

        protected void GridViewFreedomCensus_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewFreedomCensus_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteFreedomCensus(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewFreedomCensus.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewFreedomCensus_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewFreedomCensus.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewFreedomCensus_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableFreedomCensus FreedomCensus = new TableFreedomCensus();



            Label ID = (Label)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("lblID");
            TextBox PCP_Name = (TextBox)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("txtPCP_Name");
            TextBox Member_Name = (TextBox)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("txtMember_Name");
            TextBox Member_ID = (TextBox)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("txtMember_ID");
            TextBox Admit_Date = (TextBox)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("txtAdmit_Date");
            TextBox Discharge_Date = (TextBox)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("txtDischarge_Date");
            TextBox Admit_Diagnosis = (TextBox)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("txtAdmit_Diagnosis");
            TextBox Facility_Name = (TextBox)GridViewFreedomCensus.Rows[e.RowIndex].FindControl("txtFacility_Name");

            FreedomCensus.ID = ID.Text;
            FreedomCensus.PCP_Name = PCP_Name.Text;
            FreedomCensus.Member_Name = Member_Name.Text;
            FreedomCensus.Member_ID = Member_ID.Text;
            FreedomCensus.Admit_Date = Admit_Date.Text == "" ? null : Admit_Date.Text;
            FreedomCensus.Discharge_Date = Discharge_Date.Text == "" ? null : Discharge_Date.Text;
            FreedomCensus.Admit_Diagnosis = Admit_Diagnosis.Text;
            FreedomCensus.Facility_Name = Facility_Name.Text;

            bool success = updateHandler.UpdateFreedomCensus(FreedomCensus, Session["username"].ToString(), (int)_Contestation.FREEDOM);

            if (success)
            {
                GridViewFreedomCensus.EditIndex = -1;
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