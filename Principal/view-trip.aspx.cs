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
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemdettrip(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
           // img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            lbltitle.Text = ds.Tables[0].Rows[0]["title"].ToString();
            lbldate.Text = ds.Tables[0].Rows[0]["datefr"].ToString();
            lbldtl.Text=ds.Tables[0].Rows[0]["datetl"].ToString();
            lblplace.Text = ds.Tables[0].Rows[0]["place"].ToString();
            lblday.Text = ds.Tables[0].Rows[0]["days"].ToString();
            //    lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
            lbldescr.Text = ds.Tables[0].Rows[0]["descr"].ToString();
            lblschool.Text = ds.Tables[0].Rows[0]["school"].ToString();
        }
    }
}