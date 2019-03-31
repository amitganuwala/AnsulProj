using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class parent_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        //fillItem();

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

            // dss = sels.selectimesespt(Session["Parent_name"]);
            if (dss.Tables[0].Rows.Count == 1)
            {
                // lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                // lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
                lblstdnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblclass.Text = dss.Tables[0].Rows[0]["class"].ToString();
                img.ImageUrl = "~/Teacher/img/" + dss.Tables[0].Rows[0]["pic"].ToString();

                if (dss.Tables[0].Rows[0]["pic"].ToString() == "")
                {
                    img.Visible = false;
                }
                 
            }
        }
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Cookies["pnm"].Expires = DateTime.Now.AddDays(-1);
        Response.Redirect("~/Parentlogin.aspx");
        
    }
}
