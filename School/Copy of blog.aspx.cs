using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class School_blog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fill();
    }
    public void fill()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectblogin();
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();
    
    }
   
}