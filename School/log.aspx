<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="log.aspx.cs" Inherits="School_log" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>Login details...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">

                          <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                       
                            <h2><asp:Label runat="server" ID="lblsch" ForeColor="Black"></asp:Label></h2>



           <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" 
                              DataSourceID="SqlDataSource1">
               <Columns>
                   <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                   <asp:BoundField DataField="school" HeaderText="school" 
                       SortExpression="school" />
                   <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                   <asp:BoundField DataField="time" HeaderText="time" SortExpression="time" />
               </Columns>
                          </asp:GridView>
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                              ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                              SelectCommand="SELECT [name], [school], [type], [time] FROM [login] WHERE ([school] = @school) ORDER BY [id] DESC">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                      Type="String" />
                              </SelectParameters>
                          </asp:SqlDataSource>
        </div></div></div></div></section></section>



                
</asp:Content>

