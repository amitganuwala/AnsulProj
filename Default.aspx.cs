using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsVariable.ConnectionString = "Data Source=DESKTOP-54TBQHS\\SQL2014;Persist Security Info=True;Initial Catalog=school_mate;User ID=sa;Password=mit";
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Principallogin.aspx");
    }
    protected void btnn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Teacherlogin.aspx");
    }
    protected void btnnn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Parentlogin.aspx");
    }
    protected void btnnnn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Schooladminlogin.aspx");
    }
}