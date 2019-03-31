using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_event_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
           fillItem();
    }

    public void fillItem()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemtrip();
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();
    
    }
}