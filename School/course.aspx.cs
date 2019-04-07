using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pr_list : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();

    ClsGlobal glb = new ClsGlobal();

    protected void Page_Load(object sender, EventArgs e)
    {
        
           Sessioninfo();
           //fillItem();
    }
    public void Sessioninfo()
    {
        HttpCookie myCookies = Request.Cookies["myCookies"];


        if (myCookies != null)
        {

            string userId = myCookies["snm"];

            //Select sels = new Select();
            //dss = sels.selectschooladmn(userId);

            string sql = "select * from schooladmin where usr='" + userId + "' ";
            dss = glb.GetDataSet(sql);

            if (dss.Tables[0].Rows.Count == 1)
            {
                lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
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

                Response.Redirect("../Schooladminlogin.aspx");
            }

            fillGridView1();
        }
    }

    public void fillGridView1()
    {
        string sql = "SELECT * FROM [course] WHERE ([school] = '"+lblsch.Text+"') ORDER BY [id] DESC";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }

}