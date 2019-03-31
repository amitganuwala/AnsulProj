using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Principal_zoom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         ViewProfile();
         View();
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.picsingle(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
            img.ImageUrl = "~/Teacher/pic/" + ds.Tables[0].Rows[0]["pic"].ToString();
            //imgname.Text = ds.Tables[0].Rows[0]["photo"].ToString();
            lblid.Text = ds.Tables[0].Rows[0]["eid"].ToString();
        }
    }

    public void View()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.picdet(lblid.Text);
        if (ds.Tables[0].Rows.Count == 1)
        {
            //img.ImageUrl = "~/Teacher/pic/" + ds.Tables[0].Rows[0]["pic"].ToString();
            lblhead.Text = ds.Tables[0].Rows[0]["title"].ToString();
            description.Text = ds.Tables[0].Rows[0]["descr"].ToString();
        }
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Parent/gal.aspx");
    }
}