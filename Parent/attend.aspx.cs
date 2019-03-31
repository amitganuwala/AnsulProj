using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class arent_att : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Sessioninfo();
        dt.Text = Calendar1.SelectedDate.ToString("dd-MM-yyyy");
        show();
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

    public void show()
    {
        

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        dt.Text = Calendar1.SelectedDate.ToString("dd-MM-yyyy");

        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectpatt(lblstdnm.Text,lblclass.Text, lblsch.Text,dt.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();

        DataSet ds1 = new DataSet();
        Select sel1 = new Select();
        ds1 = sel1.selectplv(lblstdnm.Text,lblclass.Text, lblsch.Text);
        DataList1.DataSource = ds1.Tables[0];
        DataList1.DataBind();

        DataSet ds2 = new DataSet();
        Select sel2 = new Select();
        ds2 = sel2.selectplvap(lblstdnm.Text, lblclass.Text, lblsch.Text);
        DataList2.DataSource = ds2.Tables[0];
        DataList2.DataBind();

       
    }
}