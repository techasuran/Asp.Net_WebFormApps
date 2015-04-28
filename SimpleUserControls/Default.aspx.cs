using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleUserControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie MyCookie = new HttpCookie("LastVisit");
            DateTime now = DateTime.Now;

            MyCookie.Value = now.ToString();

            Response.Cookies["CityName"].Value = "London";

            Response.Cookies.Add(MyCookie);
        }
    }
}