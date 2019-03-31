using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

public partial class School_view_event : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();
        fill();
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemdetevent(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
            img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            lbltitle.Text = ds.Tables[0].Rows[0]["title"].ToString();
            lbldate.Text = ds.Tables[0].Rows[0]["date"].ToString();
                lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
            lbldescr.Text = ds.Tables[0].Rows[0]["descr"].ToString();
            lblsch.Text = ds.Tables[0].Rows[0]["school"].ToString();
            if (ds.Tables[0].Rows[0]["pic"].ToString() == "")
            {
                img.Visible = false;
                st.Text = "NO IMAGE AVAILABLE...";
            }
        }
    }



    public void fill()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectgallery(lblid.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {



        if (FileUpload1.HasFile)
        {
            String photo = Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/Teacher/pic/" + photo));

            string conn = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
            SqlConnection objcon = new SqlConnection(conn);
            objcon.Open();
            SqlCommand objcmd = new SqlCommand("spgal", objcon);
            objcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@pic";
            p2.SqlDbType = SqlDbType.NVarChar;
            p2.Value = FileUpload1.FileName;
            objcmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@id";
            p3.SqlDbType = SqlDbType.NVarChar;
            p3.Value = lblid.Text;
            objcmd.Parameters.Add(p3);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@school";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = lblsch.Text;
            objcmd.Parameters.Add(p1);


            //Class1.WebMsgBox.Show("1 Added successfully");
            objcmd.ExecuteNonQuery();
            // Response.Write("Created Successfully");
            objcon.Close();
        }

        if (FileUpload2.HasFile)
        {
            String photo1 = Path.GetFileName(FileUpload2.FileName);
            FileUpload2.SaveAs(Server.MapPath("~/Teacher/pic/" + photo1));

            string conn1 = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
            SqlConnection objcon1 = new SqlConnection(conn1);
            objcon1.Open();
            SqlCommand objcmd1 = new SqlCommand("spgal", objcon1);
            objcmd1.CommandType = CommandType.StoredProcedure;

            SqlParameter p21 = new SqlParameter();
            p21.ParameterName = "@pic";
            p21.SqlDbType = SqlDbType.NVarChar;
            p21.Value = FileUpload2.FileName;
            objcmd1.Parameters.Add(p21);

            SqlParameter p31 = new SqlParameter();
            p31.ParameterName = "@id";
            p31.SqlDbType = SqlDbType.NVarChar;
            p31.Value = lblid.Text;
            objcmd1.Parameters.Add(p31);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@school";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = lblsch.Text;
            objcmd1.Parameters.Add(p1);

            //Class1.WebMsgBox.Show("2 Added successfully");
            objcmd1.ExecuteNonQuery();
            // Response.Write("Created Successfully");
            objcon1.Close();
        }

        if (FileUpload3.HasFile)
        {
            String photo2 = Path.GetFileName(FileUpload3.FileName);
            FileUpload3.SaveAs(Server.MapPath("~/Teacher/pic/" + photo2));


            string conn2 = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
            SqlConnection objcon2 = new SqlConnection(conn2);
            objcon2.Open();
            SqlCommand objcmd2 = new SqlCommand("spgal", objcon2);
            objcmd2.CommandType = CommandType.StoredProcedure;

            SqlParameter p22 = new SqlParameter();
            p22.ParameterName = "@pic";
            p22.SqlDbType = SqlDbType.NVarChar;
            p22.Value = FileUpload3.FileName;
            objcmd2.Parameters.Add(p22);

            SqlParameter p32 = new SqlParameter();
            p32.ParameterName = "@id";
            p32.SqlDbType = SqlDbType.NVarChar;
            p32.Value = lblid.Text;
            objcmd2.Parameters.Add(p32);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@school";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = lblsch.Text;
            objcmd2.Parameters.Add(p1);

            //Class1.WebMsgBox.Show("3 Added successfully");
            objcmd2.ExecuteNonQuery();
            // Response.Write("Created Successfully");
            objcon2.Close();
        }

        if (FileUpload4.HasFile)
        {
            String photo3 = Path.GetFileName(FileUpload4.FileName);
            FileUpload4.SaveAs(Server.MapPath("~/Teacher/pic/" + photo3));

            string conn3 = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
            SqlConnection objcon3 = new SqlConnection(conn3);
            objcon3.Open();
            SqlCommand objcmd3 = new SqlCommand("spgal", objcon3);
            objcmd3.CommandType = CommandType.StoredProcedure;

            SqlParameter p23 = new SqlParameter();
            p23.ParameterName = "@pic";
            p23.SqlDbType = SqlDbType.NVarChar;
            p23.Value = FileUpload4.FileName;
            objcmd3.Parameters.Add(p23);

            SqlParameter p33 = new SqlParameter();
            p33.ParameterName = "@id";
            p33.SqlDbType = SqlDbType.NVarChar;
            p33.Value = lblid.Text;
            objcmd3.Parameters.Add(p33);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@school";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = lblsch.Text;
            objcmd3.Parameters.Add(p1);

            // Class1.WebMsgBox.Show("4 Added successfully");
            objcmd3.ExecuteNonQuery();
            // Response.Write("Created Successfully");
            objcon3.Close();
        }

        if (FileUpload5.HasFile)
        {
            String photo4 = Path.GetFileName(FileUpload5.FileName);
            FileUpload5.SaveAs(Server.MapPath("~/Teacher/pic/" + photo4));

            string conn4 = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
            SqlConnection objcon4 = new SqlConnection(conn4);
            objcon4.Open();
            SqlCommand objcmd4 = new SqlCommand("spgal", objcon4);
            objcmd4.CommandType = CommandType.StoredProcedure;

            SqlParameter p24 = new SqlParameter();
            p24.ParameterName = "@pic";
            p24.SqlDbType = SqlDbType.NVarChar;
            p24.Value = FileUpload5.FileName;
            objcmd4.Parameters.Add(p24);

            SqlParameter p34 = new SqlParameter();
            p34.ParameterName = "@id";
            p34.SqlDbType = SqlDbType.NVarChar;
            p34.Value = lblid.Text;
            objcmd4.Parameters.Add(p34);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@school";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = lblsch.Text;
            objcmd4.Parameters.Add(p1);

            //Class1.WebMsgBox.Show("5 Added successfully");
            objcmd4.ExecuteNonQuery();
            // Response.Write("Created Successfully");
            objcon4.Close();
        }

        Class1.WebMsgBox.Show("Pics Added to Gallery Successfully");
    }

}