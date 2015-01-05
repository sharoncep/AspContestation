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
    public partial class tblModifierListPaymentAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            tableHandler insertHandler = new tableHandler();
            TableModifierListPayment ModifierListPayment = new TableModifierListPayment();

            ModifierListPayment.Modifier = txtModifier.Text;
            ModifierListPayment.Allowance = txtAllowance.Text;

            bool success = insertHandler.InsertModifierListPayment(ModifierListPayment, (int)_Contestation.FREEDOM);

            if (success)
            {
                Response.Redirect("tblModifierListPayment.aspx");
            }
            //lblMessage.Text = "Record inserted successfully!";

        }
    }
}