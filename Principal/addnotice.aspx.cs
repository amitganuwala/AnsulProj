using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal_addnotice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
        Sessioninfo();
        
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
                lbltchnm.Text = dss.Tables[0].Rows[0]["namr"].ToString();
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

    protected void btnadd2_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spnotice", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@class";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = DropDownList1.SelectedValue; ;
        objcom.Parameters.Add(objmaincat);

        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        SqlParameter objame = new SqlParameter();
        objame.ParameterName = "@notice";
        objame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objame.Value = txtsub.Text;
        objcom.Parameters.Add(objame);

        string st = "Active";

        SqlParameter objames1 = new SqlParameter();
        objames1.ParameterName = "@st";
        objames1.SqlDbType = System.Data.SqlDbType.NVarChar;
        objames1.Value = st.ToString();
        objcom.Parameters.Add(objames1);

        SqlParameter objames = new SqlParameter();
        objames.ParameterName = "@adfrom";
        objames.SqlDbType = System.Data.SqlDbType.NVarChar;
        objames.Value = lbltchnm.Text;
        objcom.Parameters.Add(objames);

        string a = System.DateTime.Now.ToString("dd/MM/yyyy");
        SqlParameter objamed = new SqlParameter();
        objamed.ParameterName = "@date";
        objamed.SqlDbType = System.Data.SqlDbType.NVarChar;
        objamed.Value = a.ToString();
        objcom.Parameters.Add(objamed);

        SqlParameter obmed = new SqlParameter();
        obmed.ParameterName = "@duedt";
        obmed.SqlDbType = System.Data.SqlDbType.NVarChar;
        obmed.Value = txtdate.Text;
        objcom.Parameters.Add(obmed);

        Class1.WebMsgBox.Show("Notice added Successfully..");
        objcom.ExecuteNonQuery();
        Response.Redirect("~/Principal/addnotice.aspx");
        objcon.Close();

    }
}