using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class School_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        ViewProfile();

        if (lblclass.Text == "All")
        {
            GridView1.Visible = false;
            GridView2.Visible = true;
        }
        else
        {
            GridView2.Visible = false;
            GridView1.Visible = true;
        }

    }
    public void Sessioninfo()
    {
        HttpCookie myCookies = Request.Cookies["myCookies"];


        if (myCookies != null)
        {

            string userId = myCookies["snm"];

            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectschooladmn(userId);
            // dss = sels.selectschooladmn(Session["Schooladmin_name"]);
            if (dss.Tables[0].Rows.Count == 1)
            {
                // lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
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

                Response.Redirect("../Schooladminlogin.aspx");
            }
        }
    }
    public void ViewProfile()
    {
        //DataSet ds = new DataSet();
        //Select sel = new Select();
        //ds = sel.selectitemdet((Request.QueryString["class"].ToString()));
        //if (ds.Tables[0].Rows.Count == 1)
        //{
        //    lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
        //}
    }
   
}