using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Cookies["prnm"].Expires = DateTime.Now.AddDays(-1);
        Response.Redirect("~/Teacherlogin.aspx");

    }
}
