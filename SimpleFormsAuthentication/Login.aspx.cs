using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleFormsAuthentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (txtUserName.Text == "user" && txtPwd.Text == "pwd")
            {

                //ideally FormsAuthentication.RedirectFromLoginPage  should work 
                // but it here its not redirecting retirnurl is coming as %2f when it is hosted 

                //FormsAuthentication.RedirectFromLoginPage("user", false);
                //FormsAuthentication.SetAuthCookie("user", false);

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "user",
                    DateTime.Now,
                    DateTime.Now.AddSeconds(30),
                    false,
                    "userdata",
                    FormsAuthentication.FormsCookiePath
                    );

                string encryptedTicket = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket));

                Response.Redirect(Request["ReturnUrl"] == "/"? "~/PersonalDetails.aspx":"");
            }

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
           
        }

      
       
    }
}