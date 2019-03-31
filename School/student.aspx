<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="School_student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="main-content">
          <section class="wrapper">

<div class="row mtbox">
                  		<div class="col-md-8 col-sm-8 col-md-offset-1 box0">
                  				 <div class="desc">
                      	<div class="thumb">
                      	    <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" ForeColor="Black"></asp:Label></h3>
                              <h4><asp:Label runat="server" ID="lblclass"></asp:Label></h4>
                  		</div></div></div>
    <br />
     <div class="desc">
                      	<div class="thumb">
                              <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="usr">
                                  <Columns>
                                      <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                                      <asp:BoundField DataField="roll" HeaderText="Roll" SortExpression="roll" />
                                      <asp:BoundField DataField="class" HeaderText="Class" SortExpression="class" />
                                      <asp:BoundField DataField="sgen" HeaderText="Student Gender" SortExpression="sgen" />
                                      <asp:BoundField DataField="school" HeaderText="School" SortExpression="school" />
                                      <asp:BoundField DataField="pname" HeaderText="Parent Name" SortExpression="pname" />
                                      <asp:BoundField DataField="usr" HeaderText="User name" ReadOnly="True" SortExpression="usr" />
                                      <asp:BoundField DataField="pass" HeaderText="Password" SortExpression="pass" />
                                      <asp:BoundField DataField="mob" HeaderText="Mobile" SortExpression="mob" />
                                  </Columns>
                              </asp:GridView>
                  	
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [name], [roll], [class], [sgen], [school], [pname], [usr], [pass], [mob] FROM [parent] WHERE (([class] = @class) AND ([school] = @school)) ORDER BY [name]">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblclass" Name="class" PropertyName="Text" Type="String" />
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                  </SelectParameters>
                              </asp:SqlDataSource>


                              <asp:GridView ID="GridView2" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="usr" DataSourceID="SqlDataSource2">
                                  <Columns>
                                      <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                      <asp:BoundField DataField="roll" HeaderText="roll" SortExpression="roll" />
                                      <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                      <asp:BoundField DataField="sgen" HeaderText="sgen" SortExpression="sgen" />
                                      <asp:BoundField DataField="school" HeaderText="school" SortExpression="school" />
                                      <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
                                      <asp:BoundField DataField="usr" HeaderText="usr" ReadOnly="True" SortExpression="usr" />
                                      <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                      <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                  </Columns>
                              </asp:GridView>
                              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [name], [roll], [class], [sgen], [school], [pname], [usr], [pass], [mob] FROM [parent] WHERE ([school] = @school) ORDER BY [name],[class]">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                  </SelectParameters>
                              </asp:SqlDataSource>
</div></section>
        </section>
</asp:Content>

