using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_attendance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
    }
    public void Sessioninfo()
    {
        DataSet dss = new DataSet();
        Select sels = new Select();
        dss = sels.selectstu(Session["Parent_name"]);
        if (dss.Tables[0].Rows.Count == 1)
        {
          //  lbltchnm.Text = dss.Tables[0].Rows[0]["stu"].ToString();
            lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
           // lbl.Text = dss.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            string message1 = "Login Session Expired....Please Login again.";
            string script = "window.onload = function(){ alert('";
            script += message1;
            script += "');";
            script += "window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

            Response.Redirect("../locklogin.aspx");
        }
    }
    
  
}