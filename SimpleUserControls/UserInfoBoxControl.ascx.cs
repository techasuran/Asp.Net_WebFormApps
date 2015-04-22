using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleUserControls
{
    public partial class UserInfoBoxControl : System.Web.UI.UserControl
    {

        public string UserName { get; set; }
        public string UserCountry { get; set; }
        public int UserAge { get; set; }




        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}