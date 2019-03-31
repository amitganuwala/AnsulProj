using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class pr_single : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.singleblog(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
            img.ImageUrl = "~/Teacher/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            title.Text = ds.Tables[0].Rows[0]["title"].ToString();
            date.Text = ds.Tables[0].Rows[0]["date"].ToString();
            school.Text = ds.Tables[0].Rows[0]["school"].ToString();
            descr.Text = ds.Tables[0].Rows[0]["message"].ToString();
            tchnm.Text = ds.Tables[0].Rows[0]["addnm"].ToString();
            subject.Text = ds.Tables[0].Rows[0]["subject"].ToString();
           // string a = ds.Tables[0].Rows[0]["pic"].ToString();
            if (ds.Tables[0].Rows[0]["pic"].ToString() == "")
            {
                img.Visible = false;
                st.Visible = true;
                st.Text = "NO IMAGE AVAILABLE...";
            }
        }
    }
    
    protected void accept_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spapp", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        string st = "Active";
        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@st";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = st.ToString();
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmaicat = new SqlParameter();
        objmaicat.ParameterName = "@id";
        objmaicat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaicat.Value = lblid.Text;
        objcom.Parameters.Add(objmaicat);

        string message1 = " Blog Approved Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        Response.Redirect("~/Principal/Copy of blog.aspx");
        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();
    }
    protected void reject_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spapp", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        string st = "Inactive";
        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@st";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = st.ToString();
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmaicat = new SqlParameter();
        objmaicat.ParameterName = "@id";
        objmaicat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaicat.Value = lblid.Text;
        objcom.Parameters.Add(objmaicat);

        string message1 = " Blog Rejected...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        Response.Redirect("~/Principal/Copy of blog.aspx");
        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();
    }
}