using System;
using System.Collections.Generic;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_event_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
           Sessioninfo();
           fillItem();
    }
    public void Sessioninfo()
    {
        DataSet dss = new DataSet();
        Select sels = new Select();
        dss = sels.selectimesespt(Session["Parent_name"]);
        if (dss.Tables[0].Rows.Count == 1)
        {
            lblclass.Text = dss.Tables[0].Rows[0]["class"].ToString();
            lblschnm.Text = dss.Tables[0].Rows[0]["stu"].ToString();
            lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
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

    public void fillItem()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemparevent(lblsch.Text,lblclass.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();
    
    }
}