using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal_student : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();

    ClsGlobal glb = new ClsGlobal();
    SqlConnection conn = new SqlConnection(ClsVariable.ConnectionString);
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        ViewProfile();

        if (lblclass.Text == "All")
        {
            GridView1.Visible = false;
            GridView2.Visible = true;
        }
        else
        {
            GridView1.Visible = true;
            GridView2.Visible = false;
        }
    }

    public void ViewProfile()
    {
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];


        if (myCookiepr != null)
        {

            string userId = myCookiepr["prnm"];

            //"select * from classsection where id='" + p + "'", con

            string sql = "select * from classsection where id='" + Convert.ToInt32(Request.QueryString["id"].ToString()) + "'";
            ds = glb.GetDataSet(sql);

            //Select sels = new Select();
            //ds = sels.selectitemdet(Convert.ToInt32(Request.QueryString["id"].ToString()));
            if (ds.Tables[0].Rows.Count == 1)
            {
                lblclass.Text = ds.Tables[0].Rows[0]["class"].ToString();
                lblsch.Text = ds.Tables[0].Rows[0]["school"].ToString();
            }

            if(!IsPostBack)
            {
                fillGridView2(lblsch.Text);
                fillGridView1(lblclass.Text,lblsch.Text);
               
            }

        }
    }

    public void fillGridView1(string class_nm, string school_nm)
    {
        string sql = "SELECT [name], [class], [usr], [pass], [mob], [id] FROM [parent] WHERE (([class] = '" + class_nm + "') AND ([school] = '" + school_nm + "')) ORDER BY [name]";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }

    public void fillGridView2(string school_nm)
    {
        string sql = "SELECT [id], [name], [mob], [usr], [pass] FROM [parent] WHERE ([school] = '"+school_nm+"') ORDER BY [name]";
        dss2 = glb.GetDataSet(sql);
        GridView2.DataSource = dss2;
        GridView2.DataBind();
    }

  



    protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        fillGridView1(lblclass.Text, lblsch.Text);
    }

    protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[6].Text;

        string name = (String)e.NewValues["name"];
        string classs = (String)e.NewValues["class"];
        string usr = (String)e.NewValues["usr"];
        string pass = (String)e.NewValues["pass"];
        string mob = (String)e.NewValues["mob"];

        GridView1.EditIndex = -1;

        conn.Open();
        string sql = "UPDATE parent SET usr = '"+usr+"' WHERE (id = '"+id+"')";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        fillGridView1(lblclass.Text, lblsch.Text);
    }

    protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillGridView1(lblclass.Text, lblsch.Text);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[6].Text;
        string name = row.Cells[1].Text;
        string classs = row.Cells[2].Text;
        string usr = row.Cells[3].Text;
        string pass= row.Cells[4].Text;
        string mob = row.Cells[5].Text;
        // string



        // Label lbldeleteid = (Label)row.FindControl("lblID");
        conn.Open();
        string sql = "DELETE FROM [parent] WHERE [id] = '" + id + "' AND (([name] = '" + name + "') OR ([name] IS NULL AND '" + name + "' IS NULL)) AND (([class] = '" + classs + "') OR ([class] IS NULL AND '" + classs + "' IS NULL)) AND [usr] = '" + usr + "' AND [pass] = '" + pass + "' AND (([mob] = '" + mob + "') OR ([mob] IS NULL AND '" + mob + "' IS NULL))";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        // gvbind();
        fillGridView1(lblclass.Text, lblsch.Text);
    }

    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        fillGridView2(lblsch.Text);
    }

    protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];
        string id = row.Cells[1].Text;

        string name = (String)e.NewValues["name"];
        string mob = (String)e.NewValues["mob"];
        string usr = (String)e.NewValues["usr"];
        string pass = (String)e.NewValues["pass"];
        GridView2.EditIndex = -1;

        conn.Open();
        string sql = "UPDATE parent SET mob = '"+mob+"', usr = '"+usr+"', pass = '"+pass+"' WHERE (id = '"+id+"')";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        fillGridView2(lblsch.Text);
    }

    protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillGridView2(lblsch.Text);
    }

    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;
        string name = row.Cells[2].Text;
        string mob = row.Cells[3].Text;
        string usr = row.Cells[4].Text;
        string pass = row.Cells[5].Text;
        // string



        // Label lbldeleteid = (Label)row.FindControl("lblID");
        conn.Open();
        string sql = "DELETE FROM [parent] WHERE [id] = '"+id+"' AND (([name] = '"+name+"') OR ([name] IS NULL AND '"+name+"' IS NULL)) AND (([mob] = '"+mob+"') OR ([mob] IS NULL AND '"+mob+"' IS NULL)) AND [usr] = '"+usr+"' AND [pass] = '"+pass+"'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        // gvbind();
        fillGridView2(lblsch.Text);
    }
}