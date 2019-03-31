using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class School_fees_status : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
       // fillItem();
    }
    public void Sessioninfo()
    {
        HttpCookie myCookies = Request.Cookies["myCookies"];


        if (myCookies != null)
        {

            string userId = myCookies["snm"];

            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectschooladmn(userId);
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
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
        SqlConnection objcon = new SqlConnection(conn);
        objcon.Open();
        SqlCommand objcmd = new SqlCommand("spfeespay", objcon);
        objcmd.CommandType = CommandType.StoredProcedure;

        SqlParameter p2 = new SqlParameter();
        p2.ParameterName = "@name";
        p2.SqlDbType = SqlDbType.NVarChar;
        p2.Value = DropDownList2.SelectedValue;
        objcmd.Parameters.Add(p2);

        SqlParameter p3 = new SqlParameter();
        p3.ParameterName = "@class";
        p3.SqlDbType = SqlDbType.NVarChar;
        p3.Value = DropDownList1.SelectedValue;
        objcmd.Parameters.Add(p3);

        SqlParameter p4 = new SqlParameter();
        p4.ParameterName = "@type";
        p4.SqlDbType = SqlDbType.NVarChar;
        p4.Value = DropDownList3.SelectedValue;
        objcmd.Parameters.Add(p4);

        SqlParameter p1 = new SqlParameter();
        p1.ParameterName = "@school";
        p1.SqlDbType = SqlDbType.NVarChar;
        p1.Value = lblsch.Text;
        objcmd.Parameters.Add(p1);

        SqlParameter p6 = new SqlParameter();
        p6.ParameterName = "@fees";
        p6.SqlDbType = SqlDbType.NVarChar;
        p6.Value = gr.Rows[0].Cells[2].ToString();
        objcmd.Parameters.Add(p6);

        SqlParameter p5 = new SqlParameter();
        p5.ParameterName = "@adddt";
        p5.SqlDbType = SqlDbType.NVarChar;
        p5.Value = DateTime.Now.ToString("dd/MM/yyyy");
        objcmd.Parameters.Add(p5);

        SqlParameter p8 = new SqlParameter();
        p8.ParameterName = "@paidby";
        p8.SqlDbType = SqlDbType.NVarChar;
        p8.Value = paidby.Text;
        objcmd.Parameters.Add(p8);

        SqlParameter p9 = new SqlParameter();
        p9.ParameterName = "@date";
        p9.SqlDbType = SqlDbType.NVarChar;
        p9.Value = subdate.Text;
        objcmd.Parameters.Add(p9);

        SqlParameter p10 = new SqlParameter();
        p10.ParameterName = "@recieved";
        p10.SqlDbType = SqlDbType.NVarChar;
        p10.Value = lbltchnm.Text;
        objcmd.Parameters.Add(p10);

        SqlParameter p11 = new SqlParameter();
        p11.ParameterName = "@";
        p11.SqlDbType = SqlDbType.NVarChar;
        p11.Value = paidby.Text;
        objcmd.Parameters.Add(p11);

        string message1 = "Fees Status Added Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        objcmd.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();
    }
}
