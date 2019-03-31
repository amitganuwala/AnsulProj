using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class apk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btndownload_Click(object sender, EventArgs e)
    {
        Response.ContentType = "Application/ApkFile";
        Response.AppendHeader("Content-Disposition", "attachment; filename=MySchoolMateV1.apk");
        Response.TransmitFile(Server.MapPath("docs/MySchoolMateV1.apk"));
        Response.End();
    }
}