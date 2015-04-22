using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleUserControls.Controls
{
    public partial class Stock : System.Web.UI.UserControl
    {


        public string Name { get; set; }
        public int CurrentPrice { get; set; }
        public string Category { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}