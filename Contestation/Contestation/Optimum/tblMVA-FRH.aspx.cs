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
    public partial class tblMVA_FRH : System.Web.UI.Page
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
            List<TableMVA_FRH> lstTableMVA_FRH = new List<TableMVA_FRH>();

            tableHandler getTableMVA_FRH = new tableHandler();


            lstTableMVA_FRH = getTableMVA_FRH.getMVA_FRH(txtSearchName.Text, (int)_Contestation.OPTIMUM);

            if (lstTableMVA_FRH != null)
            {
                if (lstTableMVA_FRH.Any())
                {
                    GridViewTblMVA_FRH.DataSource = lstTableMVA_FRH;
                    GridViewTblMVA_FRH.DataBind();
                }
                else
                {
                    GridViewTblMVA_FRH.DataSource = null;
                    GridViewTblMVA_FRH.DataBind();
                }
            }
            else
            {
                GridViewTblMVA_FRH.DataSource = null;
                GridViewTblMVA_FRH.DataBind();
            }
        }

        protected void GridViewTblMVA_FRH_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewTblMVA_FRH.PageIndex = e.NewPageIndex;
            loadData();
        }

        protected void GridViewTblMVA_FRH_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewTblMVA_FRH.EditIndex = -1;
            loadData();
        }

        protected void GridViewTblMVA_FRH_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridViewTblMVA_FRH_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            tableHandler deleteHandler = new tableHandler();
            Label ID = (Label)GridViewTblMVA_FRH.Rows[e.RowIndex].FindControl("lblID");

            bool success = deleteHandler.DeleteMVA_FRH(Convert.ToInt64(ID.Text), Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewTblMVA_FRH.EditIndex = -1;
                loadData();
            }
        }

        protected void GridViewTblMVA_FRH_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewTblMVA_FRH.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void GridViewTblMVA_FRH_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            tableHandler updateHandler = new tableHandler();
            TableMVA_FRH MVA_FRH = new TableMVA_FRH();

            Label ID = (Label)GridViewTblMVA_FRH.Rows[e.RowIndex].FindControl("lblID");
            TextBox txtPCP_NAME = (TextBox)GridViewTblMVA_FRH.Rows[e.RowIndex].FindControl("txtPCP_NAME");
            TextBox txtPCP_ID = (TextBox)GridViewTblMVA_FRH.Rows[e.RowIndex].FindControl("txtPCP_ID");
            TextBox txtSUBSCRIBER_ID = (TextBox)GridViewTblMVA_FRH.Rows[e.RowIndex].FindControl("txtSUBSCRIBER_ID");
            TextBox txtMEMBER_NAME = (TextBox)GridViewTblMVA_FRH.Rows[e.RowIndex].FindControl("txtMEMBER_NAME");
            TextBox txtDOS = (TextBox)GridViewTblMVA_FRH.Rows[e.RowIndex].FindControl("txtDOS");

            MVA_FRH.ID = ID.Text;
            MVA_FRH.PCP_NAME = txtPCP_NAME.Text;
            MVA_FRH.PCP_ID = txtPCP_ID.Text;
            MVA_FRH.SUBSCRIBER_ID = txtSUBSCRIBER_ID.Text;
            MVA_FRH.MEMBER_NAME = txtMEMBER_NAME.Text;
            MVA_FRH.DOS = txtDOS.Text == "" ? null : txtDOS.Text;

            bool success = updateHandler.UpdateMVA_FRH(MVA_FRH, Session["username"].ToString(), (int)_Contestation.OPTIMUM);

            if (success)
            {
                GridViewTblMVA_FRH.EditIndex = -1;
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