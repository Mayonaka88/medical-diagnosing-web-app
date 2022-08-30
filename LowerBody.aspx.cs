using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LowerBody : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Questions.aspx?userCounter=" + 79);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Questions.aspx?userCounter=" + 74);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Questions.aspx?userCounter=" + 56);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Questions.aspx?userCounter=" + 69);
        }
    }
}