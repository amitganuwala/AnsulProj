 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_addhomework : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();

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

            string sql = "select * from teacher where usr='" + userId+ "' ";
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
                string sql1 = "SELECT [class] FROM [subject] WHERE (([name] = '"+lbltchnm.Text+"') AND ([school] = '"+lblsch.Text+"'))";
                dss1 = glb.GetDataSet(sql1);
                DropDownList1.DataSource = dss1.Tables[0];
                DropDownList1.DataTextField = "class";
                DropDownList1.DataValueField = "class";
                DropDownList1.DataBind();




                string sql3 = "SELECT [subject] FROM [subject] WHERE (([class] = '"+DropDownList1.SelectedValue+"') AND ([name] = '"+lbltchnm.Text+"') AND ([school] = '"+lblsch.Text+"'))";
                dss2 = glb.GetDataSet(sql3);
                DropDownList3.DataSource = dss2.Tables[0];
                DropDownList3.DataTextField = "subject";
                DropDownList3.DataValueField = "subject";
                DropDownList3.DataBind();

            }


        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        String photo = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Teacher/img/" + photo));
        txtpic.Text = photo;
    }
    
    protected void btnadd2_Click(object sender, EventArgs e)
    {

        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
      // SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("sphw", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@class";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(objmaincat);

        
        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@subject";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = DropDownList3.SelectedValue;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@pic";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = txtpic.Text;
        objcom.Parameters.Add(objpho);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        SqlParameter obphots = new SqlParameter();
        obphots.ParameterName = "@subdate";
        obphots.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphots.Value = txtsubdt.Text;
        objcom.Parameters.Add(obphots);

        SqlParameter obphotsa = new SqlParameter();
        obphotsa.ParameterName = "@adddate";
        obphotsa.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphotsa.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(obphotsa);

        SqlParameter obphotsd = new SqlParameter();
        obphotsd.ParameterName = "@addtch";
        obphotsd.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphotsd.Value = lbltchnm.Text;
        objcom.Parameters.Add(obphotsd);

        SqlParameter objame = new SqlParameter();
        objame.ParameterName = "@hw";
        objame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objame.Value = txthw.Text;
        objcom.Parameters.Add(objame);

        string st = "Pending";

        SqlParameter objame1 = new SqlParameter();
        objame1.ParameterName = "@st";
        objame1.SqlDbType = System.Data.SqlDbType.NVarChar;
        objame1.Value = st.ToString(); 
        objcom.Parameters.Add(objame1);

        string message1 = " Homework added..Waiting for approval.! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        objcom.ExecuteNonQuery();
        
        objcon.Close();

    }
}