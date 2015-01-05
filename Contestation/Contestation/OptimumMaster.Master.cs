using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contestation
{
    public partial class OptimumMaster : System.Web.UI.MasterPage
    {
        /// <summary>
        /// http://webnetrevolution.blogspot.in/2011/05/handling-logout-in-form-based.html
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
        }

        protected void btnLogout_Click1(object sender, EventArgs e)
        {
            logoutAll();
        }

        protected void logoutAll()
        {
            Session.Clear();                                 //this will clear session
            Session.Abandon();                          //this will Abandon session
            FormsAuthentication.SignOut();
            Response.Cache.SetExpires(DateTime.Now);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            //FormsAuthentication.RedirectToLoginPage();
            Response.Redirect("~/Login.aspx");
        }

    }
}