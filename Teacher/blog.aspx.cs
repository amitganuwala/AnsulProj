using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

public partial class pr_blog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        fill();
        fill1();
        grdvw.Visible = false;
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
                // lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
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
        ds = sel.selectblog();
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();
    
    }

    public void fill1()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectblogfeatured();
        DataList1.DataSource = ds.Tables[0];
        DataList1.DataBind();

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        rptitem.Visible = false;
        grdvw.Visible = true;


        string conn = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
        SqlConnection objcon = new SqlConnection(conn);
        objcon.Open();
        SqlCommand objcmd = new SqlCommand("spsearchblog", objcon);
        objcmd.CommandType = CommandType.StoredProcedure;

        if (txtschnm.Text.Trim() != "")
        {
            SqlParameter param = new SqlParameter("@name", txtschnm.Text);
            objcmd.Parameters.Add(param);
        }
        else if (txtsubj.Text.Trim() != "")
        {
            SqlParameter param = new SqlParameter("@sub", txtsubj.Text);
            objcmd.Parameters.Add(param);
        }
        else if (txtaddnm.Text.Trim() != "")
        {
            SqlParameter param = new SqlParameter("@addnm", txtaddnm.Text);
            objcmd.Parameters.Add(param);
        }


        SqlDataReader rdr = objcmd.ExecuteReader();
        grdvw.DataSource = rdr;
        grdvw.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        String photo = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Teacher/img/" + photo));
        txtpic.Text = photo;

        if (!FileUpload1.HasFile)
        {
            Class1.WebMsgBox.Show("Select Image First");
        }
        else
        {

           SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
         //   SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
            objcon.Open();
            SqlCommand objcom = new SqlCommand("spblog", objcon);
            objcom.CommandType = CommandType.StoredProcedure;

            SqlParameter objmaincat = new SqlParameter();
            objmaincat.ParameterName = "@title";
            objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
            objmaincat.Value = txttitle.Text;
            objcom.Parameters.Add(objmaincat);

            SqlParameter bobjmaincat = new SqlParameter();
            bobjmaincat.ParameterName = "@sub";
            bobjmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
            bobjmaincat.Value = txtsub.Text;
            objcom.Parameters.Add(bobjmaincat);

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

            string st = "Inactive";
            SqlParameter obm = new SqlParameter();
            obm.ParameterName = "@status";
            obm.SqlDbType = System.Data.SqlDbType.NVarChar;
            obm.Value = st.ToString();
            objcom.Parameters.Add(obm);

            SqlParameter obm1 = new SqlParameter();
            obm1.ParameterName = "@dscr";
            obm1.SqlDbType = System.Data.SqlDbType.NVarChar;
            obm1.Value = txtmsg.Text;
            objcom.Parameters.Add(obm1);

            string message1 = " Blogs Added Successfully...! ";
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
}