using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Principal_view_leave : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();
        // fill();
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectviewleave(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
            lblid.Text = ds.Tables[0].Rows[0]["id"].ToString();
            pname.Text = ds.Tables[0].Rows[0]["pnm"].ToString();
            pnm1.Text = ds.Tables[0].Rows[0]["pnm"].ToString();
            stnm.Text = ds.Tables[0].Rows[0]["snm"].ToString();
            lblsdt.Text = ds.Tables[0].Rows[0]["datest"].ToString();
            lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
            lbltdt.Text = ds.Tables[0].Rows[0]["datetl"].ToString();
            lblrsn.Text = ds.Tables[0].Rows[0]["reason"].ToString();
            lblsub.Text = ds.Tables[0].Rows[0]["subject"].ToString();
            lbldays.Text = ds.Tables[0].Rows[0]["day"].ToString();
            lblsch1.Text = ds.Tables[0].Rows[0]["school"].ToString();
            lblsch.Text = ds.Tables[0].Rows[0]["school"].ToString();

        }
    }


    protected void accept_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("splap", objcon);
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

        string message1 = " News Approved Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        Response.Redirect("~/Principal/lvapp.aspx");
        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();
    }
    protected void reject_Click(object sender, EventArgs e)
    {

        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("splap", objcon);
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

        string message1 = " News Rejected...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        Response.Redirect("~/Principal/lvapp.aspx");
        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();
    }
}