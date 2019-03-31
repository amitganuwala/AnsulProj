using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal_teacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         ViewProfile();
         fillItem();
    }

    public void fillItem()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemsub(lblname.Text,lblsch.Text);
        rptitem.DataSource = ds.Tables[0];
        rptitem.DataBind();
    }

    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectitemdetteacher(Convert.ToInt32(Request.QueryString["id"].ToString()));
        if (ds.Tables[0].Rows.Count == 1)
        {
            lblsch.Text = ds.Tables[0].Rows[0]["school"].ToString();
            lblname.Text = ds.Tables[0].Rows[0]["name"].ToString();
            lblpost.Text = ds.Tables[0].Rows[0]["post"].ToString();
            lbladdr.Text = ds.Tables[0].Rows[0]["addr"].ToString();
            lblmob.Text = ds.Tables[0].Rows[0]["mob"].ToString();
            id.Text = ds.Tables[0].Rows[0]["id"].ToString();
            img.ImageUrl = "~/Principal/img/" + ds.Tables[0].Rows[0]["pic"].ToString();
        }
    
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spuptea", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

       
        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@addr";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = txtaddr.Text;
        objcom.Parameters.Add(objname);

        SqlParameter objnamew = new SqlParameter();
        objnamew.ParameterName = "@id";
        objnamew.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnamew.Value = id.Text;
        objcom.Parameters.Add(objnamew);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@mob";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = txtmob.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objphot = new SqlParameter();
        objphot.ParameterName = "@pass";
        objphot.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphot.Value = txtpass.Text;
        objcom.Parameters.Add(objphot);

        SqlParameter objincat = new SqlParameter();
        objincat.ParameterName = "@school";
        objincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objincat.Value = lblsch.Text;
        objcom.Parameters.Add(objincat);

        string message1 = " Information updated Successfully...! ";
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
}