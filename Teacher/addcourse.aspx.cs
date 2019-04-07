using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Teacher_addcourse : System.Web.UI.Page
{
    ClsGlobal glb = new ClsGlobal();
    DataSet dss = new DataSet();
    DataSet dss2 = new DataSet();
    DataSet dss3 = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
          Sessioninfo();
          lblday.Text = System.DateTime.Now.DayOfWeek.ToString();
      
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
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = DropDownList2.SelectedValue;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = DropDownList3.SelectedValue;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        string a = txttime1.Text;
        string b = DropDownList1.SelectedValue;
        string c = txttime2.Text;
        string d = DropDownList4.SelectedValue;
        string to = " to ";

        string time = string.Concat(a, b, to, c, d);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = time.ToString();
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = txtcourse.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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