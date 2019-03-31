using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        String photo = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Principal/img/" + photo));
        txtpic.Text = photo;


        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spschoolinfo", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@schoolname";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = txtnm.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmaint = new SqlParameter();
        objmaint.ParameterName = "@addr";
        objmaint.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaint.Value = txtaddr.Text;
        objcom.Parameters.Add(objmaint);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@pic";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txtpic.Text;
        objcom.Parameters.Add(objphoto);

        string message1 = " School Added Successfully...! ";
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