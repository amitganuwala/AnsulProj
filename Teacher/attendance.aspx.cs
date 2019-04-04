using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_attendance : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();

    ClsGlobal glb = new ClsGlobal();



    protected void Page_Load(object sender, EventArgs e)
    {

        Sessioninfo();

        lblday.Text = DateTime.Now.DayOfWeek.ToString();
        lbl.Text=DateTime.Now.ToString("dd/MM/yyyy");
       // ((Label)GridView1.FindControl("lbldate")).Text = lbl.Text; 
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            GridView1.Rows[i].BackColor = System.Drawing.Color.LightGreen;
        }


        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            string aa = ((RadioButtonList)GridView1.Rows[i].Cells[3].FindControl("RadioButtonList1")).SelectedValue ;

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


        HttpCookie myCookiet = Request.Cookies["myCookiet"];


        if (myCookiet != null)
        {

            string userId = myCookiet["tnm"];

            string sql = "select * from teacher where usr='" + userId + "' ";
            dss = glb.GetDataSet(sql);



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

            if (!IsPostBack)
            {
                string sql1 = "SELECT [class] FROM [classsection] WHERE ([school] = '" + lblsch.Text + "') ORDER BY [id]";
                dss1 = glb.GetDataSet(sql1);
                DropDownList1.DataSource = dss1.Tables[0];
                DropDownList1.DataTextField = "class";
                DropDownList1.DataValueField = "class";
                DropDownList1.DataBind();

                fillGridView1(lblsch.Text);
            }

        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {

        for(int i = 0; i < GridView1.Rows.Count; ++i)
        {
            string conn =ClsVariable.ConnectionString;
            SqlConnection objcon = new SqlConnection(conn);
            objcon.Open();
            SqlCommand objcmd = new SqlCommand("spatt", objcon);
            objcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@name";
            p2.SqlDbType = SqlDbType.NVarChar;
            p2.Value = (GridView1.Rows[i].Cells[1]).Text;
            objcmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@class";
            p3.SqlDbType = SqlDbType.NVarChar;
            p3.Value = DropDownList1.SelectedValue;
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
            p1.Value = lblsch.Text;
            objcmd.Parameters.Add(p1);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@sid";
            p6.SqlDbType = SqlDbType.NVarChar;
            p6.Value = (GridView1.Rows[i].Cells[0]).Text;
            objcmd.Parameters.Add(p6);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@date";
            p5.SqlDbType = SqlDbType.NVarChar;
            p5.Value = DateTime.Now.ToString("dd/MM/yyyy");
            objcmd.Parameters.Add(p5);

            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@day";
            p8.SqlDbType = SqlDbType.NVarChar;
            p8.Value = lblday.Text;
            objcmd.Parameters.Add(p8);
            if (CheckBox1.Checked)
            {
                if ( aa.ToString() == "Absent")
                {
                    Select.sendatt(GridView1.Rows[i].Cells[6].Text, aa.ToString(), DateTime.Now.ToString("dd/MM/yyyy"), lblsch.Text);
                }
            }
            else if (CheckBox2.Checked)
            {
                Select.sendatt(GridView1.Rows[i].Cells[6].Text, aa.ToString(), DateTime.Now.ToString("dd/MM/yyyy"), lblsch.Text);
            }

            string message1 = "Attendance Added Successfully...! ";
            string script = "window.onload = function(){ alert('";
            script += message1;
            script += "');";
            script += "window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

            objcmd.ExecuteNonQuery();
            objcon.Close();
        }
    }

    public void fillGridView1(string school_nm)
    {
        string sql = "SELECT [id], [name], [class], [mob], [school] FROM [parent] WHERE (([class] = '"+DropDownList1.SelectedValue+"') AND ([school] = '"+school_nm+"')) ORDER BY [name]";
        dss2 = glb.GetDataSet(sql);
        GridView1.DataSource = dss2;
        GridView1.DataBind();
    }
}