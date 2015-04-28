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
                FormsAuthentication.RedirectFromLoginPage("user", false);
            }

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //if (Login1.UserName == "user" && Login1.Password == "pwd")
            //{
            //    if (Request.QueryString["ReturnURL"] != "/")
            //    {


            //        FormsAuthentication.RedirectFromLoginPage("user", false);

            //    }
            //    else
            //    {
            //        FormsAuthentication.SetAuthCookie("user", false);
            //        Response.Redirect("~/");
            //    }
            //}


           






        }

      
       
    }
}