using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPTEST
{
    public partial class validateform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Response.Redirect("valid.html");
            }
            else
            {
                Response.Write("Something went rong");
            }
        }
    }
}