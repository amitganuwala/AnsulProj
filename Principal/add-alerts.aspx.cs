using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Principal_add_alerts : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();
    DataSet dss3 = new DataSet();

    ClsGlobal glb = new ClsGlobal();
    public static string Tname = "";


    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        // displaypic();
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
                string sql1 = "SELECT [name] FROM [teacher] WHERE ([school] = '"+ dss.Tables[0].Rows[0]["school"].ToString() + "')";
                dss1 = glb.GetDataSet(sql1);
                DropDownList1.DataSource = dss1.Tables[0];
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "name";
                DropDownList1.DataBind();

                
            }

         

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

                Response.Redirect("../Principallogin.aspx");
            }

            fillGridView1(lblsch.Text);
        }
    }

    public void fillGridView1(string school_nm)
    {
        string sql = "SELECT [mob] FROM [teacher] WHERE (([school] = '"+school_nm+ "')AND ([name] = '" + DropDownList1.SelectedValue + "'))";
        dss2 = glb.GetDataSet(sql);
        GridView1.DataSource = dss2;
        GridView1.DataBind();
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {

        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spalert", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@tname";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmain = new SqlParameter();
        objmain.ParameterName = "@msg";
        objmain.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmain.Value = txttask.Text;
        objcom.Parameters.Add(objmain);

        string a = System.DateTime.Now.ToString("dd/MM/yyyy");
        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = a.ToString();
        objcom.Parameters.Add(objname);

        //   string a = "school";
        SqlParameter objincat = new SqlParameter();
        objincat.ParameterName = "@school";
        objincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objincat.Value = lblsch.Text;
        objcom.Parameters.Add(objincat);

        string message1 = " Alerts Added Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        //Message Sending code
        Select.sendalert(GridView1.Rows[0].Cells[0].Text, txttask.Text, lblsch.Text);
        Class1.WebMsgBox.Show("Sms sent");
       
        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();

    }
}