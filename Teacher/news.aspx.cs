using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class pr_news : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
         Sessioninfo();
           fill();

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
    
    public void fill()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectnews();
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String photo = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Teacher/img/" + photo));
        txtpic.Text = photo;
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spnews", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@title";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = txttitle.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        SqlParameter objame = new SqlParameter();
        objame.ParameterName = "@msg";
        objame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objame.Value = txtmsg.Text;
        objcom.Parameters.Add(objame);

        SqlParameter obja95me = new SqlParameter();
        obja95me.ParameterName = "@dscr";
        obja95me.SqlDbType = System.Data.SqlDbType.NVarChar;
        obja95me.Value = txtmsg.Text;
        objcom.Parameters.Add(obja95me);

        SqlParameter objames = new SqlParameter();
        objames.ParameterName = "@addnm";
        objames.SqlDbType = System.Data.SqlDbType.NVarChar;
        objames.Value = lbltchnm.Text;
        objcom.Parameters.Add(objames);

        SqlParameter objamed = new SqlParameter();
        objamed.ParameterName = "@date";
        objamed.SqlDbType = System.Data.SqlDbType.NVarChar;
        objamed.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objamed);

        SqlParameter objam = new SqlParameter();
        objam.ParameterName = "@pic";
        objam.SqlDbType = System.Data.SqlDbType.NVarChar;
        objam.Value = FileUpload1.FileName;
        objcom.Parameters.Add(objam);

        string message1 = " News Feeds Added Successfully...! ";
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