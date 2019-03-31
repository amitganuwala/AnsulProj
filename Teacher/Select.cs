using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public class Select
{
    //Data Source=localhost;Persist Security Info=True;Initial Catalog=;User ID=;Password=

 /SqlConnection con = new SqlConnection(ClsVariable.ConnectionString);

   // SqlConnection con = new SqlConnection("Data Source=DESKTOP-S18BO4A\\SQLEXPRESS;Initial Catalog=totalschooll");
   //SqlConnection con = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
    SqlCommand com;
    DataSet ds = new DataSet();
    SqlDataAdapter Adapter;
    SqlDataReader reader;
 
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

    public DataSet selectitemdet(string p)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from classsection where class='" + p + "'", con);
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

    public DataSet selectitemsub(string p,string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from subject where name='" + p + "' and school='"+a+"' ", con);
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
            com = new SqlCommand("select * from event where school='" + p + "' Order By id DESC", con);
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
            com = new SqlCommand("select * from notice where school='" + p + "' Order By id DESC", con);
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

    public DataSet selectitemhome(string p,string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where school='" + p + "' and addtch= '" + a + "' Order By id DESC", con);
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


    public DataSet selectimetbl(string p,string a,string b)
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

    string GetDate = DateTime.Now.ToString("dd/MM/yyyy");
    string b = "All";
    public DataSet selectitemnotice(string p,string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from notice where duedate>='"+GetDate+"' and school='" + p + "' and (class='" + a + "' or class='" + b + "') Order By id DESC", con);
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

    public DataSet selectitemhomwk(string p,string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from hw where subdate>='"+GetDate+"' and school='" + p + "' and class='" + a + "' Order By id DESC", con);
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
    
    public DataSet selectitemevent(string p,string a)
    {
        try
        {
            con.Open();
            com = new SqlCommand("select * from event where date>='"+GetDate+"' and school='" + p + "'and (class='" + a + "' or class='" + b + "') Order By id DESC ", con);
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

    public DataSet selectimeses(object p)
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
            com = new SqlCommand("select * from event where school='" + p + "' Order By id DESC ", con);
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
            com = new SqlCommand("select * from notice where school='" + a + "' and (class='" + p + "' or class='" + all + "') Order By id DESC", con);
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
            com = new SqlCommand("select * from hw where school='" + a + "' and class='" + p + "' Order By id DESC", con);
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
            com = new SqlCommand("select * from event where school='" + p + "' and (class='" + p_2 + "' or class='"+all+"') Order By id DESC", con);
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
            com = new SqlCommand("select * from hw where school='" + p + "' ", con);
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
}
