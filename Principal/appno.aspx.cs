using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Principal_appno : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();



    protected void Page_Load(object sender, EventArgs e)
    {
         ViewProfile();

    }
    ClsGlobal glb = new ClsGlobal();


    public void ViewProfile()
    {
        Select sel = new Select();
        ds = sel.selectitemdetnotice(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
           // img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            lbltitle.Text = ds.Tables[0].Rows[0]["notice"].ToString();
            //lbldate.Text = ds.Tables[0].Rows[0]["subject"].ToString();
            lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
            lbldescr.Text = ds.Tables[0].Rows[0]["date"].ToString();
            lbladtch.Text = ds.Tables[0].Rows[0]["adfrom"].ToString();
            lbladdt.Text = ds.Tables[0].Rows[0]["duedate"].ToString();
            ClsVariable.Schollname = ds.Tables[0].Rows[0]["school"].ToString();


            fillGridView1();
            fillGridView2();
        }

    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (true)
        {
            SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
            //  SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
            objcon.Open();
            SqlCommand objcom = new SqlCommand("spupno", objcon);
            objcom.CommandType = CommandType.StoredProcedure;

            string st = "Active";
            SqlParameter objmaincat = new SqlParameter();
            objmaincat.ParameterName = "@st";
            objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
            objmaincat.Value = st.ToString();
            objcom.Parameters.Add(objmaincat);

            SqlParameter objincat = new SqlParameter();
            objincat.ParameterName = "@id";
            objincat.SqlDbType = System.Data.SqlDbType.NVarChar;
            objincat.Value = lblid.Text;
            objcom.Parameters.Add(objincat);

            string message1 = " Approved Successfully...! ";
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

            int count = 0;
            int flag = 0;
            string nm = "";



            if (lblclass.Text == "All")
            {
                string sql3 = "select mob from parent where school = '" + ClsVariable.Schollname + "'";               
                DataSet ds = new DataSet();
                ds = glb.GetDataSet(sql3);              
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    if (nm == "")
                    {
                        nm = ds.Tables[0].Rows[j].ItemArray[0].ToString(); 
                    }
                    else
                    {
                        nm = nm + "," + ds.Tables[0].Rows[j].ItemArray[0].ToString();
                    }
                }

            }
            else
            {
                string sql3 = "select mob from parent where class = '" + lblclass.Text + "' and school = '" + ClsVariable.Schollname + "'";
                DataSet ds = new DataSet();
                ds = glb.GetDataSet(sql3);
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    if (nm == "")
                    {
                        nm = ds.Tables[0].Rows[j].ItemArray[0].ToString();
                    }
                    else
                    {
                        nm = nm + "," + ds.Tables[0].Rows[j].ItemArray[0].ToString();
                    }
                }

                //Class1.WebMsgBox.Show("SMS Sent.");
            }

            //nm = "8087981030,9923482177";
            Select.sendsms(nm, lbltitle.Text, lbldescr.Text, lblsch.Text);
            Class1.WebMsgBox.Show("SMS Sent.");

            //if(nm!="")
            // {
            //     nm = ""
            //     Select.sendsms(nm, lbltitle.Text, lbldescr.Text, lblsch.Text);
            //     Class1.WebMsgBox.Show("SMS Sent.");
            // }


        }
        Response.Redirect("~/Principal/unapprove.aspx");
        
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (true)
        {
            SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
            //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
            objcon.Open();
            SqlCommand objcom = new SqlCommand("spupno", objcon);
            objcom.CommandType = CommandType.StoredProcedure;

            string st = "Rejected";
            SqlParameter objmaincat = new SqlParameter();
            objmaincat.ParameterName = "@st";
            objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
            objmaincat.Value = st.ToString();
            objcom.Parameters.Add(objmaincat);

            SqlParameter objincat = new SqlParameter();
            objincat.ParameterName = "@id";
            objincat.SqlDbType = System.Data.SqlDbType.NVarChar;
            objincat.Value = lblid.Text;
            objcom.Parameters.Add(objincat);

            string message1 = " Rejected...! ";
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
        Response.Redirect("~/Principal/unapprove.aspx");
    }

    public void fillGridView1()
    {
        string sql = "SELECT [mob] FROM [parent] WHERE (([class] = '"+lblclass.Text+"') AND ([school] = '"+ ClsVariable.Schollname + "'))";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }

    public void fillGridView2()
    {
        string sql = "SELECT [mob] FROM [parent] WHERE ([school] = '"+ ClsVariable.Schollname + "')";
        dss2 = glb.GetDataSet(sql);
        GridView2.DataSource = dss2;
        GridView2.DataBind();
    }

}