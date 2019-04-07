using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class parent_att : System.Web.UI.Page
{
    ClsGlobal glb = new ClsGlobal();
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();


    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        // fillItem();
        int i = 0;
        for (i = 0; i < GridView1.Rows.Count; i++)
        {
            if (GridView1.Rows[i].Cells[3].Text == "Present")
            {
                GridView1.Rows[i].BackColor = System.Drawing.Color.LightGreen;
            }
            else if (GridView1.Rows[i].Cells[3].Text == "Absent")
            {
                GridView1.Rows[i].BackColor = System.Drawing.Color.PeachPuff;
            }
        }

    }
    public void Sessioninfo()
    {
        HttpCookie myCookiep = Request.Cookies["myCookiep"];


        if (myCookiep != null)
        {

            string userId = myCookiep["pnm"];

            string sql = "select * from parent where usr='" + userId + "' ";

            dss = glb.GetDataSet(sql);


            if (dss.Tables[0].Rows.Count == 1)
            {
                // lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
                lblstdnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblclass.Text = dss.Tables[0].Rows[0]["class"].ToString();

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

                Response.Redirect("../Parentlogin.aspx");

            }

            fillGridView();

        }


    }


    public void fillGridView()
    {
        string sql = "SELECT [name], [class], [date], [status] FROM [attendance] WHERE (([class] = '"+lblclass.Text+"') AND ([school] = '"+lblsch.Text+"') AND ([name] = '"+lblstdnm.Text+"')) ORDER BY [date] DESC";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }
}