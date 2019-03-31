using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class parent_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        fillItem();
        if (img.ImageUrl == "")
        {
            img.Visible = false;
        }
        else if (img.ImageUrl == null)
        {
            img.Visible = false;
        }
    }
    public void Sessioninfo()
    {

        HttpCookie myCookiep = Request.Cookies["myCookiep"];


        if (myCookiep != null)
        {

            string userId = myCookiep["pnm"];

            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectimesespt(userId);

            if (dss.Tables[0].Rows.Count == 1)
            {
                // lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
                lblstdnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblclass.Text = dss.Tables[0].Rows[0]["class"].ToString();



                DataSet dso = new DataSet();
                Select slo = new Select();
                dso = slo.schoolpic(lblsch.Text);
                if (dso.Tables[0].Rows.Count == 1)
                {
                    img.ImageUrl = "~/Principal/img/" + dso.Tables[0].Rows[0]["pic"].ToString();
                }
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

                Response.Redirect("../Parentlogin.aspx");
            }
        }
    }


    public void fillItem()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemnotice(lblsch.Text,lblclass.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();

        DataSet ds1 = new DataSet();
        Select sel1 = new Select();
        ds1 = sel1.selectitemhomwk(lblsch.Text, lblclass.Text);
        rptitem1.DataSource = ds1.Tables[0];
        rptitem1.DataBind();
       

        DataSet ds2 = new DataSet();
        Select sel2 = new Select();
        ds2 = sel2.selectitemevent(lblsch.Text);
        rptitem2.DataSource = ds2.Tables[0];
        rptitem2.DataBind();
       
       
    }
}