using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class parent_fees_info : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo(); 
        fillItem();
         
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
                lblstdnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
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

                Response.Redirect("../locklogin.aspx");
            }
        }
    }
    public void fillItem()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemparfees(lblsch.Text, lblclass.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();
        
     
            
    }
    
}