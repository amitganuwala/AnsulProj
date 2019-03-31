<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="download.aspx.cs" Inherits="School_addnotice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right">
                </i>DOWNLOAD...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">

    <asp:Button runat="server" ID="btn" Text="Download" onclick="btn_Click"  /> <asp:Button runat="server" ID="btn1" Text="Download1" onclick="btn1_Click"  />
<asp:Button runat="server" ID="btn2" Text="Download2" onclick="btn2_Click"  /><asp:Button runat="server" ID="btn3" Text="Download3" onclick="btn3_Click"  />  
<asp:Button runat="server" ID="btn4" Text="Download4" onclick="btn4_Click"  /><asp:Button runat="server" ID="btn5" Text="Download5" onclick="btn5_Click"  /> 
<asp:Button runat="server" ID="btn6" Text="Download6" onclick="btn6_Click"  /><asp:Button runat="server" ID="btn7" Text="Download7" onclick="btn7_Click"  />
<asp:Button runat="server" ID="btn8" Text="Download8" onclick="btn8_Click"  /><asp:Button runat="server" ID="btn9" Text="Download9" onclick="btn9_Click"  />
<asp:Button runat="server" ID="btn10" Text="Download10" onclick="btn10_Click"  /><asp:Button runat="server" ID="btn11" Text="Download11" onclick="btn11_Click"  />
<asp:Button runat="server" ID="btn12" Text="Download12" onclick="btn12_Click"  /><asp:Button runat="server" ID="btn13" Text="Download13" onclick="btn13_Click"  />
<asp:Button runat="server" ID="btn14" Text="Download14" onclick="btn14_Click"  />
<br /><hr /><br />
<asp:Button runat="server" ID="Button1" Text="Download14" onclick="btn15_Click"  /><asp:Button runat="server" ID="Button2" Text="Download14" onclick="btn16_Click"  />
<asp:Button runat="server" ID="Button3" Text="Download14" onclick="btn17_Click"  /><asp:Button runat="server" ID="Button4" Text="Download14" onclick="btn18_Click"  />
<asp:Button runat="server" ID="Button5" Text="Download14" onclick="btn19_Click"  /><asp:Button runat="server" ID="Button6" Text="Download14" onclick="btn20_Click"  />
<asp:Button runat="server" ID="Button7" Text="Download14" onclick="btn21_Click"  /><asp:Button runat="server" ID="Button8" Text="Download14" onclick="btn22_Click"  />
                             <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                    
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource1">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                    <asp:BoundField DataField="status" HeaderText="status" 
                                        SortExpression="status" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="sid" HeaderText="sid" SortExpression="sid" />
                                    <asp:BoundField DataField="daay" HeaderText="daay" SortExpression="daay" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [attendance]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource2">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [classsection]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource3">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [classteacher]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource4">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                                    <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                    <asp:BoundField DataField="descr" HeaderText="descr" SortExpression="descr" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="adddate" HeaderText="adddate" 
                                        SortExpression="adddate" />
                                    <asp:BoundField DataField="addtch" HeaderText="addtch" 
                                        SortExpression="addtch" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [event]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource5">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="subject" HeaderText="subject" 
                                        SortExpression="subject" />
                                    <asp:BoundField DataField="hw" HeaderText="hw" SortExpression="hw" />
                                    <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                                    <asp:BoundField DataField="subdate" HeaderText="subdate" 
                                        SortExpression="subdate" />
                                    <asp:BoundField DataField="adddate" HeaderText="adddate" 
                                        SortExpression="adddate" />
                                    <asp:BoundField DataField="addtch" HeaderText="addtch" 
                                        SortExpression="addtch" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [hw]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource6">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="fees" HeaderText="fees" SortExpression="fees" />
                                    <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [fees]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource7">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="notice" HeaderText="notice" 
                                        SortExpression="notice" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                    <asp:BoundField DataField="adfrom" HeaderText="adfrom" 
                                        SortExpression="adfrom" />
                                    <asp:BoundField DataField="duedate" HeaderText="duedate" 
                                        SortExpression="duedate" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [notice]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource8">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
                                    <asp:BoundField DataField="usr" HeaderText="usr" SortExpression="usr" />
                                    <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="roll" HeaderText="roll" SortExpression="roll" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="religion" HeaderText="religion" 
                                        SortExpression="religion" />
                                    <asp:BoundField DataField="caste" HeaderText="caste" SortExpression="caste" />
                                    <asp:BoundField DataField="subcaste" HeaderText="subcaste" 
                                        SortExpression="subcaste" />
                                    <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                    <asp:BoundField DataField="sgen" HeaderText="sgen" SortExpression="sgen" />
                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                    <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource8" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [parent]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="usr" DataSourceID="SqlDataSource9">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="namr" HeaderText="namr" SortExpression="namr" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="usr" HeaderText="usr" ReadOnly="True" 
                                        SortExpression="usr" />
                                    <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource9" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [principal]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView10" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="usr" DataSourceID="SqlDataSource10">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                    <asp:BoundField DataField="usr" HeaderText="usr" ReadOnly="True" 
                                        SortExpression="usr" />
                                    <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource10" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [schooladmin]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView11" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource11">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="schoolname" HeaderText="schoolname" 
                                        SortExpression="schoolname" />
                                    <asp:BoundField DataField="schooladdr" HeaderText="schooladdr" 
                                        SortExpression="schooladdr" />
                                    <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource11" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [schoolinfo]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView12" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource12">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="subject" HeaderText="subject" 
                                        SortExpression="subject" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource12" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [subject]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView13" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource13">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="snm" HeaderText="snm" SortExpression="snm" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource13" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [subject-info]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView14" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="usr" DataSourceID="SqlDataSource14">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                    <asp:BoundField DataField="post" HeaderText="post" SortExpression="post" />
                                    <asp:BoundField DataField="addr" HeaderText="addr" SortExpression="addr" />
                                    <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                    <asp:BoundField DataField="usr" HeaderText="usr" ReadOnly="True" 
                                        SortExpression="usr" />
                                    <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource14" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [teacher]"></asp:SqlDataSource>
                            <asp:GridView ID="GridView15" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource15">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="lec1" HeaderText="lec1" SortExpression="lec1" />
                                    <asp:BoundField DataField="lec2" HeaderText="lec2" SortExpression="lec2" />
                                    <asp:BoundField DataField="lec3" HeaderText="lec3" SortExpression="lec3" />
                                    <asp:BoundField DataField="lec4" HeaderText="lec4" SortExpression="lec4" />
                                    <asp:BoundField DataField="lec5" HeaderText="lec5" SortExpression="lec5" />
                                    <asp:BoundField DataField="lec6" HeaderText="lec6" SortExpression="lec6" />
                                    <asp:BoundField DataField="day1" HeaderText="day1" SortExpression="day1" />
                                    <asp:BoundField DataField="day2" HeaderText="day2" SortExpression="day2" />
                                    <asp:BoundField DataField="day3" HeaderText="day3" SortExpression="day3" />
                                    <asp:BoundField DataField="day4" HeaderText="day4" SortExpression="day4" />
                                    <asp:BoundField DataField="day5" HeaderText="day5" SortExpression="day5" />
                                    <asp:BoundField DataField="day6" HeaderText="day6" SortExpression="day6" />
                                    <asp:BoundField DataField="d1l1" HeaderText="d1l1" SortExpression="d1l1" />
                                    <asp:BoundField DataField="d1l2" HeaderText="d1l2" SortExpression="d1l2" />
                                    <asp:BoundField DataField="d1l3" HeaderText="d1l3" SortExpression="d1l3" />
                                    <asp:BoundField DataField="d1l4" HeaderText="d1l4" SortExpression="d1l4" />
                                    <asp:BoundField DataField="d1l5" HeaderText="d1l5" SortExpression="d1l5" />
                                    <asp:BoundField DataField="d1l6" HeaderText="d1l6" SortExpression="d1l6" />
                                    <asp:BoundField DataField="d2l1" HeaderText="d2l1" SortExpression="d2l1" />
                                    <asp:BoundField DataField="d2l2" HeaderText="d2l2" SortExpression="d2l2" />
                                    <asp:BoundField DataField="d2l3" HeaderText="d2l3" SortExpression="d2l3" />
                                    <asp:BoundField DataField="d2l4" HeaderText="d2l4" SortExpression="d2l4" />
                                    <asp:BoundField DataField="d2l5" HeaderText="d2l5" SortExpression="d2l5" />
                                    <asp:BoundField DataField="d2l6" HeaderText="d2l6" SortExpression="d2l6" />
                                    <asp:BoundField DataField="d3l1" HeaderText="d3l1" SortExpression="d3l1" />
                                    <asp:BoundField DataField="d3l2" HeaderText="d3l2" SortExpression="d3l2" />
                                    <asp:BoundField DataField="d3l3" HeaderText="d3l3" SortExpression="d3l3" />
                                    <asp:BoundField DataField="d3l4" HeaderText="d3l4" SortExpression="d3l4" />
                                    <asp:BoundField DataField="d3l5" HeaderText="d3l5" SortExpression="d3l5" />
                                    <asp:BoundField DataField="d3l6" HeaderText="d3l6" SortExpression="d3l6" />
                                    <asp:BoundField DataField="d4l1" HeaderText="d4l1" SortExpression="d4l1" />
                                    <asp:BoundField DataField="d4l2" HeaderText="d4l2" SortExpression="d4l2" />
                                    <asp:BoundField DataField="d4l3" HeaderText="d4l3" SortExpression="d4l3" />
                                    <asp:BoundField DataField="d4l4" HeaderText="d4l4" SortExpression="d4l4" />
                                    <asp:BoundField DataField="d4l5" HeaderText="d4l5" SortExpression="d4l5" />
                                    <asp:BoundField DataField="d4l6" HeaderText="d4l6" SortExpression="d4l6" />
                                    <asp:BoundField DataField="d5l1" HeaderText="d5l1" SortExpression="d5l1" />
                                    <asp:BoundField DataField="d5l2" HeaderText="d5l2" SortExpression="d5l2" />
                                    <asp:BoundField DataField="d5l3" HeaderText="d5l3" SortExpression="d5l3" />
                                    <asp:BoundField DataField="d5l4" HeaderText="d5l4" SortExpression="d5l4" />
                                    <asp:BoundField DataField="d5l5" HeaderText="d5l5" SortExpression="d5l5" />
                                    <asp:BoundField DataField="d5l6" HeaderText="d5l6" SortExpression="d5l6" />
                                    <asp:BoundField DataField="d6l1" HeaderText="d6l1" SortExpression="d6l1" />
                                    <asp:BoundField DataField="d6l2" HeaderText="d6l2" SortExpression="d6l2" />
                                    <asp:BoundField DataField="d6l3" HeaderText="d6l3" SortExpression="d6l3" />
                                    <asp:BoundField DataField="d6l4" HeaderText="d6l4" SortExpression="d6l4" />
                                    <asp:BoundField DataField="d6l5" HeaderText="d6l5" SortExpression="d6l5" />
                                    <asp:BoundField DataField="d6l6" HeaderText="d6l6" SortExpression="d6l6" />
                                    <asp:BoundField DataField="d1l1tch" HeaderText="d1l1tch" 
                                        SortExpression="d1l1tch" />
                                    <asp:BoundField DataField="d1l2tch" HeaderText="d1l2tch" 
                                        SortExpression="d1l2tch" />
                                    <asp:BoundField DataField="d1l3tch" HeaderText="d1l3tch" 
                                        SortExpression="d1l3tch" />
                                    <asp:BoundField DataField="d1l4tch" HeaderText="d1l4tch" 
                                        SortExpression="d1l4tch" />
                                    <asp:BoundField DataField="d1l5tch" HeaderText="d1l5tch" 
                                        SortExpression="d1l5tch" />
                                    <asp:BoundField DataField="d1l6tch" HeaderText="d1l6tch" 
                                        SortExpression="d1l6tch" />
                                    <asp:BoundField DataField="d2l1tch" HeaderText="d2l1tch" 
                                        SortExpression="d2l1tch" />
                                    <asp:BoundField DataField="d2l2tch" HeaderText="d2l2tch" 
                                        SortExpression="d2l2tch" />
                                    <asp:BoundField DataField="d2l3tch" HeaderText="d2l3tch" 
                                        SortExpression="d2l3tch" />
                                    <asp:BoundField DataField="d2l4tch" HeaderText="d2l4tch" 
                                        SortExpression="d2l4tch" />
                                    <asp:BoundField DataField="d2l5tch" HeaderText="d2l5tch" 
                                        SortExpression="d2l5tch" />
                                    <asp:BoundField DataField="d2l6tch" HeaderText="d2l6tch" 
                                        SortExpression="d2l6tch" />
                                    <asp:BoundField DataField="d3l1tch" HeaderText="d3l1tch" 
                                        SortExpression="d3l1tch" />
                                    <asp:BoundField DataField="d3l2tch" HeaderText="d3l2tch" 
                                        SortExpression="d3l2tch" />
                                    <asp:BoundField DataField="d3l3tch" HeaderText="d3l3tch" 
                                        SortExpression="d3l3tch" />
                                    <asp:BoundField DataField="d3l4tch" HeaderText="d3l4tch" 
                                        SortExpression="d3l4tch" />
                                    <asp:BoundField DataField="d3l5tch" HeaderText="d3l5tch" 
                                        SortExpression="d3l5tch" />
                                    <asp:BoundField DataField="d3l6tch" HeaderText="d3l6tch" 
                                        SortExpression="d3l6tch" />
                                    <asp:BoundField DataField="d4l1tch" HeaderText="d4l1tch" 
                                        SortExpression="d4l1tch" />
                                    <asp:BoundField DataField="d4l2tch" HeaderText="d4l2tch" 
                                        SortExpression="d4l2tch" />
                                    <asp:BoundField DataField="d4l3tch" HeaderText="d4l3tch" 
                                        SortExpression="d4l3tch" />
                                    <asp:BoundField DataField="d4l4tch" HeaderText="d4l4tch" 
                                        SortExpression="d4l4tch" />
                                    <asp:BoundField DataField="d4l5tch" HeaderText="d4l5tch" 
                                        SortExpression="d4l5tch" />
                                    <asp:BoundField DataField="d4l6tch" HeaderText="d4l6tch" 
                                        SortExpression="d4l6tch" />
                                    <asp:BoundField DataField="d5l1tch" HeaderText="d5l1tch" 
                                        SortExpression="d5l1tch" />
                                    <asp:BoundField DataField="d5l2tch" HeaderText="d5l2tch" 
                                        SortExpression="d5l2tch" />
                                    <asp:BoundField DataField="d5l3tch" HeaderText="d5l3tch" 
                                        SortExpression="d5l3tch" />
                                    <asp:BoundField DataField="d5l4tch" HeaderText="d5l4tch" 
                                        SortExpression="d5l4tch" />
                                    <asp:BoundField DataField="d5l5tch" HeaderText="d5l5tch" 
                                        SortExpression="d5l5tch" />
                                    <asp:BoundField DataField="d5l6tch" HeaderText="d5l6tch" 
                                        SortExpression="d5l6tch" />
                                    <asp:BoundField DataField="d6l1tch" HeaderText="d6l1tch" 
                                        SortExpression="d6l1tch" />
                                    <asp:BoundField DataField="d6l2tch" HeaderText="d6l2tch" 
                                        SortExpression="d6l2tch" />
                                    <asp:BoundField DataField="d6l3tch" HeaderText="d6l3tch" 
                                        SortExpression="d6l3tch" />
                                    <asp:BoundField DataField="d6l4tch" HeaderText="d6l4tch" 
                                        SortExpression="d6l4tch" />
                                    <asp:BoundField DataField="d6l5tch" HeaderText="d6l5tch" 
                                        SortExpression="d6l5tch" />
                                    <asp:BoundField DataField="d6l6tch" HeaderText="d6l6tch" 
                                        SortExpression="d6l6tch" />
                                    <asp:BoundField DataField="lecbrk" HeaderText="lecbrk" 
                                        SortExpression="lecbrk" />
                                    <asp:BoundField DataField="d1l1lec" HeaderText="d1l1lec" 
                                        SortExpression="d1l1lec" />
                                    <asp:BoundField DataField="d1l2lec" HeaderText="d1l2lec" 
                                        SortExpression="d1l2lec" />
                                    <asp:BoundField DataField="d1l3lec" HeaderText="d1l3lec" 
                                        SortExpression="d1l3lec" />
                                    <asp:BoundField DataField="d1l4lec" HeaderText="d1l4lec" 
                                        SortExpression="d1l4lec" />
                                    <asp:BoundField DataField="d1l5lec" HeaderText="d1l5lec" 
                                        SortExpression="d1l5lec" />
                                    <asp:BoundField DataField="d1l6lec" HeaderText="d1l6lec" 
                                        SortExpression="d1l6lec" />
                                    <asp:BoundField DataField="d2l1lec" HeaderText="d2l1lec" 
                                        SortExpression="d2l1lec" />
                                    <asp:BoundField DataField="d2l2lec" HeaderText="d2l2lec" 
                                        SortExpression="d2l2lec" />
                                    <asp:BoundField DataField="d2l3lec" HeaderText="d2l3lec" 
                                        SortExpression="d2l3lec" />
                                    <asp:BoundField DataField="d2l4lec" HeaderText="d2l4lec" 
                                        SortExpression="d2l4lec" />
                                    <asp:BoundField DataField="d2l5lec" HeaderText="d2l5lec" 
                                        SortExpression="d2l5lec" />
                                    <asp:BoundField DataField="d2l6lec" HeaderText="d2l6lec" 
                                        SortExpression="d2l6lec" />
                                    <asp:BoundField DataField="d3l1lec" HeaderText="d3l1lec" 
                                        SortExpression="d3l1lec" />
                                    <asp:BoundField DataField="d3l2lec" HeaderText="d3l2lec" 
                                        SortExpression="d3l2lec" />
                                    <asp:BoundField DataField="d3l3lec" HeaderText="d3l3lec" 
                                        SortExpression="d3l3lec" />
                                    <asp:BoundField DataField="d3l4lec" HeaderText="d3l4lec" 
                                        SortExpression="d3l4lec" />
                                    <asp:BoundField DataField="d3l5lec" HeaderText="d3l5lec" 
                                        SortExpression="d3l5lec" />
                                    <asp:BoundField DataField="d3l6lec" HeaderText="d3l6lec" 
                                        SortExpression="d3l6lec" />
                                    <asp:BoundField DataField="d4l1lec" HeaderText="d4l1lec" 
                                        SortExpression="d4l1lec" />
                                    <asp:BoundField DataField="d4l2lec" HeaderText="d4l2lec" 
                                        SortExpression="d4l2lec" />
                                    <asp:BoundField DataField="d4l3lec" HeaderText="d4l3lec" 
                                        SortExpression="d4l3lec" />
                                    <asp:BoundField DataField="d4l4lec" HeaderText="d4l4lec" 
                                        SortExpression="d4l4lec" />
                                    <asp:BoundField DataField="d4l5lec" HeaderText="d4l5lec" 
                                        SortExpression="d4l5lec" />
                                    <asp:BoundField DataField="d4l6lec" HeaderText="d4l6lec" 
                                        SortExpression="d4l6lec" />
                                    <asp:BoundField DataField="d5l1lec" HeaderText="d5l1lec" 
                                        SortExpression="d5l1lec" />
                                    <asp:BoundField DataField="d5l2lec" HeaderText="d5l2lec" 
                                        SortExpression="d5l2lec" />
                                    <asp:BoundField DataField="d5l3lec" HeaderText="d5l3lec" 
                                        SortExpression="d5l3lec" />
                                    <asp:BoundField DataField="d5l4lec" HeaderText="d5l4lec" 
                                        SortExpression="d5l4lec" />
                                    <asp:BoundField DataField="d5l5lec" HeaderText="d5l5lec" 
                                        SortExpression="d5l5lec" />
                                    <asp:BoundField DataField="d5l6lec" HeaderText="d5l6lec" 
                                        SortExpression="d5l6lec" />
                                    <asp:BoundField DataField="d6l1lec" HeaderText="d6l1lec" 
                                        SortExpression="d6l1lec" />
                                    <asp:BoundField DataField="d6l2lec" HeaderText="d6l2lec" 
                                        SortExpression="d6l2lec" />
                                    <asp:BoundField DataField="d6l3lec" HeaderText="d6l3lec" 
                                        SortExpression="d6l3lec" />
                                    <asp:BoundField DataField="d6l4lec" HeaderText="d6l4lec" 
                                        SortExpression="d6l4lec" />
                                    <asp:BoundField DataField="d6l5lec" HeaderText="d6l5lec" 
                                        SortExpression="d6l5lec" />
                                    <asp:BoundField DataField="d6l6lec" HeaderText="d6l6lec" 
                                        SortExpression="d6l6lec" />
                                </Columns>
                            </asp:GridView>
                          
                            <asp:SqlDataSource ID="SqlDataSource15" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [timetable]"></asp:SqlDataSource>
                          
                          <asp:GridView ID="GridView16" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="id" DataSourceID="SqlDataSource16">
                              <Columns>
                                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                      ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="tname" HeaderText="tname" SortExpression="tname" />
                                  <asp:BoundField DataField="msg" HeaderText="msg" SortExpression="msg" />
                                  <asp:BoundField DataField="school" HeaderText="school" 
                                      SortExpression="school" />
                                  <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                              </Columns>
                        </asp:GridView>

                        <asp:SqlDataSource ID="SqlDataSource16" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            SelectCommand="SELECT * FROM [alert]"></asp:SqlDataSource>


                            <asp:GridView ID="GridView17" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="id" DataSourceID="SqlDataSource17">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                                    <asp:BoundField DataField="message" HeaderText="message" 
                                        SortExpression="message" />
                                    <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="addnm" HeaderText="addnm" SortExpression="addnm" />
                                    <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                    <asp:BoundField DataField="subject" HeaderText="subject" 
                                        SortExpression="subject" />
                                    <asp:BoundField DataField="status" HeaderText="status" 
                                        SortExpression="status" />
                                    <asp:BoundField DataField="dscr" HeaderText="dscr" SortExpression="dscr" />
                                </Columns>
                        </asp:GridView>


                        <asp:SqlDataSource ID="SqlDataSource17" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            SelectCommand="SELECT * FROM [blog]"></asp:SqlDataSource>


                            <asp:GridView ID="GridView18" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="id" DataSourceID="SqlDataSource18">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="subject" HeaderText="subject" 
                                        SortExpression="subject" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="tchnm" HeaderText="tchnm" SortExpression="tchnm" />
                                    <asp:BoundField DataField="day" HeaderText="day" SortExpression="day" />
                                    <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                    <asp:BoundField DataField="time" HeaderText="time" SortExpression="time" />
                                    <asp:BoundField DataField="course" HeaderText="course" 
                                        SortExpression="course" />
                                </Columns>
                        </asp:GridView>

                        <asp:SqlDataSource ID="SqlDataSource18" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            SelectCommand="SELECT * FROM [course]"></asp:SqlDataSource>


                            <asp:GridView ID="GridView19" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="id" DataSourceID="SqlDataSource19">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="adddt" HeaderText="adddt" SortExpression="adddt" />
                                    <asp:BoundField DataField="snm" HeaderText="snm" SortExpression="snm" />
                                    <asp:BoundField DataField="pnm" HeaderText="pnm" SortExpression="pnm" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="subject" HeaderText="subject" 
                                        SortExpression="subject" />
                                    <asp:BoundField DataField="reason" HeaderText="reason" 
                                        SortExpression="reason" />
                                    <asp:BoundField DataField="day" HeaderText="day" SortExpression="day" />
                                    <asp:BoundField DataField="datest" HeaderText="datest" 
                                        SortExpression="datest" />
                                    <asp:BoundField DataField="datetl" HeaderText="datetl" 
                                        SortExpression="datetl" />
                                    <asp:BoundField DataField="st" HeaderText="st" SortExpression="st" />
                                </Columns>
                        </asp:GridView>

                        <asp:SqlDataSource ID="SqlDataSource19" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            
                            SelectCommand="SELECT [id], [adddt], [snm], [pnm], [school], [class], [subject], [reason], [day], [datest], [datetl], [st] FROM [leave]"></asp:SqlDataSource>

                            <asp:GridView ID="GridView20" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="id" DataSourceID="SqlDataSource20">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                                    <asp:BoundField DataField="time" HeaderText="time" SortExpression="time" />
                                </Columns>
                        </asp:GridView>

                        <asp:SqlDataSource ID="SqlDataSource20" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            SelectCommand="SELECT * FROM [login]"></asp:SqlDataSource>


                            <asp:GridView ID="GridView21" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="id" DataSourceID="SqlDataSource21">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                                    <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                                    <asp:BoundField DataField="addnm" HeaderText="addnm" SortExpression="addnm" />
                                    <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                    <asp:BoundField DataField="msg" HeaderText="msg" SortExpression="msg" />
                                </Columns>
                        </asp:GridView>


                        <asp:SqlDataSource ID="SqlDataSource21" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            SelectCommand="SELECT * FROM [news]"></asp:SqlDataSource>

                            <asp:GridView ID="GridView22" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="id" DataSourceID="SqlDataSource22">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                        ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="eid" HeaderText="eid" SortExpression="eid" />
                                    <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                                    <asp:BoundField DataField="school" HeaderText="school" 
                                        SortExpression="school" />
                                </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource22" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            SelectCommand="SELECT * FROM [pic]"></asp:SqlDataSource>
                  
                  
                  <asp:GridView ID="GridView23" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="id" DataSourceID="SqlDataSource23">
                      <Columns>
                          <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                              ReadOnly="True" SortExpression="id" />
                          <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                          <asp:BoundField DataField="school" HeaderText="school" 
                              SortExpression="school" />
                          <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                          <asp:BoundField DataField="adtch" HeaderText="adtch" SortExpression="adtch" />
                          <asp:BoundField DataField="addt" HeaderText="addt" SortExpression="addt" />
                          <asp:BoundField DataField="msg" HeaderText="msg" SortExpression="msg" />
                      </Columns>
                        </asp:GridView>
                  
                  
                        <asp:SqlDataSource ID="SqlDataSource23" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            SelectCommand="SELECT * FROM [tchmsg]"></asp:SqlDataSource>
                  
                  </div></div></div>

              </section></section>
</asp:Content>

