<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="School_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD STUDENT's INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                  	 
                      <form class="form-inline" role="form">
                              <h3><asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label></h3>
            <br />
                 
                 <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>



                 </form>
                 </div>
                 </div></div>
                 </section></section>
</asp:Content>

