using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class School_addnotice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Sessioninfo();
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
    protected void btnadd_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //   SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spnotice", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@class";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = DropDownList1.SelectedValue; ;
        objcom.Parameters.Add(objmaincat);

        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        SqlParameter objame = new SqlParameter();
        objame.ParameterName = "@notice";
        objame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objame.Value = txtsub.Text;
        objcom.Parameters.Add(objame);

        SqlParameter objames = new SqlParameter();
        objames.ParameterName = "@adfrom";
        objames.SqlDbType = System.Data.SqlDbType.NVarChar;
        objames.Value = lbltchnm.Text;
        objcom.Parameters.Add(objames);

        SqlParameter objamed = new SqlParameter();
        objamed.ParameterName = "@duedt";
        objamed.SqlDbType = System.Data.SqlDbType.NVarChar;
        objamed.Value = txtdate.Text;
        objcom.Parameters.Add(objamed);

        string a = System.DateTime.Now.ToString("dd/MM/yyyy");
        SqlParameter objam = new SqlParameter();
        objam.ParameterName = "@date";
        objam.SqlDbType = System.Data.SqlDbType.NVarChar;
        objam.Value = a.ToString();
        objcom.Parameters.Add(objam);

        string message1 = " Notice Added Successfully...! ";
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


        if (sendtxt.Checked == true)
        {
            if (DropDownList1.SelectedValue == "All")
            {
                for (int i = 0; i < GridView3.Rows.Count; i++)
                {

                    if ((Select.sendsms(GridView3.Rows[i].Cells[1].Text, txtsub.Text,txtdate.Text,lblsch.Text)) == true)
                    {
                        Class1.WebMsgBox.Show("SMS Sent");
                    }
                }
            }
            else
            {

                for (int i = 0; i < GridView2.Rows.Count; i++)
                {
                    if ((Select.sendsms(GridView2.Rows[i].Cells[1].Text,txtsub.Text,txtdate.Text,lblsch.Text)) == true)
                    {
                        Class1.WebMsgBox.Show("SMS Sent");
                    }
                }
            }

        }
    }

}

