using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Principal_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        fill();
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

                Response.Redirect("../Principallogin.aspx");
            }
        }
    }

    public void fill()
    {
        string date = System.DateTime.Now.ToString("dd/MM/yyyy");
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.prhome(lblsch.Text, date.ToString());
        listhomework.DataSource = ds.Tables[0];
        listhomework.DataBind();

        DataSet ds1 = new DataSet();
        Select sel1 = new Select();
        ds1 = sel1.prnotice(lblsch.Text, date.ToString());
        listnotice.DataSource = ds1.Tables[0];
        listnotice.DataSource = ds1.Tables[0];
        listnotice.DataBind();
 
        DataSet ds2 = new DataSet();
        Select sel2 = new Select();
        ds2 = sel2.prevent(lblsch.Text, date.ToString());
        listevents.DataSource = ds2.Tables[0];
        listevents.DataBind();

        DataSet ds3 = new DataSet();
        Select sel3 = new Select();
        ds3 = sel3.prcourse(lblsch.Text, date.ToString());
        listtimetable.DataSource = ds3.Tables[0];
        listtimetable.DataBind();

    }
}