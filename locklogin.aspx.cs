using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class locklogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "Principal")
        {
            Response.Redirect("Principallogin.aspx");

        }
        else if (DropDownList1.SelectedValue == "Teacher")
        {
            Response.Redirect("Teacherlogin.aspx");
        }
        else if (DropDownList1.SelectedValue == "Parent")
        {
            Response.Redirect("Parentlogin.aspx");
        }
        else
        {
            Response.Redirect("Schooladminlogin.aspx");
        }
    }
}