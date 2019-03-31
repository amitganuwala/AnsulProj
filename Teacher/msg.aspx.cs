using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Net;

public partial class Teacher_msg : System.Web.UI.Page
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
    protected void btnadd_Click(object sender, EventArgs e)
    {
         SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
       //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("sptchmsg", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@name";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = DropDownList3.SelectedValue;
        objcom.Parameters.Add(objmaincat);

        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        SqlParameter objame1 = new SqlParameter();
        objame1.ParameterName = "@class";
        objame1.SqlDbType = System.Data.SqlDbType.NVarChar;
        objame1.Value = DropDownList2.SelectedValue;
        objcom.Parameters.Add(objame1);

        SqlParameter objame = new SqlParameter();
        objame.ParameterName = "@msg";
        objame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objame.Value = txtdescr.Text;
        objcom.Parameters.Add(objame);

        SqlParameter objamed = new SqlParameter();
        objamed.ParameterName = "@addt";
        objamed.SqlDbType = System.Data.SqlDbType.NVarChar;
        objamed.Value = System.DateTime.Now.ToString();
        objcom.Parameters.Add(objamed);

        string a = System.DateTime.Now.ToString("dd/MM/yyyy");
        SqlParameter objam = new SqlParameter();
        objam.ParameterName = "@adtch";
        objam.SqlDbType = System.Data.SqlDbType.NVarChar;
        objam.Value = lbltchnm.Text;
        objcom.Parameters.Add(objam);

        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();




        if (Select.sendsms(GridView1.Rows[0].Cells[0].Text, txtdescr.Text, a.ToString(), lblsch.Text))
        {



           // Select.sendalert(GridView1.Rows[0].Cells[0].Text, txtdescr.Text, lblsch.Text);


            Class1.WebMsgBox.Show("Sent successfully..");

        }
                 
       
    }
}