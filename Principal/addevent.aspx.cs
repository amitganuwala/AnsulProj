using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal_addevent : System.Web.UI.Page
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
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];


        if (myCookiepr != null)
        {

            string userId = myCookiepr["prnm"];

            string sql = "select * from principal where usr = '" + userId + "'";
            dss = glb.GetDataSet(sql);


            if (!IsPostBack)
            {
                string sql1 = "SELECT [class] FROM [classsection] WHERE ([school] = '"+ dss.Tables[0].Rows[0]["school"].ToString() + "') ORDER BY [id]";
                dss1 = glb.GetDataSet(sql1);
                DropDownList1.DataSource = dss1.Tables[0];
                DropDownList1.DataTextField = "class";
                DropDownList1.DataValueField = "class";
                DropDownList1.DataBind();
            }


                if (dss.Tables[0].Rows.Count == 1)
            {
                lblprinm.Text = dss.Tables[0].Rows[0]["namr"].ToString();
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

    protected void Button1_Click(object sender, EventArgs e)
    {

        String photo = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Teacher/img/" + photo));
        txtpic.Text = photo;

    }


    protected void btnadd2_Click(object sender, EventArgs e)
    {


        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //  SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spevent", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@title";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = txtevent.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmain = new SqlParameter();
        objmain.ParameterName = "@class";
        objmain.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmain.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(objmain);

        string st = "Active";

        SqlParameter objname1 = new SqlParameter();
        objname1.ParameterName = "@st";
        objname1.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname1.Value = st.ToString();
        objcom.Parameters.Add(objname1);

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

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@addtch";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lblprinm.Text;
        objcom.Parameters.Add(obpo);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = "Events Added Successfully.";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        
        objcom.ExecuteNonQuery();
        Response.Redirect("~/Principal/addevent.aspx");
        objcon.Close();


    }
}