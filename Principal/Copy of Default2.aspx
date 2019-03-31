<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="Copy of Default2.aspx.cs" Inherits="Principal_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD SCHOOL INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                  	 
                      <form class="form-inline" role="form">
                          <div class="form-group"> 
                             <asp:Label ID="Label1" runat="server" Text="School  Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtnm" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <div class="form-group"> 
                             <asp:Label ID="Label2" runat="server" Text="School  Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtaddr" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <div class="form-group"> 
                             <asp:Label ID="Label4" runat="server" Text="School  Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3>
                                  <asp:FileUpload ID="FileUpload1" runat="server" /><asp:TextBox runat="server" ID="txtpic" Visible="false" ></asp:TextBox></h3>
                              
                                </div>

                          <asp:Button ID="Button1" runat="server" Text="Add Information" CssClass="btn btn-theme" OnClick="Button1_Click"
                                />
                          </form>
                          </div></div>
                </div>
              </section><</section>
</asp:Content>

