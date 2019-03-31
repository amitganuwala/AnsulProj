using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HOD_addteacher : System.Web.UI.Page
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
                // lblprinm.Text = dss.Tables[0].Rows[0]["namr"].ToString();
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
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
      //  SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spteacher", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@name";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = txtname.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@addr";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = txtaddr.Text;
        objcom.Parameters.Add(objname);
        string a = "";
        SqlParameter obame = new SqlParameter();
        obame.ParameterName = "@pic";
        obame.SqlDbType = System.Data.SqlDbType.NVarChar;
        obame.Value = a.ToString();
        objcom.Parameters.Add(obame);

        SqlParameter objnme = new SqlParameter();
        objnme.ParameterName = "@usr";
        objnme.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnme.Value = txtusr.Text;
        objcom.Parameters.Add(objnme);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@mob";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txtmob.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objnamew = new SqlParameter();
        objnamew.ParameterName = "@post";
        objnamew.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnamew.Value = txtpost.Text;
        objcom.Parameters.Add(objnamew);

        SqlParameter objphot = new SqlParameter();
        objphot.ParameterName = "@pass";
        objphot.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphot.Value = txtpass.Text;
        objcom.Parameters.Add(objphot);

       // string a = "school";
        SqlParameter objincat = new SqlParameter();
        objincat.ParameterName = "@school";
        objincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objincat.Value = lblsch.Text;
        objcom.Parameters.Add(objincat);

        string message1 = " Teacher Added Successfully...! ";
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