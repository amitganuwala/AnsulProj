<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="lvapp.aspx.cs" Inherits="Principal_lvapp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


   <section id="main-content">
          <section class="wrapper">

              <div class="row">
                  <div class="col-lg-12 ">
                  
          <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                       
                  <div class="col-lg-10 ds">
                    <!--COMPLETED ACTIONS DONUTS CHART-->
						<h3>Photo Gallery</h3>

            <asp:DataList ID="rptitem" class="list-group-item" RepeatColumns="5" RepeatLayout="Flow" RepeatDirection="Horizontal" runat="server">
          
          <ItemTemplate>

           <div class="desc">
                      	<div class="thumb">
                      		
                      	</div>
                      	<div class="details">
                      		<p> <%#Eval("subject") %></p>
                              <p> <%#Eval("snm") %></p>
                              <p><%# Eval("class") %></p>
                              <div class="right">
                              <asp:Table ID="Table1" Width="200px" runat="server"><asp:TableRow><asp:TableCell><asp:HyperLink runat="server" ID="HyperLink1" NavigateUrl='<%# Eval("id","~/Principal/view-leave.aspx?id={0}") %>'>View Leave's Full Information</asp:HyperLink></asp:TableCell></asp:TableRow></asp:Table>
                      	</div></div></div>
              
          </ItemTemplate>
          
          </asp:DataList>
</div>
     </div></div></section></section>


</asp:Content>

