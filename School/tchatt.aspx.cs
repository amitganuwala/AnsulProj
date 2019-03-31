using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class School_tchatt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();

        lblday.Text = DateTime.Now.DayOfWeek.ToString();
        //lbl.Text = DateTime.Now.ToString("dd/mm/yyyy");
        // ((Label)GridView1.FindControl("lbldate")).Text = lbl.Text; 
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            GridView1.Rows[i].BackColor = System.Drawing.Color.LightGreen;
        }


        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            string aa = ((RadioButtonList)GridView1.Rows[i].Cells[3].FindControl("RadioButtonList1")).SelectedValue;

            if (aa.ToString() == "Present")
            {
                GridView1.Rows[i].BackColor = System.Drawing.Color.LightGreen;

            }
            else
            {
                GridView1.Rows[i].BackColor = System.Drawing.Color.PeachPuff;
            }
        }
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; ++i)
        {
            string conn = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
            SqlConnection objcon = new SqlConnection(conn);
            objcon.Open();
            SqlCommand objcmd = new SqlCommand("sptchatt", objcon);
            objcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@name";
            p2.SqlDbType = SqlDbType.NVarChar;
            p2.Value = (GridView1.Rows[i].Cells[1]).Text;
            objcmd.Parameters.Add(p2);

            string aa = ((RadioButtonList)GridView1.Rows[i].Cells[2].FindControl("RadioButtonList1")).SelectedValue;
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@status";
            p4.SqlDbType = SqlDbType.NVarChar;
            p4.Value = aa.ToString();
            objcmd.Parameters.Add(p4);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@school";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = lblsch.Text;
            objcmd.Parameters.Add(p1);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@tid";
            p6.SqlDbType = SqlDbType.NVarChar;
            p6.Value = (GridView1.Rows[i].Cells[0]).Text;
            objcmd.Parameters.Add(p6);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@time";
            p3.SqlDbType = SqlDbType.NVarChar;
            p3.Value = (GridView1.Rows[i].Cells[3]).Text;
            objcmd.Parameters.Add(p3);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@date";
            p5.SqlDbType = SqlDbType.NVarChar;
            p5.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
            objcmd.Parameters.Add(p5);

            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@day";
            p8.SqlDbType = SqlDbType.NVarChar;
            p8.Value = lblday.Text;
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