using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_view_event : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();
        fill();

    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemdetevent(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
            img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
            if (ds.Tables[0].Rows[0]["pic"].ToString() == "")
            {
                img.Visible = false;
                lb.Text = "No Image Available";
            }
            else
            {
                img.Visible = true;
                lb.Visible = false;
            }
                
            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            lbltitle.Text = ds.Tables[0].Rows[0]["title"].ToString();
            lbldate.Text = ds.Tables[0].Rows[0]["date"].ToString();
            //    lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
            lbldescr.Text = ds.Tables[0].Rows[0]["descr"].ToString();
           // lblschool.Text = ds.Tables[0].Rows[0]["school"].ToString();
        }
    }

    public void fill()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectgallery(lblid.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();

    }
}