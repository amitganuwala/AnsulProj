using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class parent_course : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();

    ClsGlobal glb = new ClsGlobal();

    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
    }

    public void Sessioninfo()
    {

        HttpCookie myCookiep = Request.Cookies["myCookiep"];


        if (myCookiep != null)
        {

            string userId = myCookiep["pnm"];

            //Select sels = new Select();
            //dss = sels.selectimesespt(userId);

            string sql = "select * from parent where usr='" + userId + "' ";
            dss = glb.GetDataSet(sql);

            if (dss.Tables[0].Rows.Count == 1)
            {
                lblstdnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
                //           lblstdnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
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
        string sql ="SELECT * FROM [course] WHERE (([class] = '"+lblclass.Text+"') AND ([school] = '"+lblsch.Text+"'))";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }

}