using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_student : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();

    ClsGlobal glb = new ClsGlobal();
    SqlConnection conn = new SqlConnection(ClsVariable.ConnectionString);
    SqlCommand cmd = new SqlCommand();


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
        HttpCookie myCookiet = Request.Cookies["myCookiet"];


        if (myCookiet != null)
        {

            string userId = myCookiet["tnm"];

            string sql = "select * from classsection where id='" + Convert.ToInt32(Request.QueryString["id"].ToString()) + "'";
            ds = glb.GetDataSet(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
                lblsch.Text = ds.Tables[0].Rows[0]["school"].ToString();
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

                Response.Redirect("../Teacherlogin.aspx");
            }

            if (!IsPostBack)
            {
                fillGridView2(lblsch.Text);
                fillGridView1(lblclass.Text, lblsch.Text);

            }
        }
    }

    public void fillGridView2(string school_nm)
    {
        string sql = "SELECT [name], [roll], [class], [sgen], [school], [pname], [usr], [pass], [mob] FROM [parent] WHERE ([school] = '"+school_nm+"') ORDER BY [name]";
        dss2 = glb.GetDataSet(sql);
        GridView2.DataSource = dss2;
        GridView2.DataBind();
    }

    public void fillGridView1(string class_nm, string school_nm)
    {
        string sql = "SELECT [name], [roll], [class], [sgen], [school], [pname], [usr], [pass], [mob] FROM [parent] WHERE (([class] = '"+class_nm+"') AND ([school] = '"+school_nm+"')) ORDER BY [name]";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }
}