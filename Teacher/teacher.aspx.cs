using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_teacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         ViewProfile();
         fillItem();
    }

    public void fillItem()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemsub(lblname.Text,lblsch.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();
    }

    public void ViewProfile()
    {
        HttpCookie myCookiet = Request.Cookies["myCookiet"];


        if (myCookiet != null)
        {

            string userId = myCookiet["tnm"];
            
            DataSet ds = new DataSet();
            Select sels = new Select();
            ds = sels.selectimeses(userId);
            if (ds.Tables[0].Rows.Count == 1)
            {
                lblsch.Text = ds.Tables[0].Rows[0]["school"].ToString();
                lblname.Text = ds.Tables[0].Rows[0]["name"].ToString();
                lblpost.Text = ds.Tables[0].Rows[0]["post"].ToString();
                lbladdr.Text = ds.Tables[0].Rows[0]["addr"].ToString();
                lblmob.Text = ds.Tables[0].Rows[0]["mob"].ToString();
                id.Text = ds.Tables[0].Rows[0]["id"].ToString();
                img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
                lblusr.Text = ds.Tables[0].Rows[0]["usr"].ToString();
                lblpass.Text = ds.Tables[0].Rows[0]["pass"].ToString();
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

                Response.Redirect("../Teacherlogin.aspx");
            }

        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("update.aspx");
    }
}