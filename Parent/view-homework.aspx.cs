using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parent_view_event : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemdethomework(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {


            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            lbltitle.Text = ds.Tables[0].Rows[0]["hw"].ToString();
            lbldate.Text = ds.Tables[0].Rows[0]["subject"].ToString();
            //    lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
            lbldescr.Text = ds.Tables[0].Rows[0]["class"].ToString();
            lblschool.Text = ds.Tables[0].Rows[0]["school"].ToString();

            msg.Text= ds.Tables[0].Rows[0]["pic"].ToString();
            if (msg.Text == "")
            {
                img.Visible = false;
                msgg.Text = "NO IMAGE AVAILABLE";
            }
            else
            {
                img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
                msgg.Visible = false;
                msg.Visible= false;
            }
        }
    }
}