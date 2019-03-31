<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="msg.aspx.cs" Inherits="Teacher_msg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">




    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>Send Message to parent</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-5">
          			<div class="form-panel">
                           <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                       
                           
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:DropDownList ID="DropDownList2" runat="server"  AutoPostBack="true"
                                  DataSourceID="SqlDataSource1" DataTextField="class" DataValueField="class"></asp:DropDownList>
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                  ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                  SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school)">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                          Type="String" />
                                  </SelectParameters>
                              </asp:SqlDataSource>
                          </div>
                          <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="Student name:" Font-Bold="true" ForeColor="Black"></asp:Label>
                             <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" DataSourceID="SqlDataSource3" 
                                    DataTextField="name" DataValueField="name"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                    SelectCommand="SELECT [name] FROM [parent] WHERE (([school] = @school) AND ([class] = @class))">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                            Type="String" />
                                        <asp:ControlParameter ControlID="DropDownList2" Name="class" 
                                            PropertyName="SelectedValue" Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                          </div>
                          
                         <div class="form-group">
                            <asp:GridView ID="GridView1" runat="server" Visible="false" AutoGenerateColumns="False" 
                                 DataSourceID="SqlDataSource2">
                                <Columns>
                                    <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                </Columns>
                             </asp:GridView>
                             <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                 ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                 SelectCommand="SELECT [mob] FROM [parent] WHERE (([school] = @school) AND ([class] = @class) AND ([name] = @name))">
                                 <SelectParameters>
                                     <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                         Type="String" />
                                     <asp:ControlParameter ControlID="DropDownList2" Name="class" 
                                         PropertyName="SelectedValue" Type="String" />
                                     <asp:ControlParameter ControlID="DropDownList3" Name="name" 
                                         PropertyName="SelectedValue" Type="String" />
                                 </SelectParameters>
                             </asp:SqlDataSource>
                         </div>
                          <div class="form-group">
                                <asp:Label ID="Label3" runat="server" Text="Write Message:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" ID="txtdescr" class="form-control" ></asp:TextBox>
                          </div>
                         
                         <asp:Button runat="server" class="btn btn-theme03" ID="btnadd" Text="Send" 
                               onclick="btnadd_Click"  />
                      
          			
</asp:Content>

