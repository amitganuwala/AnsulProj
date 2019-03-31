<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="sort.aspx.cs" Inherits="School_student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="main-content">
          <section class="wrapper">

<div class="row mtbox">
                  		<div class="col-md-8 col-sm-8 col-md-offset-1 box0">
                  				 <div class="desc">
                      	<div class="thumb">
                              <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                      	
                              <h4><asp:Label runat="server" ID="lblclass"></asp:Label></h4>


                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              <asp:DropDownList ID="DropDownList1" AutoPostBack="true" CssClass="form-control" runat="server">
                  <asp:ListItem>Open</asp:ListItem>
                  <asp:ListItem>OBC</asp:ListItem>
                  <asp:ListItem>EBC</asp:ListItem>
                  <asp:ListItem>SBC</asp:ListItem>
                  <asp:ListItem>SC</asp:ListItem>
                  <asp:ListItem>ST</asp:ListItem>
                  <asp:ListItem>VJ / NT</asp:ListItem>
                  <asp:ListItem>Others</asp:ListItem>
                              </asp:DropDownList>
                  		</div></div></div>
     <br /><br />
                             
                             
     <div class="desc">
                      	<div class="thumb">
                              <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="usr">
                                  <Columns>
                                      <asp:BoundField DataField="id" HeaderText="ID" SortExpression="id" InsertVisible="False" ReadOnly="True" />
                                      <asp:BoundField DataField="name" HeaderText="Student Name" SortExpression="name" />
                                      <asp:BoundField DataField="class" HeaderText="Class" SortExpression="class" />
                                      <asp:BoundField DataField="roll" HeaderText="Roll no" SortExpression="roll" />
                                      <asp:BoundField DataField="school" HeaderText="School" SortExpression="school" />
                                      <asp:BoundField DataField="sgen" HeaderText="Student Gender" SortExpression="sgen" />
                                      <asp:BoundField DataField="pname" HeaderText="Parent Name" SortExpression="pname" />
                                      <asp:BoundField DataField="usr" HeaderText="User name" SortExpression="usr" ReadOnly="True" />
                                      <asp:BoundField DataField="pass" HeaderText="Password" SortExpression="pass" />
                                      <asp:BoundField DataField="mob" HeaderText="Mobile" SortExpression="mob" />
                                      <asp:BoundField DataField="religion" HeaderText="Religion" SortExpression="religion" />
                                      <asp:BoundField DataField="caste" HeaderText="Caste" SortExpression="caste" />
                                      <asp:BoundField DataField="subcaste" HeaderText="Sub Caste" SortExpression="subcaste" />
                                  </Columns>
                              </asp:GridView>
                  	
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [id], [name], [class], [roll], [school], [sgen], [pname], [usr], [pass], [mob], [religion], [caste], [subcaste] FROM [parent] WHERE (([school] = @school) AND ([class] = @class) AND ([caste] = @caste)) ORDER BY [name]">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                      <asp:ControlParameter ControlID="lblclass" Name="class" PropertyName="Text" Type="String" />
                                      <asp:ControlParameter ControlID="DropDownList1" Name="caste" PropertyName="SelectedValue" Type="String" />
                                  </SelectParameters>
                              </asp:SqlDataSource>



                              <asp:GridView ID="GridView2" runat="server" CssClass="table table-striped table-advance table-hover" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="usr" DataSourceID="SqlDataSource2">
                                  <Columns>
                                      <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                      <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                                      <asp:BoundField DataField="class" HeaderText="Class" SortExpression="class" />
                                      <asp:BoundField DataField="roll" HeaderText="Roll no" SortExpression="roll" />
                                      <asp:BoundField DataField="school" HeaderText="School" SortExpression="school" />
                                      <asp:BoundField DataField="sgen" HeaderText="Student Gender" SortExpression="sgen" />
                                      <asp:BoundField DataField="pname" HeaderText="Parent Name" SortExpression="pname" />
                                      <asp:BoundField DataField="usr" HeaderText="User name" ReadOnly="True" SortExpression="usr" />
                                      <asp:BoundField DataField="pass" HeaderText="Password" SortExpression="pass" />
                                      <asp:BoundField DataField="mob" HeaderText="Mobile" SortExpression="mob" />
                                      <asp:BoundField DataField="religion" HeaderText="Religion" SortExpression="religion" />
                                      <asp:BoundField DataField="caste" HeaderText="Caste" SortExpression="caste" />
                                      <asp:BoundField DataField="subcaste" HeaderText="Sub Caste" SortExpression="subcaste" />
                                  </Columns>
                              </asp:GridView>
                  	
                              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [id], [name], [class], [roll], [school], [sgen], [pname], [usr], [pass], [mob], [religion], [caste], [subcaste] FROM [parent] WHERE (([school] = @school) AND ([caste] = @caste)) ORDER BY [class], [name]">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                   
                                      <asp:ControlParameter ControlID="DropDownList1" Name="caste" PropertyName="SelectedValue" Type="String" />
                                  </SelectParameters>
                              </asp:SqlDataSource>
                  	
</div></section>
        </section>
</asp:Content>

