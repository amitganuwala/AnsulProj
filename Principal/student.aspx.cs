using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();

        if (lblclass.Text == "All")
        {
            GridView1.Visible = false;
            GridView2.Visible = true;
        }
        else
        {
            GridView1.Visible = true;
            GridView2.Visible = false;
        }
    }

    public void ViewProfile()
    {
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];


        if (myCookiepr != null)
        {

            string userId = myCookiepr["prnm"];

            DataSet ds = new DataSet();
            Select sels = new Select();
            ds = sels.selectitemdet(Convert.ToInt32(Request.QueryString["id"].ToString()));
            if (ds.Tables[0].Rows.Count == 1)
            {
                lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
                lblsch.Text = ds.Tables[0].Rows[0]["school"].ToString();
            }
        }
    }
}