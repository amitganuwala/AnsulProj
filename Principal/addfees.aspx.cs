using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HOD_addfees : System.Web.UI.Page
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
                //lblprinm.Text = dss.Tables[0].Rows[0]["namr"].ToString();
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

                Response.Redirect("../locklogin.aspx");
            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
       // SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spfees", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@class";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@fees";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = txtfees.Text;
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@type";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txttype.Text;
        objcom.Parameters.Add(objphoto);

       // string a = "school";
        SqlParameter objincat = new SqlParameter();
        objincat.ParameterName = "@school";
        objincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objincat.Value = lblsch.Text;
        objcom.Parameters.Add(objincat);

        string message1 = "Fees Information Added Successfully...! ";
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