<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Principal_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD PRINCIPAL INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                  	 
                      <form class="form-inline" role="form">
                          <div class="form-group"> 
                             <asp:Label ID="Label1" runat="server" Text="Principal Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtnm" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <div class="form-group"> 
                             <asp:Label ID="Label2" runat="server" Text="Mobile: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtmob" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>

                                
                          <div class="form-group"> 
                             <asp:Label ID="Label5" runat="server" Text="School: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:DropDownList ID="DropDownList1" runat="server" 
                                  DataSourceID="SqlDataSource1" DataTextField="schoolname" 
                                  DataValueField="schoolname"></asp:DropDownList>
                              
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                  ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                  SelectCommand="SELECT [schoolname] FROM [schoolinfo]"></asp:SqlDataSource>
                              
                                </div>
    
                                
                          <div class="form-group"> 
                             <asp:Label ID="Label3" runat="server" Text="User Id: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtusr" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <div class="form-group"> 
                             <asp:Label ID="Label4" runat="server" Text="Password: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtpass" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <asp:Button ID="Button1" runat="server" Text="Add Information" CssClass="btn btn-theme" OnClick="Button1_Click"
                                />
                          </form>
                          </div>
             <br /><br />
             <h3><i class="fa fa-angle-right"></i>ADD SCHOOL ADMIN INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
                          <div class="form-group"> 
                             <asp:Label ID="Label6" runat="server" Text="Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtsnm" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                                
                          <div class="form-group"> 
                             <asp:Label ID="Label8" runat="server" Text="School: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:DropDownList ID="DropDownList2" runat="server" 
                                  DataSourceID="SqlDataSource1" DataTextField="schoolname" 
                                  DataValueField="schoolname"></asp:DropDownList>
                              
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                  ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                  SelectCommand="SELECT [schoolname] FROM [schoolinfo]"></asp:SqlDataSource>
                              
                                </div>
    
                                
                          <div class="form-group"> 
                             <asp:Label ID="Label9" runat="server" Text="User Id: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtsusr" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <div class="form-group"> 
                             <asp:Label ID="Label10" runat="server" Text="Password: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtspass" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <asp:Button ID="Button2" runat="server" Text="Add Information" 
                              CssClass="btn btn-theme" onclick="Button2_Click"
                                />
                          </form>
                          </div></div>
                </div>
              </section><</section>
</asp:Content>

