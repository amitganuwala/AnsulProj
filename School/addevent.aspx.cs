using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class School_addevent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
            Sessioninfo();
            
    }
    public void Sessioninfo()
    {
        HttpCookie myCookies = Request.Cookies["myCookies"];


        if (myCookies != null)
        {

            string userId = myCookies["snm"];
            
            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectschooladmn(userId);
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

                Response.Redirect("../Schooladminlogin.aspx");
            }

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String photo = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Teacher/img/" + photo));
        txtpic.Text = photo;
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {

        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
     //   SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spevent", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@title";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = txtevent.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = txtdate.Text;
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@descr";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txtdescr.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@pic";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = txtpic.Text;
        objcom.Parameters.Add(objpho);

        string a = System.DateTime.Now.ToString("dd/MM/yyyy");
        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@adddate";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = a.ToString();
        objcom.Parameters.Add(obpheo);

        string st = "Pending";

        SqlParameter obpo1 = new SqlParameter();
        obpo1.ParameterName = "@st";
        obpo1.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo1.Value = st.ToString();
        objcom.Parameters.Add(obpo1);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@addtch";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@class";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(obpom);

       
        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Event added..Waiting for approval.! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
     

        objcom.ExecuteNonQuery();
        Response.Redirect("~/School/addevent.aspx");
        objcon.Close();


    }

}