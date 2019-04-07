using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.OleDb;

public partial class School_upload : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();

    ClsGlobal glb = new ClsGlobal();


    protected void Page_Load(object sender, EventArgs e)
    {
        //  rbHDR.Visible=false;
        //btnsend.Visible = false;

        Sessioninfo();
        //fillItem();
    }
    public void Sessioninfo()
    {
        HttpCookie myCookies = Request.Cookies["myCookies"];


        if (myCookies != null)
        {

            string userId = myCookies["snm"];

            //Select sels = new Select();
            //dss = sels.selectschooladmn(userId);

            string sql = "select * from schooladmin where usr='" + userId + "' ";
            dss = glb.GetDataSet(sql);

            if (dss.Tables[0].Rows.Count == 1)
            {
                //  lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
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

            if (!IsPostBack)
            {
                string sql1 = "SELECT [class] FROM [classsection] WHERE ([school] = '"+lblsch.Text+"')";
                dss1 = glb.GetDataSet(sql1);
                DropDownList1.DataSource = dss1.Tables[0];
                DropDownList1.DataTextField = "class";
                DropDownList1.DataValueField = "class";
                DropDownList1.DataBind();
            }

        }
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        //btnsend.Visible = true;
        //Coneection String by default empty  
        string ConStr = "";
        //Extantion of the file upload control saving into ext because   
        //there are two types of extation .xls and .xlsx of Excel   
        string ext = Path.GetExtension(FileUpload1.FileName).ToLower();
        //getting the path of the file   
        string path = Server.MapPath("~/School/Files/" + FileUpload1.FileName);
        //saving the file inside the MyFolder of the server  
        FileUpload1.SaveAs(path);
        Label1.Text = FileUpload1.FileName + "\'s Data showing into the GridView";
        //checking that extantion is .xls or .xlsx  
        if (ext.Trim() == ".xls")
        {
            //connection string for that file which extantion is .xls  
            ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
        }
        else if (ext.Trim() == ".xlsx")
        {
            //connection string for that file which extantion is .xlsx  
            ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
        }
        //making query  
        string query = "SELECT * FROM [Sheet1$]";
        //Providing connection  
        OleDbConnection conn = new OleDbConnection(ConStr);
        //checking that connection state is closed or not if closed the   
        //open the connection  
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        //create command object  
        OleDbCommand cmd = new OleDbCommand(query, conn);
        // create a data adapter and get the data into dataadapter  
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataSet ds = new DataSet();
        //fill the Excel data to data set  
        da.Fill(ds);
        //set data source of the grid view  
        gvExcelFile.DataSource = ds.Tables[0];
        //binding the gridview  
        gvExcelFile.DataBind();
        //close the connection  
        conn.Close();


    }
    protected void btnsend_Click(object sender, EventArgs e)
    {

        for (int i = 0; i < gvExcelFile.Rows.Count; ++i)
        {
            string usr = Guid.NewGuid().ToString("n").Substring(0, 4);
           string pass = Guid.NewGuid().ToString("n").Substring(0, 6);
            if ((Select.sendsmsidpass(gvExcelFile.Rows[i].Cells[1].Text, usr, pass,lblsch.Text)) == true)
           {
           }
           else
           {
             Class1.WebMsgBox.Show("Problem is sending SMS...");
           }

            
            string conn = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
            SqlConnection objcon = new SqlConnection(conn);
            objcon.Open();
            SqlCommand objcmd = new SqlCommand("spparent", objcon);
            objcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@stu";
            p2.SqlDbType = SqlDbType.NVarChar;
            p2.Value = (gvExcelFile.Rows[i].Cells[0]).Text;
            objcmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@class";
            p3.SqlDbType = SqlDbType.NVarChar;
            p3.Value = DropDownList1.Text;
            objcmd.Parameters.Add(p3);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@school";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = lblsch.Text;
            objcmd.Parameters.Add(p1);

            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@mob";
            p8.SqlDbType = SqlDbType.NVarChar;
            p8.Value = (gvExcelFile.Rows[i].Cells[1]).Text;
            objcmd.Parameters.Add(p8);

            SqlParameter p83 = new SqlParameter();
            p83.ParameterName = "@usr";
            p83.SqlDbType = SqlDbType.NVarChar;
            p83.Value = usr.ToString();
            objcmd.Parameters.Add(p83);

            SqlParameter p84 = new SqlParameter();
            p84.ParameterName = "@pass";
            p84.SqlDbType = SqlDbType.NVarChar;
            p84.Value = pass.ToString();
            objcmd.Parameters.Add(p84);

            Class1.WebMsgBox.Show("Uploaded successfully");
            objcmd.ExecuteNonQuery();
            // Response.Write("Created Successfully");
            objcon.Close();
            //Response.Redirect("upload.aspx");
        }
    }
protected void download_Click(object sender, EventArgs e)
{
     Response.ContentType = "Application/ExcelFile";
        Response.AppendHeader("Content-Disposition", "attachment; filename=Book1.xls");
        Response.TransmitFile(Server.MapPath("docs/Book1.xls"));
        Response.End();
}
}