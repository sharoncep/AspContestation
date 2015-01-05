using System;
using System.Web;
using System.Web.Security;
using System.Web.UI.WebControls;
using BLL;
using Encryption;
using Entities;

namespace Contestation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //contestationCases cases = new contestationCases();

            //caseHandler caseHandler = new caseHandler();

            //caseHandler.getCaseDetails(1);

        }


        /// <summary>
        /// Fires when Login button will be clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            AuthenticateHandler auth = new AuthenticateHandler();
            authenticateUser authUser = new authenticateUser();
            authUser = auth.getUserDetails(Login1.UserName, encryptSHA1.GetSHA1HashData(Login1.Password));

            if (authUser != null)
            {
                Session["userid"] = authUser.userID;
                Session["username"] = Login1.UserName;

                // Create forms authentication ticket

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket
                    (
                        1 // Ticket version
                        ,
                        Login1.UserName // Username to be associated with this ticket
                        ,
                        DateTime.Now // Date/time ticket was issued
                        ,
                        DateTime.Now.AddMinutes(50) // Date and time the cookie will expire
                        ,
                        Login1.RememberMeSet // if user has chcked rememebr me then create persistent cookie
                        ,
                        authUser.role // store the user data, in this case roles of the user
                        ,
                        FormsAuthentication.FormsCookiePath // Cookie path specified in the web.config file in <Forms> tag if any.
                     );

                // To give more security it is suggested to hash it

                string hashCookies = FormsAuthentication.Encrypt(ticket);

                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashCookies); // Hashed ticket

                // Add the cookie to the response, user browser

                Response.Cookies.Add(cookie);

                // Get the requested page from the url

                string returnUrl = Request.QueryString["ReturnUrl"];

                // check if it exists, if not then redirect to default page

                if (returnUrl == null) returnUrl = "~/Home.aspx";

                Response.Redirect(returnUrl);

                //FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click1(object sender, EventArgs e)
        {

        }
    }
}