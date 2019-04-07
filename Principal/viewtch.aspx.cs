using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal_viewtch : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();

    ClsGlobal glb = new ClsGlobal();
    SqlConnection conn = new SqlConnection(ClsVariable.ConnectionString);
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        // displaypic();

    }
    public void Sessioninfo()
    {
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];


        if (myCookiepr != null)
        {

            string userId = myCookiepr["prnm"];

            string sql = "select * from principal where usr = '" + userId + "'";
            dss = glb.GetDataSet(sql);


         


            if (dss.Tables[0].Rows.Count == 1)
            {
                // lblprinm.Text = dss.Tables[0].Rows[0]["namr"].ToString();
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

                Response.Redirect("../Principallogin.aspx");
            }

            if (!IsPostBack)
            {
                fillGridView1(lblsch.Text);

            }

        }


    }


    public void fillGridView1(string school_nm)
    {
        string sql = "SELECT * FROM [teacher] WHERE ([school] = '"+school_nm+"')";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillGridView1(lblsch.Text);

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //NewEditIndex property used to determine the index of the row being edited.  
        GridView1.EditIndex = e.NewEditIndex;
        fillGridView1(lblsch.Text);
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {


        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;

        string txtname = e.NewValues["name"].ToString();
        string txtpost = (String)e.NewValues["post"];
        string txtaddr = (String)e.NewValues["addr"];
        string txtmob = (String)e.NewValues["mob"];
        string txtusr = row.Cells[6].Text;
        string txtpass = (String)e.NewValues["pass"];
        string txtschool= (String)e.NewValues["school"];

        GridView1.EditIndex = -1;

        conn.Open();

        string sql = "UPDATE [teacher] SET  [name] = '"+txtname+"', [post] = '"+txtpost+"', [addr] = '"+txtaddr+"', [mob] = '"+txtmob+"', [pass] = '"+txtpass+"', [school] = '"+txtschool+"' WHERE[usr] = '"+txtusr+"'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        fillGridView1(lblsch.Text);

    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];
        string userId = myCookiepr["prnm"];


        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;
        string name = row.Cells[2].Text;
        string classs = row.Cells[3].Text;
        string subject = row.Cells[4].Text;
        string school = row.Cells[8].Text;



        // Label lbldeleteid = (Label)row.FindControl("lblID");
        conn.Open();
        string sql = "DELETE FROM teacher WHERE (id = '"+ id + "' and school='" + school+"')";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        // gvbind();
        fillGridView1(lblsch.Text);
    }
}
