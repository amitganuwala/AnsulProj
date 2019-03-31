using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Net;
public class Select
{
    private static string smssenderid = "TTLSCH";
    private static string smsusername = "totalschool";
    private static string smspassword = "*anshul*1";

    public static string smsstring = "http://sms1.smsresellers.info/websms/sendsms.aspx"; 

    

    public static bool sendsms(string mobileno, string smstxt, string date, string sch)
    {
        
        bool result = false;
        try
        {
            string msg = " '" + smstxt + "' '" + date + "'. -Regards '" + sch + "'.";
            mobileno = mobileno.Replace("+91", ""); 
            mobileno = mobileno.Replace(" ", ""); 
            string formvariables = "?userid=" + smsusername + "&password=" + smspassword + "&sender=" + smssenderid + "&mobileno=" + mobileno + "&msg=" + msg + "&msgtype=1";
            result = GetResponse(smsstring + formvariables);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message.ToString());
        }
        return result;
    }
    public static bool sendatt(string mobileno, string smstxt, string date, string sch)
    {

        bool result = false;
        try
        {
            string msg = "Dear student,  We missed you in the class today ('" + date + "'). We believe all  ​i​s well and hope to see you tomorrow  for more new learnings and fun at school.  Head Mistress, '" + sch + "'";
            //  "Your child is '" + smstxt + "' on '" + date + "'. -Regards '" + sch + "'.";
            mobileno = mobileno.Replace("+91", ""); 
            mobileno = mobileno.Replace(" ", "");
            string formvariables = "?userid=" + smsusername + "&password=" + smspassword + "&sender=" + smssenderid + "&mobileno=" + mobileno + "&msg=" + msg + "&msgtype=1";
            result = GetResponse(smsstring + formvariables);
        }
        catch (Exception ex)
        {

        }
        return result;
    }

    public static bool sendalert(string mobileno, string smstxt, string sch)
    {
        
        bool result = false;
        try
        {
            string msg = " '" + smstxt +   "'. -Regards '" + sch + "'.";
            mobileno = mobileno.Replace("+91", ""); // replace country code
            mobileno = mobileno.Replace(" ", ""); // replace spaces
            string formvariables = "?userid=" + smsusername + "&password=" + smspassword + "&sender=" + smssenderid + "&mobileno=" + mobileno + "&msg=" + msg + "&msgtype=1";
            result = GetResponse(smsstring + formvariables);
        }
        catch (Exception ex)
        {

        }
        return result;
    }

    
    public static bool sendsmsidpass(string mobileno, string smsusr, string pass, string sch)
    {

        bool result = false;
        try
        {
            string msg = "Thank you for enrolling in myschoolmate.net from now on you will recieve all schools notices through these app please install it through following link http://www.myschoolmate.net/apk.aspx and use it through following UserId - '" + smsusr + "' and Password - '" + pass + "'.  -Regards '" + sch + "' .";
            mobileno = mobileno.Replace("+91", ""); // replace country code
            mobileno = mobileno.Replace(" ", ""); // replace spaces
            string formvariables = "?userid=" + smsusername + "&password=" + smspassword + "&sender=" + smssenderid + "&mobileno=" + mobileno + "&msg=" + msg + "&msgtype=1";
            result = GetResponse(smsstring + formvariables);
        }
        catch (Exception ex)
        {

        }
        return result;
    }

    public static bool GetResponse(string sURL)
    {
        HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(sURL);
        httpReq.MaximumAutomaticRedirections = 4;
        httpReq.Credentials = CredentialCache.DefaultCredentials;
        try
        {
            httpReq.AllowAutoRedirect = true;
            httpReq.Method = "GET";
            httpReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Trident/7.0; rv:11.0) like Gecko";

            HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();
            Stream receiveStream = httpRes.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string sResponse = readStream.ReadToEnd();
            httpRes.Close();
            readStream.Close();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }


    //Data Source=localhost;Persist Security Info=True;Initial Catalog=;User ID=;Password=

    SqlConnection con = new SqlConnection(ClsVariable.ConnectionString);

    //SqlConnection con = new SqlConnection("Data Source=DESKTOP-S18BO4A\\SQLEXPRESS;Initial Catalog=totalschooll");
   //SqlConnection con = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
    SqlCommand com;
    DataSet ds = new DataSet();
    SqlDataAdapter Adapter;
    SqlDataReader reader;
    string stat = "Active";
    public System.Data.DataSet selectitem()
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from classsection Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "classsection");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemdet(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from classsection where id='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "classsection");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemdetteacher(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from teacher where id='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "teacher");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemsub(string p, string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from subject where name='" + p + "' and school='" + a + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "subject");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemevent(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where school='" + p + "' and status='"+stat+"' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemtrip()
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from trip Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "trip");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemnotice(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where school='" + p + "' and status='" + stat + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemhome(string p, string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where school='" + p + "' and addtch= '" + a + "' and status='" + stat + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "hw");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemdetevent(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where id='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemdetnotice(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where id='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemdethomework(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where id='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "hw");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemdettrip(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from trip where id='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "trip");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }


    public DataSet selectimetbl(string p, string a, string b)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from subject where subject='" + p + "' and class='" + a + "' and school='" + b + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "subject");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    string GetDate = System.DateTime.Now.ToString("dd/MM/yyyy");
    string b = "All";
    public DataSet selectitemnotice(string p, string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where duedate >='" + GetDate + "' and status='"+stat+"' and school='" + p + "' and (class='" + a + "' or class='" + b + "') Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemhomwk(string p, string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where subdate >='" + GetDate + "' and status='" + stat + "' and school='" + p + "' and class='" + a + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "hw");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemevent(string p, string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where status='" + stat + "' and school='" + p + "'and (class='" + a + "' or class='" + b + "') Order By id DESC ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectimeses(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from teacher where usr='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "teacher");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectimesespar(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from parent where usr='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "parent");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemdetteacherprofile(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from teacher where usr='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "teacher");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectstu(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from parent where usr='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "parent");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemeventparent(string p1, string p2)
    {

        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where school='" + p1 + "' and (class='" + p2 + "' or class='" + b + "')", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectimesespt(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from parent where usr='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "parent");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectschooladmn(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from schooladmin where usr='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "schooladmin");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemstu(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from classsection where school='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "classsection");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }


    public DataSet selectitemeventadmn(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where school='" + p + "' and status='" + stat + "' Order By id DESC ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemnoticeadmn(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where school='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectimesespr(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from principal where usr='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "principal");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectimesesprin(object p)
    {
        throw new NotImplementedException();
    }

    public DataSet selectitemevent()
    {
        throw new NotImplementedException();
    }

    public DataSet schoolpic(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from schoolinfo where schoolname='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "schoolinfo");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectatt(string p, string a, string b)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from attendance where school='" + p + "' and class='" + a + "' and name='" + b + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "attendance");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }
    string all = "All";
    public DataSet selectparentnotice(string p, string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where school='" + a + "' and status='" + stat + "' and (class='" + p + "' or class='" + all + "') Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }
    
    public DataSet selectparenthome(string p, string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where ((school='" + a + "') and (class='" + p + "') and (status='"+stat+"')) Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "hw");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemparevent(string p, string p_2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where school='" + p + "' and status='" + stat + "' and (class='" + p_2 + "' or class='" + all + "') Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectprinci(object p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from principal where usr='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "principal");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectpic(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from schoolinfo where schoolname='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "schoolinfo");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemhome(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where school='" + p + "' and status='" + stat + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "hw");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitem(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from classsection where school='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "classsection");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet tchttl(string p, string p_2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where school='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "classsection");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectnews()
    {
        //throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from news Order By id DESC ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "news");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }
    string st = "Active";
    public DataSet selectblog()
    {
        //throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from blog where status = '" + st + "' Order By id DESC ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "blog");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectalerts(string p, string p_2)
    {
        //throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from alert where school='"+p+"' and tname='"+p_2+"' Order By id DESC ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "alert");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet monl1(string p, string p_2, string p2)
    {
        // throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d1l1tch = '" + p + "' and school = '" + p_2 + "'  ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }
    public DataSet monl2(string p, string p_2, string p2)
    {
        // throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d1l2tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }


    public DataSet monl3(string p, string p_2, string p2)
    {
        // throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d1l3tch = '" + p + "' and school = '" + p_2 + "'  ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }


    public DataSet monl4(string p, string p_2, string p2)
    {
        // throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d1l4tch = '" + p + "' and school = '" + p_2 + "'  ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }


    public DataSet monl5(string p, string p_2, string p2)
    {
        // throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d1l5tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }


    public DataSet monl6(string p, string p_2, string p2)
    {
        // throw new System.NotImplementedException();
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d1l6tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet tuel1(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d2l1tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }


    public DataSet tuel2(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d2l2tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet tuel3(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d2l3tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet tuel4(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d2l4tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet tuel5(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d2l5tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet tuel6(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d2l6tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet wedl1(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d3l1tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }


    public DataSet wedl2(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d3l2tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }


    public DataSet wedl3(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d3l3tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }


    public DataSet wedl4(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d3l4tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }


    public DataSet wedl5(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d3l5tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }


    public DataSet wedl6(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d3l6tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }

    public DataSet thu1(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d4l1tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet thu2(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d4l2tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet thu3(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d4l3tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet thu4(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d4l4tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet thu5(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d4l5tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet thu6(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d4l6tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }



    public DataSet fri1(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d5l1tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet fri2(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d5l2tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet fri3(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d5l3tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet fri4(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d5l4tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet fri5(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d5l5tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet fri6(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d5l6tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }


    public DataSet sat1(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d6l1tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet sat2(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d6l2tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet sat3(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d6l3tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet sat4(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d6l4tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet sat5(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d6l5tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }
    public DataSet sat6(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where d6l6tch = '" + p + "' and school = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        // throw new System.NotImplementedException();
    }

    public DataSet timetbl(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from timetable where school = '" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "timetable");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }

    public DataSet prhome(string p,string p2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where school = '" + p + "' and adddate = '" + p2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "hw");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }


    public DataSet prnotice(string p, string p2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where school = '" + p + "' and date = '" + p2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }

    public DataSet prevent(string p, string p2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where school = '" + p + "'  ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }

    public DataSet prcourse(string p, string p2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from course where school = '" + p + "' and date = '" + p2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "course");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
        //throw new System.NotImplementedException();
    }
    string inst = "Inactive";
    public DataSet selectblogin()
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from blog where status = '" + inst + "' ORDER By id DESC ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "blog");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet singleblog(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from blog where id = '" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "blog");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet coursedet(string p, string p_2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from course where school = '" + p + "' and tchnm = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "course");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemparfees(string p, string p_2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from fees where school = '" + p + "' and class = '" + p_2 + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "fees");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    string un = "Pending";
    public DataSet selectapphw(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where school = '" + p + "' and status = '" + un + "'Order By id DESC ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "hw");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectappno(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where school = '" + p + "' and status = '" + un + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectappev(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where school = '" + p + "' and status = '" + un + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectgallery( string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from pic where eid = '" + p + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "pic");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectgalleryfull(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where school='"+p+"' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }


    public DataSet selectmsg(string p, string p_2,string p3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from tchmsg where (name='"+p+"') and (school='"+p_2+"') and (class='"+p3+"') Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "tchmsg");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet picsingle(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from pic where id='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "pic");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet picdet(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where id='" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectleave(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from leave where school='" + p + "' and st='"+un+"' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "leave");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectviewleave(int p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from leave where id='"+p+"' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "leave");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectblogfeatured()
    {
        try
        {
            con.Open();
            com = new SqlCommand("select top 4 * from blog ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "blog");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet singlenews(int p)
    {
        
        try
        {
            con.Open();
            com = new SqlCommand("select * from news where id = '" + p + "' ", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "news");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
   
    }

    public DataSet selectitemnotice1(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where date >='" + p + "' and status='" + stat + "' and school='" + p_2 + "' and class='" + p_3 + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "notice");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemhomwk1(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where subdate >='" + p + "' and status='" + stat + "' and school='" + p_2 + "' and class='" + p_3 + "' Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "hw");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectitemevent1(string p, string p_2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where date >='" + p + "' and status='" + stat + "' and school='" + p_2 + "'  Order By id DESC", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "event");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectgalleryful(string p)
    {

        try
        {
            con.Open();
            com = new SqlCommand("select * from pic where enm='" + p + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "pic");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectatten(string p, string p_2, string p_3,string p3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from attendance where date='" + p + "' and school='"+p_2+"' and class='"+p_3+"' and name='"+p3+"'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "pic");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectlv(string p, string p_2)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from leave where snm='" + p + "' and school='" + p_2 + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "leave");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectpatt(string p, string p_2, string p_3,string p3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from attendance where name='" + p + "' and class='" + p_2 + "' and school='"+p_3+"' and date='"+p3+"'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "attendance");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet selectplv(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from leave where snm='" + p + "' and class='" + p_2 + "' and school='" + p_3 + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "leave");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }

    string apppppp = "Active";
    public DataSet selectplvap(string p, string p_2, string p_3)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from leave where snm='" + p + "' and st='"+apppppp+"' and class='" + p_2 + "' and school='" + p_3 + "'", con);
            Adapter = new SqlDataAdapter(com);
            Adapter.Fill(ds, "leave");
            return ds;
            throw new NotImplementedException();
        }
        finally
        {
            con.Close();
        }
    }
}