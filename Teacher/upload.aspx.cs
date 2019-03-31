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

public partial class Teacher_upload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rbHDR.Visible=false;
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string Extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            string FolderPath = ConfigurationManager.AppSettings["FolderPath"];

            string FilePath = Server.MapPath(FolderPath + FileName);
            FileUpload1.SaveAs(FilePath);
            Import_To_Grid(FilePath, Extension, rbHDR.SelectedItem.Text);
        }
    }

    private void Import_To_Grid(string FilePath, string Extension, string isHDR)
    {
        string conStr = "";
        switch (Extension)
        {
            case ".xls": //Excel 97-03
                conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                break;
            case ".xlsx": //Excel 07
                conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                break;
        }
        conStr = String.Format(conStr, FilePath, isHDR);
        OleDbConnection connExcel = new OleDbConnection(conStr);
        OleDbCommand cmdExcel = new OleDbCommand();
        OleDbDataAdapter oda = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        cmdExcel.Connection = connExcel;

        //Get the name of First Sheet
        connExcel.Open();
        DataTable dtExcelSchema;
        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
        string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
        connExcel.Close();

        //Read Data from First Sheet
        connExcel.Open();
        cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
        oda.SelectCommand = cmdExcel;
        oda.Fill(dt);
        connExcel.Close();

        //Bind Data to GridView
        GridView1.Caption = Path.GetFileName(FilePath);
        GridView1.DataSource = dt;
        GridView1.DataBind();

        rbHDR.Visible = true;


    }


    protected void btn_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; ++i)
        {
            string conn = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
            SqlConnection objcon = new SqlConnection(conn);
            objcon.Open();
            SqlCommand objcmd = new SqlCommand("spusd", objcon);
            objcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@";
            p2.SqlDbType = SqlDbType.NVarChar;
            p2.Value = (GridView1.Rows[i].Cells[1]).Text;
            objcmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@class";
            p3.SqlDbType = SqlDbType.NVarChar;
            p3.Value = (GridView1.Rows[i].Cells[2]).Text;
            objcmd.Parameters.Add(p3);

            string aa = ((RadioButtonList)GridView1.Rows[i].Cells[3].FindControl("RadioButtonList1")).SelectedValue;
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@status";
            p4.SqlDbType = SqlDbType.NVarChar;
            p4.Value = aa;
            objcmd.Parameters.Add(p4);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@school";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = (GridView1.Rows[i].Cells[3]).Text;
            objcmd.Parameters.Add(p1);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@sid";
            p6.SqlDbType = SqlDbType.NVarChar;
            p6.Value = (GridView1.Rows[i].Cells[0]).Text;
            objcmd.Parameters.Add(p6);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@date";
            p5.SqlDbType = SqlDbType.NVarChar;
            p5.Value = (GridView1.Rows[i].Cells[4]).Text;
            objcmd.Parameters.Add(p5);

            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@day";
            p8.SqlDbType = SqlDbType.NVarChar;
            //p8.Value = lblday.Text;
            objcmd.Parameters.Add(p8);

            string message1 = "Attendance Added Successfully...! ";
            string script = "window.onload = function(){ alert('";
            script += message1;
            script += "');";
            script += "window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

            objcmd.ExecuteNonQuery();
            // Response.Write("Created Successfully");
            objcon.Close();
        }

    }
}