﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entities;

namespace Contestation.Optimum
{
    public partial class tblContFrdmCapitatedProvidersAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            tableHandler insertHandler = new tableHandler();
            TableContFrdmCapitatedProviders ContFrdmCapitatedProviders = new TableContFrdmCapitatedProviders();

            ContFrdmCapitatedProviders.CapitatedProviders = txtCapProv.Text;
            ContFrdmCapitatedProviders.ProviderID = txtProviderID.Text;
            ContFrdmCapitatedProviders.PlanNumber = txtPlanNo.Text;
            ContFrdmCapitatedProviders.IPAName = txtIPAName.Text;
            ContFrdmCapitatedProviders.PlanName = txtPlanName.Text;
            ContFrdmCapitatedProviders.From_Date = txtFromDate.Text == "" ? null : txtFromDate.Text;
            ContFrdmCapitatedProviders.To_Date = txtToDate.Text == "" ? null : txtToDate.Text;
            ContFrdmCapitatedProviders.Speciality_name = txtSpecName.Text;
            ContFrdmCapitatedProviders.Speciality_fund = txtSpecFund.Text;

            bool success = insertHandler.InsertContFrdmCapitatedProviders(ContFrdmCapitatedProviders, (int)_Contestation.OPTIMUM);

            if (success)
            {
                Response.Redirect("tblContFrdmCapitatedProviders.aspx");
            }

        }

    }
}