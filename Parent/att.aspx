<%@ Page Title="" Language="C#" MasterPageFile="~/parent/MasterPage.master" Debug="true" AutoEventWireup="true" CodeFile="att.aspx.cs" Inherits="parent_att" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



   
<div id="mainSchool">
	
    	<!--<div class="col-sm-1 col-md-1 col-xs-1 col-lg-1"><span class="glyphicon glyphicon-menu-hamburger"> </span></div>-->
        <span class="glyphicon glyphicon-menu-hamburger" onclick="openNav()"> </span> <span class="schoolname"> 	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		
          			<div class="form-panel">

                           <asp:Label runat="server" ID="lblclass" Visible="false"></asp:Label>
                          <asp:Label runat="server" ID="lblstdnm" Visible="false" ></asp:Label>
                         <div class="col-lg-6 right">
                       
                            <h2><asp:Label runat="server" ID="lblsch" ForeColor="Black"></asp:Label></h2>
                        <br /><br />
                        
                          <asp:GridView ID="GridView1" GridLines="None" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" 
                               DataSourceID="SqlDataSource1">
                              <Columns>
                                  <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                  <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                  <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                  <asp:BoundField DataField="status" HeaderText="status" 
                                      SortExpression="status" />
                              </Columns>
                          </asp:GridView>
                        
                           <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                               ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                               
                                 SelectCommand="SELECT [name], [class], [date], [status] FROM [attendance] WHERE (([class] = @class) AND ([school] = @school) AND ([name] = @name)) ORDER BY [date] DESC">
                               <SelectParameters>
                                   <asp:ControlParameter ControlID="lblclass" Name="class" PropertyName="Text" 
                                       Type="String" />
                                   <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                       Type="String" />
                                   <asp:ControlParameter ControlID="lblstdnm" Name="name" PropertyName="Text" 
                                       Type="String" />
                               </SelectParameters>
                           </asp:SqlDataSource>
                        </div>


                       </div></div></div>  


</asp:Content>

