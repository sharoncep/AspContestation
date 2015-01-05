using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contestation.Optimum
{
    public partial class Optimum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                drpPcpCounty.Items.Add("--Select--");
                List<pcpCounty> pcpCounty = new List<pcpCounty>();
                caseHandler getPcpCounty = new caseHandler();

                pcpCounty = getPcpCounty.getPcpCounty((int)_Contestation.OPTIMUM);

                drpPcpCounty.AppendDataBoundItems = true;
                drpPcpCounty.DataSource = pcpCounty;
                drpPcpCounty.DataTextField = "pcpNameCounty";
                drpPcpCounty.DataValueField = "pcpNameCounty";
                drpPcpCounty.DataBind();


            }
        }

        protected void drpPcpCounty_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<pcpNames> pcpNames = new List<pcpNames>();
            caseHandler getPcpName = new caseHandler();
            pcpNames = getPcpName.getPcpNames(drpPcpCounty.SelectedItem.ToString(), rbtnlstClaimType.SelectedItem.ToString(), (int)_Contestation.OPTIMUM);
            drpPcpName.Items.Clear();
            drpPcpName.Items.Add("--Select--");
            drpPcpName.AppendDataBoundItems = true;
            drpPcpName.DataSource = pcpNames;
            drpPcpName.DataTextField = "pcpName";
            drpPcpName.DataValueField = "pcpID";
            drpPcpName.DataBind();

        }

        protected void lnkBtnCase1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            int caseNo = Convert.ToInt32(Request.QueryString["id"]);
            if ((caseNo == 3 || caseNo == 4 || caseNo == 7 || caseNo == 8 || caseNo == 11) && rbtnlstClaimType.SelectedValue.Trim() == "INST")
            {
                lblMsg.Visible = true;
                rptrDataList.DataSource = null;
                rptrDataList.DataBind();

                lblMsg.Text = "Not applicable!";
            }
            else
            {
                List<contestationCases> lstCase = new List<contestationCases>();
                caseHandler getCases = new caseHandler();
                lstCase = getCases.getCaseDetails(caseNo, drpPcpName.SelectedValue.ToString(), drpPcpCounty.SelectedItem.ToString(), txtFrom.Text, txtTo.Text, rbtnlstClaimType.SelectedItem.ToString(), (int)_Contestation.OPTIMUM);

                if (lstCase.Count == 0)
                {
                    //ViewState["caseData"] = null;
                    lblMsg.Visible = true;
                    lblMsg.Text = "No records found!";
                    rptrDataList.Visible = true;
                    rptrDataList.DataSource = null;
                    rptrDataList.DataBind();
                }
                else
                {
                    lblMsg.Visible = false;
                    lblMsg.Text = "";
                    //ViewState["caseData"] = lstCase;
                    rptrDataList.Visible = true;
                    rptrDataList.DataSource = lstCase;
                    rptrDataList.DataBind();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //List<contestationCases> lstCase = ViewState["caseData"] as List<contestationCases>;
            int count = 0;
            caseHandler ResultHandler = new caseHandler();
            resultsObjects results = new resultsObjects();

            for (int i = 0; i < rptrDataList.Items.Count; i++)
            {
                CheckBox chk = (CheckBox)rptrDataList.Items[i].FindControl("chkSelect");
                if (chk.Checked)
                {
                    count++;

                    Label pcpID = (Label)rptrDataList.Items[i].FindControl("pcpID");
                    Label pcpName = (Label)rptrDataList.Items[i].FindControl("pcpName");
                    Label subscriberID = (Label)rptrDataList.Items[i].FindControl("subscriberID");
                    Label memberName = (Label)rptrDataList.Items[i].FindControl("memberName");
                    Label claimType = (Label)rptrDataList.Items[i].FindControl("claimType");
                    Label claimID = (Label)rptrDataList.Items[i].FindControl("claimID");
                    Label billTypePos = (Label)rptrDataList.Items[i].FindControl("billTypePos");
                    Label serviceCode = (Label)rptrDataList.Items[i].FindControl("serviceCode");
                    Label serviceBegin = (Label)rptrDataList.Items[i].FindControl("serviceBegin");
                    Label serviceEnd = (Label)rptrDataList.Items[i].FindControl("serviceEnd");
                    Label checkDate = (Label)rptrDataList.Items[i].FindControl("checkDate");
                    Label serviceCodeModi = (Label)rptrDataList.Items[i].FindControl("serviceCodeModi");
                    Label lineNo = (Label)rptrDataList.Items[i].FindControl("lineNo");
                    Label units = (Label)rptrDataList.Items[i].FindControl("units");
                    Label drgCode = (Label)rptrDataList.Items[i].FindControl("drgCode");
                    Label providerID = (Label)rptrDataList.Items[i].FindControl("providerID");
                    Label providerName = (Label)rptrDataList.Items[i].FindControl("providerName");
                    Label billedAmount = (Label)rptrDataList.Items[i].FindControl("billedAmount");
                    Label paidAmount = (Label)rptrDataList.Items[i].FindControl("paidAmount");
                    Label reason = (Label)rptrDataList.Items[i].FindControl("reason");

                    results.pcpID = pcpID.Text;
                    results.pcpName = pcpName.Text;
                    results.subscriberID = subscriberID.Text;
                    results.memberName = memberName.Text;
                    results.claimType = claimType.Text;
                    results.claimID = claimID.Text;
                    results.billTypePos = billTypePos.Text;
                    results.serviceCode = serviceCode.Text;
                    results.serviceBegin = serviceBegin.Text;
                    results.serviceEnd = serviceEnd.Text == "" ? null : serviceEnd.Text;
                    results.checkDate = checkDate.Text;
                    results.serviceCodeModi = serviceCodeModi.Text;
                    results.lineNo = lineNo.Text;
                    results.units = units.Text;
                    results.drgCode = drgCode.Text;
                    results.providerID = providerID.Text;
                    results.providerName = providerName.Text;
                    results.billedAmount = billedAmount.Text;
                    results.paidAmount = paidAmount.Text;
                    results.reason = reason.Text;

                    bool success = ResultHandler.insertResults(results, Session["username"].ToString(), Session["userid"].ToString(), (int)_Contestation.OPTIMUM);
                }
            }

            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + count.ToString() + " Record(s) saved successfully!');", true);

            loadData();
        }

    }


}