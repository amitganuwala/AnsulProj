<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="School_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

                 
                  
      <!-- **********************************************************************************************************************************************************
      RIGHT SIDEBAR CONTENT
      *********************************************************************************************************************************************************** -->                  
               <section id="main-content">
          <section class="wrapper">

              <div class="row">
                  <div class="col-lg-9 main-chart">
                  
         
                  <div class="col-lg-10 ds">
                    <!--COMPLETED ACTIONS DONUTS CHART-->
						<h3>LIST OF CLASS</h3>
                                        <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                      <asp:Label runat="server" ID="lbltchnm"></asp:Label>
                      <!-- First Action -->
                    <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
                   <div class="desc">
                      	<div class="thumb">
                      		<span class="badge bg-theme"><i class="fa fa-clock-o"></i></span>
                      	</div>
                      	<div class="details">
                      		<p> <%#Eval("class") %></p>
                              <div class="right">
                              <asp:Table runat="server"><asp:TableRow><asp:TableCell><asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/School/student.aspx?id={0}") %>'>View List of Students</asp:HyperLink></asp:TableCell></asp:TableRow></asp:Table>
                      	</div></div>
                      </div></ItemTemplate></asp:DataList>



                      </div></div></div></section></section>

</asp:Content>

