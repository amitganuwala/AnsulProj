using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Principal_apphw : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         ViewProfile();
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemdethomework(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
            img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            lbltitle.Text = ds.Tables[0].Rows[0]["hw"].ToString();
            lbldate.Text = ds.Tables[0].Rows[0]["subject"].ToString();
               lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
            lbldescr.Text = ds.Tables[0].Rows[0]["hw"].ToString();
            lbladtch.Text = ds.Tables[0].Rows[0]["addtch"].ToString();
            lbladdt.Text = ds.Tables[0].Rows[0]["adddate"].ToString();
            //lblschool.Text = ds.Tables[0].Rows[0]["school"].ToString();
            if (ds.Tables[0].Rows[0]["pic"].ToString() == "")
            {
                img.Visible = false;
                st.Text = "NO IMAGE AVAILABLE...";
            }
        }
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (true)
        {
            SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
            //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
            objcon.Open();
            SqlCommand objcom = new SqlCommand("spuphw", objcon);
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
            SqlCommand objcom = new SqlCommand("spuphw", objcon);
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
}