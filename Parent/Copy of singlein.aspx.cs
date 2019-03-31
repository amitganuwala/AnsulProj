using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class pr_single : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.singlenews(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
            img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            title.Text = ds.Tables[0].Rows[0]["title"].ToString();
            date.Text = ds.Tables[0].Rows[0]["date"].ToString();
            school.Text = ds.Tables[0].Rows[0]["school"].ToString();
            descr.Text = ds.Tables[0].Rows[0]["msg"].ToString();
            tchnm.Text = ds.Tables[0].Rows[0]["addnm"].ToString();
            //subject.Text = ds.Tables[0].Rows[0]["subject"].ToString();
           // string a = ds.Tables[0].Rows[0]["pic"].ToString();
            if (ds.Tables[0].Rows[0]["pic"].ToString() == "")
            {
                img.Visible = false;
                st.Visible = true;
                st.Text = "NO IMAGE AVAILABLE...";
            }
        }
    }
    
}