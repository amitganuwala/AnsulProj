using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Principal_unapprove : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         Sessioninfo();
        // displaypic();
          fillItem();
          fillItem1();
          fillItem2();
    }
    public void Sessioninfo()
    {
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];


        if (myCookiepr != null)
        {

            string userId = myCookiepr["prnm"];

            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectprinci(userId);
            if (dss.Tables[0].Rows.Count == 1)
            {
                // lblprinm.Text = dss.Tables[0].Rows[0]["namr"].ToString();
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
    }

    public void fillItem()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectapphw(lblsch.Text);
        DataList2.DataSource = ds.Tables[0];
        DataList2.DataBind();
    
    }
    public void fillItem1()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectappno(lblsch.Text);
        DataList1.DataSource = ds.Tables[0];
        DataList1.DataBind();

    }
    public void fillItem2()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectappev(lblsch.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();

    }
}