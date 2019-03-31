using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing.Printing;
using System.Text;

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
        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        ////   SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        //objcon.Open();
        //SqlCommand objcom = new SqlCommand("spnotice", objcon);
        //objcom.CommandType = CommandType.StoredProcedure;

        //SqlParameter objmaincat = new SqlParameter();
        //objmaincat.ParameterName = "@class";
        //objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        //objmaincat.Value = DropDownList1.SelectedValue; ;
        //objcom.Parameters.Add(objmaincat);

        //SqlParameter obphoto = new SqlParameter();
        //obphoto.ParameterName = "@school";
        //obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        //obphoto.Value = lblsch.Text;
        //objcom.Parameters.Add(obphoto);

        //SqlParameter objame = new SqlParameter();
        //objame.ParameterName = "@notice";
        //objame.SqlDbType = System.Data.SqlDbType.NVarChar;
        //objame.Value = txtsub.Text;
        //objcom.Parameters.Add(objame);

        //SqlParameter objames = new SqlParameter();
        //objames.ParameterName = "@adfrom";
        //objames.SqlDbType = System.Data.SqlDbType.NVarChar;
        //objames.Value = lbltchnm.Text;
        //objcom.Parameters.Add(objames);

        //SqlParameter objamed = new SqlParameter();
        //objamed.ParameterName = "@duedt";
        //objamed.SqlDbType = System.Data.SqlDbType.NVarChar;
        //objamed.Value = txtdate.Text;
        //objcom.Parameters.Add(objamed);

        //string a = System.DateTime.Now.ToString("dd/MM/yyyy");
        //SqlParameter objam = new SqlParameter();
        //objam.ParameterName = "@date";
        //objam.SqlDbType = System.Data.SqlDbType.NVarChar;
        //objam.Value = a.ToString();
        //objcom.Parameters.Add(objam);

        //string message1 = " Notice Added Successfully...! ";
        //string script = "window.onload = function(){ alert('";
        //script += message1;
        //script += "');";
        //script += "window.location = '";
        //script += Request.Url.AbsoluteUri;
        //script += "'; }";
        //ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        //objcom.ExecuteNonQuery();
        //// Response.Write("Created Successfully");
        //objcon.Close();


        //if (sendtxt.Checked == true)
        //{
        //    if (DropDownList1.SelectedValue == "All")
        //    {
        //        for (int i = 0; i < GridView3.Rows.Count; i++)
        //        {

        //            if ((Select.sendsms(GridView3.Rows[i].Cells[1].Text, txtsub.Text,txtdate.Text,lblsch.Text)) == true)
        //            {
        //                Class1.WebMsgBox.Show("SMS Sent");
        //            }
        //        }
        //    }
        //    else
        //    {

        //        for (int i = 0; i < GridView2.Rows.Count; i++)
        //        {
        //            if ((Select.sendsms(GridView2.Rows[i].Cells[1].Text,txtsub.Text,txtdate.Text,lblsch.Text)) == true)
        //            {
        //                Class1.WebMsgBox.Show("SMS Sent");
        //            }
        //        }
        //    }

        //}
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=attendance.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw = new HtmlTextWriter(stringWriter);
        GridView1.RenderControl(htw);
        Response.Write(stringWriter.ToString());
        Response.End();
    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=class-section.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter1 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw1 = new HtmlTextWriter(stringWriter1);
        GridView2.RenderControl(htw1);
        Response.Write(stringWriter1.ToString());
        Response.End();
    }
    protected void btn2_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=class-teacher.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter2 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw2 = new HtmlTextWriter(stringWriter2);
        GridView3.RenderControl(htw2);
        Response.Write(stringWriter2.ToString());
        Response.End();
    }
    protected void btn3_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=event.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter3 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw3 = new HtmlTextWriter(stringWriter3);
        GridView4.RenderControl(htw3);
        Response.Write(stringWriter3.ToString());
        Response.End();
    }
    protected void btn4_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=homework.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter4 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw4 = new HtmlTextWriter(stringWriter4);
        GridView5.RenderControl(htw4);
        Response.Write(stringWriter4.ToString());
        Response.End();
    }
    protected void btn5_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=fees.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter5 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw5 = new HtmlTextWriter(stringWriter5);
        GridView6.RenderControl(htw5);
        Response.Write(stringWriter5.ToString());
        Response.End();
    }
    protected void btn6_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=notice.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter6 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw6 = new HtmlTextWriter(stringWriter6);
        GridView7.RenderControl(htw6);
        Response.Write(stringWriter6.ToString());
        Response.End();
    }
    protected void btn7_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=parent.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter7 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw7 = new HtmlTextWriter(stringWriter7);
        GridView8.RenderControl(htw7);
        Response.Write(stringWriter7.ToString());
        Response.End();
    }
    protected void btn8_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=principal.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter8 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw8 = new HtmlTextWriter(stringWriter8);
        GridView9.RenderControl(htw8);
        Response.Write(stringWriter8.ToString());
        Response.End();
    }
    protected void btn9_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=school-admin.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter9 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw9 = new HtmlTextWriter(stringWriter9);
        GridView10.RenderControl(htw9);
        Response.Write(stringWriter9.ToString());
        Response.End();
    }
    protected void btn10_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=school-info.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter10 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw10 = new HtmlTextWriter(stringWriter10);
        GridView11.RenderControl(htw10);
        Response.Write(stringWriter10.ToString());
        Response.End();
    }
    protected void btn11_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=subject.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter11 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw11 = new HtmlTextWriter(stringWriter11);
        GridView12.RenderControl(htw11);
        Response.Write(stringWriter11.ToString());
        Response.End();
    }
    protected void btn12_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=subject-info.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter12 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw12 = new HtmlTextWriter(stringWriter12);
        GridView13.RenderControl(htw12);
        Response.Write(stringWriter12.ToString());
        Response.End();
    }
    protected void btn13_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=teacher.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter13 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw13 = new HtmlTextWriter(stringWriter13);
        GridView14.RenderControl(htw13);
        Response.Write(stringWriter13.ToString());
        Response.End();
    }
    protected void btn14_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=timetable.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter14 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw14 = new HtmlTextWriter(stringWriter14);
        GridView15.RenderControl(htw14);
        Response.Write(stringWriter14.ToString());
        Response.End();
    }

    protected void btn15_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=alert.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter15 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw15 = new HtmlTextWriter(stringWriter15);
        GridView16.RenderControl(htw15);
        Response.Write(stringWriter15.ToString());
        Response.End();
    }
    protected void btn16_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=blog.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter16 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw16 = new HtmlTextWriter(stringWriter16);
        GridView17.RenderControl(htw16);
        Response.Write(stringWriter16.ToString());
        Response.End();
    }
    protected void btn17_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=course.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter17 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw17 = new HtmlTextWriter(stringWriter17);
        GridView18.RenderControl(htw17);
        Response.Write(stringWriter17.ToString());
        Response.End();
    }
    protected void btn18_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=leave.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter18 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw18 = new HtmlTextWriter(stringWriter18);
        GridView19.RenderControl(htw18);
        Response.Write(stringWriter18.ToString());
        Response.End();
    }
    protected void btn19_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=login.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter19 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw19 = new HtmlTextWriter(stringWriter19);
        GridView20.RenderControl(htw19);
        Response.Write(stringWriter19.ToString());
        Response.End();
    }
    protected void btn20_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=news.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter20 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw20 = new HtmlTextWriter(stringWriter20);
        GridView21.RenderControl(htw20);
        Response.Write(stringWriter20.ToString());
        Response.End();
    }
    protected void btn22_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=pic.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter22 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw22 = new HtmlTextWriter(stringWriter22);
        GridView22.RenderControl(htw22);
        Response.Write(stringWriter22.ToString());
        Response.End();
    }
    protected void btn21_Click(object sender, EventArgs e)
    {
        // Clear all content output from the buffer stream
        Response.ClearContent();
        // Specify the default file name using "content-disposition" RESPONSE header
        Response.AppendHeader("content-disposition", "attachment; filename=tchmsg.xls");
        // Set excel as the HTTP MIME type
        Response.ContentType = "application/excel";
        // Create an instance of stringWriter for writing information to a string
        System.IO.StringWriter stringWriter21 = new System.IO.StringWriter();
        // Create an instance of HtmlTextWriter class for writing markup 
        // characters and text to an ASP.NET server control output stream
        HtmlTextWriter htw21 = new HtmlTextWriter(stringWriter21);
        GridView23.RenderControl(htw21);
        Response.Write(stringWriter21.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        return;
    }
}

