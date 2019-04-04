using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_addstudent : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();

    ClsGlobal glb = new ClsGlobal();


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

            string sql = "select * from teacher where usr='" + userId + "' ";
            dss = glb.GetDataSet(sql);



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

            if (!IsPostBack)
            {
                string sql1 = "SELECT[class] FROM[classsection] WHERE([school] = '" + lblsch.Text + "') ORDER BY[id] DESC";
                dss1 = glb.GetDataSet(sql1);
                ddlclass.DataSource = dss1.Tables[0];
                ddlclass.DataTextField = "class";
                ddlclass.DataValueField = "class";
                ddlclass.DataBind();

                //fillGridView2();
                //fillGridView3();
            }
        }
    }
    protected void btnad_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spparent", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

       
        //string a = "school";
        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        SqlParameter objmainct = new SqlParameter();
        objmainct.ParameterName = "@stu";
        objmainct.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmainct.Value = txtname.Text;
        objcom.Parameters.Add(objmainct);

        SqlParameter objnct = new SqlParameter();
        objnct.ParameterName = "@class";
        objnct.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnct.Value = ddlclass.SelectedValue;
        objcom.Parameters.Add(objnct);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@mob";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txtmob.Text;
        objcom.Parameters.Add(objphoto);
        
        string usr = Guid.NewGuid().ToString("n").Substring(0,4);

        SqlParameter p83 = new SqlParameter();
        p83.ParameterName = "@usr";
        p83.SqlDbType = SqlDbType.NVarChar;
        p83.Value = usr.ToString();
        objcom.Parameters.Add(p83);
        
        string pass = Guid.NewGuid().ToString("n").Substring(0, 8);
        
        SqlParameter p84 = new SqlParameter();
        p84.ParameterName = "@pass";
        p84.SqlDbType = SqlDbType.NVarChar;
        p84.Value = pass.ToString();
        objcom.Parameters.Add(p84);
        Select.sendsmsidpass(txtmob.Text, usr.ToString(), pass.ToString(), lblsch.Text);
        Class1.WebMsgBox.Show("Sms sent");

        string message1 = "Student Added Successfully...! ";
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