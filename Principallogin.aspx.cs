using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{

    ClsGlobal glb = new ClsGlobal();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
       

        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        
        //string conn = ConfigurationManager.ConnectionStrings["Data Source=intel-pc\\sqlexpress;Initial Catalog=rentshopee;Integrated Security=True"].ConnectionString;
      
        objcon.Open();

        SqlCommand objcmd = new SqlCommand("spprlogin", objcon);
        objcmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@usr";
        objname.SqlDbType = SqlDbType.VarChar;
        objname.Value = txtname.Text;
        objcmd.Parameters.Add(objname);

        SqlParameter pwd = new SqlParameter();
        pwd.ParameterName = "@pass";
        pwd.SqlDbType = SqlDbType.VarChar;
        pwd.Value = txtpass.Text;
        objcmd.Parameters.Add(pwd);
                                 SqlDataReader objreader = objcmd.ExecuteReader();
        if (objreader.Read() == true)
        {

            Session["Principal_name"] = txtname.Text;

            FormsAuthentication.RedirectFromLoginPage(txtname.Text, check.Checked);

            //create a cookie
            HttpCookie myCookiepr = new HttpCookie("myCookiepr");

            //Add key-values in the cookie
            myCookiepr["prnm"] = txtname.Text;
            myCookiepr["prps"] = txtpass.Text;

            //set cookie expiry date-time. Made it to last for next 12 hours.
            myCookiepr.Expires = DateTime.Now.AddMonths(3);

            //Most important, write the cookie to client.
            Response.Cookies.Add(myCookiepr);
           
            string sql3 = "select namr,school from principal where usr = '" + txtname.Text + "'";
            DataSet ds = new DataSet();
            ds = glb.GetDataSet(sql3);
            GridView1.DataSource = ds;
            GridView1.DataBind();


            SqlConnection objcon1 = new SqlConnection(ClsVariable.ConnectionString); 
            objcon1.Open();

            SqlCommand objcmd1 = new SqlCommand("splogindet", objcon1);
            objcmd1.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter objname1 = new SqlParameter();
            objname1.ParameterName = "@name";
            objname1.SqlDbType = SqlDbType.VarChar;
            objname1.Value = GridView1.Rows[0].Cells[0].Text;
            objcmd1.Parameters.Add(objname1);

            SqlParameter pwd1 = new SqlParameter();
            pwd1.ParameterName = "@school";
            pwd1.SqlDbType = SqlDbType.VarChar;
            pwd1.Value = GridView1.Rows[0].Cells[1].Text;
            objcmd1.Parameters.Add(pwd1);
            string pr = "Principal";
            SqlParameter objname11 = new SqlParameter();
            objname11.ParameterName = "@type";
            objname11.SqlDbType = SqlDbType.VarChar;
            objname11.Value = pr.ToString();
            objcmd1.Parameters.Add(objname11);

            SqlParameter pwd11 = new SqlParameter();
            pwd11.ParameterName = "@time";
            pwd11.SqlDbType = SqlDbType.VarChar;
            pwd11.Value = System.DateTime.Now.ToString();
            objcmd1.Parameters.Add(pwd11);

            objcmd1.ExecuteNonQuery();
            // Response.Write("Created Successfully");
            objcon1.Close();

            Response.Redirect("~/Principal/Default.aspx");
   

        }
        else
        {
            string message1 = "Your details not matched.";
            string script = "window.onload = function(){ alert('";
            script += message1;
            script += "');";
            script += "window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }

    }
}