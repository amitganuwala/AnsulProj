<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="School_Default3" %>

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

    <asp:Button runat="server" ID="btn" Text="Download" onclick="btn_Click"  />
     <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                    
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="id" DataSourceID="SqlDataSource1">
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
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                SelectCommand="SELECT * FROM [timetable]"></asp:SqlDataSource>
                            
                            </div></div></div></section></section>
</asp:Content>

