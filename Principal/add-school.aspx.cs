using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class add_school : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         Sessioninfo();
       // displaypic();
    }
    public void Sessioninfo()
    {
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];


        if (myCookiepr != null)
        {

            string userId = myCookiepr["prnm"];

            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectprinci(userId);
            if (dss.Tables[0].Rows.Count == 1)
            {
                // lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
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

                Response.Redirect("../Principallogin.aspx");
            }
        }
    }

  
    protected void btnadd_Click(object sender, EventArgs e)
    {

        String photo = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Principal/img/" + photo));
        txtpic.Text = photo;

       
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spschoolupdt", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@school";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lblsch.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@pic";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txtpic.Text;
        objcom.Parameters.Add(objphoto);

        string message1 = " School Pic Updated Successfully...! ";
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