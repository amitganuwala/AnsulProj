using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Principal_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spprinci", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@name";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = txtnm.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmaint = new SqlParameter();
        objmaint.ParameterName = "@usr";
        objmaint.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaint.Value = txtusr.Text;
        objcom.Parameters.Add(objmaint);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@pass";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txtpass.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter ophoto = new SqlParameter();
        ophoto.ParameterName = "@school";
        ophoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        ophoto.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(ophoto);


        string message1 = " Principal Added Successfully...! ";
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spschooladmin", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@name";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = txtsnm.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmaint = new SqlParameter();
        objmaint.ParameterName = "@usr";
        objmaint.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaint.Value = txtsusr.Text;
        objcom.Parameters.Add(objmaint);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@pass";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txtspass.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter ophoto = new SqlParameter();
        ophoto.ParameterName = "@school";
        ophoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        ophoto.Value = DropDownList2.SelectedValue;
        objcom.Parameters.Add(ophoto);


        string message1 = " School Admin Added Successfully...! ";
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