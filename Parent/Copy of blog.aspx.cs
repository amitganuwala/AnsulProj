using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class tc_blog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
    }


    public void Sessioninfo()
    {

        HttpCookie myCookiep = Request.Cookies["myCookiep"];


        if (myCookiep != null)
        {

            string userId = myCookiep["pnm"];

            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectimesespt(userId);

            if (dss.Tables[0].Rows.Count == 1)
            {
                // lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
                lblsch1.Text = dss.Tables[0].Rows[0]["school"].ToString();
                lblstdnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                stnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
                lblclass.Text = dss.Tables[0].Rows[0]["class"].ToString();
                lclass.Text = dss.Tables[0].Rows[0]["class"].ToString();

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

                Response.Redirect("../Parentlogin.aspx");
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spleave1", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@adddt";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = System.DateTime.Now.ToString();
        objcom.Parameters.Add(objmaincat);

        SqlParameter bobjmaincat = new SqlParameter();
        bobjmaincat.ParameterName = "@snm";
        bobjmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        bobjmaincat.Value = lblstdnm.Text;
        objcom.Parameters.Add(bobjmaincat);

        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        SqlParameter objame = new SqlParameter();
        objame.ParameterName = "@pnm";
        objame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objame.Value = txtpmm.Text;
        objcom.Parameters.Add(objame);

        SqlParameter objames = new SqlParameter();
        objames.ParameterName = "@class";
        objames.SqlDbType = System.Data.SqlDbType.NVarChar;
        objames.Value = lblclass.Text;
        objcom.Parameters.Add(objames);

        SqlParameter objamed = new SqlParameter();
        objamed.ParameterName = "@subject";
        objamed.SqlDbType = System.Data.SqlDbType.NVarChar;
        objamed.Value = txtsub.Text;
        objcom.Parameters.Add(objamed);

        SqlParameter objam = new SqlParameter();
        objam.ParameterName = "@reason";
        objam.SqlDbType = System.Data.SqlDbType.NVarChar;
        objam.Value = txtreason.Text;
        objcom.Parameters.Add(objam);

        string st = "Pending";
        SqlParameter obm = new SqlParameter();
        obm.ParameterName = "@st";
        obm.SqlDbType = System.Data.SqlDbType.NVarChar;
        obm.Value = st.ToString();
        objcom.Parameters.Add(obm);


        SqlParameter objamed1 = new SqlParameter();
        objamed1.ParameterName = "@day";
        objamed1.SqlDbType = System.Data.SqlDbType.NVarChar;
        objamed1.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(objamed1);

        SqlParameter objam1 = new SqlParameter();
        objam1.ParameterName = "@datest";
        objam1.SqlDbType = System.Data.SqlDbType.NVarChar;
        objam1.Value = TextBox1.Text;
        objcom.Parameters.Add(objam1);

        
        SqlParameter obm1 = new SqlParameter();
        obm1.ParameterName = "@datetl";
        obm1.SqlDbType = System.Data.SqlDbType.NVarChar;
        obm1.Value = TextBox2.Text;
        objcom.Parameters.Add(obm1);

        string message1 = " Application Sent Successfully...! Waiting for approval.. ";
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