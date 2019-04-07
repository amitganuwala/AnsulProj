using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class School_student : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();

    ClsGlobal glb = new ClsGlobal();


    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();

        if (lblclass.Text == "All")
        {
            GridView1.Visible = false;
            GridView2.Visible = true;
        }
        else
        {
            GridView1.Visible = true;
            GridView2.Visible = false;
        }
    }

    public void ViewProfile()
    {
        HttpCookie myCookies = Request.Cookies["myCookies"];


        if (myCookies != null)
        {

            string userId = myCookies["snm"];

            //Select sels = new Select();
            //ds = sels.selectitemdet(Convert.ToInt32(Request.QueryString["id"].ToString()));


            string sql = "select * from classsection where id='" + Convert.ToInt32(Request.QueryString["id"].ToString()) + "'";
            ds = glb.GetDataSet(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
                lblsch.Text = ds.Tables[0].Rows[0]["school"].ToString();

                fillGridView1();
                fillGridView2();

            }
        }
    }


    public void fillGridView1()
    {
        string sql = "SELECT [name], [roll], [class], [sgen], [school], [pname], [usr], [pass], [mob] FROM [parent] WHERE (([class] = '"+lblclass.Text+"') AND ([school] = '"+lblsch.Text+"')) ORDER BY [name]";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }

    public void fillGridView2()
    {
        string sql = "SELECT [name], [roll], [class], [sgen], [school], [pname], [usr], [pass], [mob] FROM [parent] WHERE ([school] = '"+lblsch.Text+"') ORDER BY [name],[class]";
        dss2 = glb.GetDataSet(sql);
        GridView2.DataSource = dss2;
        GridView2.DataBind();
    }
}