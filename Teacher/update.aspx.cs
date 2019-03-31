using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
    }
    public void Sessioninfo()
    {
        HttpCookie myCookiet = Request.Cookies["myCookiet"];


        if (myCookiet != null)
        {

            string userId = myCookiet["tnm"];
            
            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectimeses(userId);
            if (dss.Tables[0].Rows.Count == 1)
            {
                lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
                lblid.Text = dss.Tables[0].Rows[0]["id"].ToString();
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

        }
    }
    protected void btnpic_Click(object sender, EventArgs e)
    {

        String photo = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Teacher/img/" + photo));
        txtpic.Text = photo;

       SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
           //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("sppic", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@id";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lblid.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@pic";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = txtpic.Text;
        objcom.Parameters.Add(objpho);

        string message1 = " Photo Updated Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();

    }
    protected void btnpass_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //   SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spusr", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@id";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lblid.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmaint = new SqlParameter();
        objmaint.ParameterName = "@usr";
        objmaint.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaint.Value = txtusr.Text;
        objcom.Parameters.Add(objmaint);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@pass";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = txtpass.Text;
        objcom.Parameters.Add(objpho);

        string message1 = " User Id and Password Updated Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //   SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spaddr", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@id";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lblid.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@addr";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = txtaddr.Text;
        objcom.Parameters.Add(objpho);

        string message1 = " Address Updated Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();

    }
    protected void btnmob_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //   SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spmob", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@id";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lblid.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@mob";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = txtmob.Text;
        objcom.Parameters.Add(objpho);

        string message1 = " Mobile no. Updated Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();

    }
}