<%@ Page Title="" Language="C#" MasterPageFile="~/parent/MasterPage.master" AutoEventWireup="true" CodeFile="course.aspx.cs" Inherits="parent_course" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div id="mainSchool">
  <div class="center-block text-center">
     <asp:Label runat="server" ID="lblstdnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
              <asp:Label runat="server" ID="lblclass" Visible="false"></asp:Label>
                                      
                
       <div class="headtop">
    	<!--<div class="col-sm-1 col-md-1 col-xs-1 col-lg-1"><span class="glyphicon glyphicon-menu-hamburger"> </span></div>-->
        <span class="glyphicon glyphicon-menu-hamburger" onclick="openNav()"> </span> <span class="schoolname">Daily Course
    </div>
  
    	<div class="homeworkstyle">
        <br /><br />
        	<div class="col-lg-6">
                <asp:GridView ID="GridView1" class="table-responsive table-hover table table-bordered table-condensed" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="subject" HeaderText="Subject" 
                            SortExpression="subject" />
                        <asp:BoundField DataField="tchnm" HeaderText="Teacher name" SortExpression="tchnm" />
                        <asp:BoundField DataField="day" HeaderText="Day" SortExpression="day" />
                        <asp:BoundField DataField="date" HeaderText="Date" SortExpression="date" />
                        <asp:BoundField DataField="time" HeaderText="Time" SortExpression="time" />
                        <asp:BoundField DataField="course" HeaderText="Course" 
                            SortExpression="course" />
                    </Columns>
                </asp:GridView>

<%--                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                    SelectCommand="SELECT * FROM [course] WHERE (([class] = @class) AND ([school] = @school))">
                          <SelectParameters>
                              <asp:ControlParameter ControlID="lblclass" Name="class" PropertyName="Text" 
                                  Type="String" />
                              <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                  Type="String" />
                          </SelectParameters>
                </asp:SqlDataSource>--%>

                      </div></div></div></div></div>

</asp:Content>

