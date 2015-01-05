using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOpenXml;

namespace Contestation.Optimum
{
    public partial class OptimumResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<resultsObjects> lstResult = new List<resultsObjects>();

            resultHandler getResult = new resultHandler();

            if (rbtnSearch.SelectedValue == "all")
                lstResult = getResult.getResultDetails(null, null, (int)_Contestation.OPTIMUM);
            else
                lstResult = getResult.getResultDetails(txtFrom.Text, txtTo.Text, (int)_Contestation.OPTIMUM);

            //DataTable dt = Database.ExecuteStoredProcedure("usp_contestation_freedom_case1", parameters);
            if (lstResult.Count > 0)
            {
                //rptrDataList.Visible = true;
                Label1.Visible = false;
                rptrDataList.DataSource = lstResult;
                rptrDataList.DataBind();
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "No Data Found !";
                rptrDataList.DataSource = null;
                rptrDataList.DataBind();
                //rptrDataList.Visible = false;
            }
        }

        protected void btnExcelUpload_Click(object sender, EventArgs e)
        {
            DataTable dtResult = new DataTable();

            resultHandler getResult = new resultHandler();

            if (rbtnSearch.SelectedValue == "all")
                dtResult = getResult.getExcelResultDetails(null, null, (int)_Contestation.OPTIMUM);
            else
                dtResult = getResult.getExcelResultDetails(txtFrom.Text, txtTo.Text, (int)_Contestation.OPTIMUM);

            //DataTable dt = Database.ExecuteStoredProcedure("usp_contestation_freedom_case1", parameters);
            if (dtResult != null)
            {
                String FileName = string.Concat("FreedomResult_", DateTime.Now.ToString().Replace(":", string.Empty).Replace("/", string.Empty).Replace(" ", string.Empty));

                //String FilePath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Freedom\\FREEDOM_RESULT_EXCEL_FILES\\", FileName);
                String FilePath = string.Concat(System.IO.Path.GetTempPath(), FileName);
                //CreateExcelFile.CreateExcelDocument(lstResult, FilePath);
                string imagePath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Images\\optimum.jpg");
                string excelFile = CreateExcelClass.CreateSheet("Optimum", dtResult, FilePath, imagePath);

                System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
                response.ClearContent();
                response.Clear();
                response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                //response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                response.AddHeader("Content-Disposition", "attachment; filename=" + FileName + ";");
                response.TransmitFile(excelFile);
                response.Flush();
                response.End();
            }
        }
    }
}