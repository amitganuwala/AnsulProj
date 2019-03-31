<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="notice-list.aspx.cs" Inherits="School_event_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <section id="main-content">
          <section class="wrapper">

              <div class="row">
                  <div class="col-lg-9 main-chart">
                  
                
          <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
              
                  <div class="col-lg-10 ds">
                    <!--COMPLETED ACTIONS DONUTS CHART-->
						<h3>LIST OF NOTICE</h3>
                                        
                      <!-- First Action -->
                    <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
                   <div class="desc">
                      	<div class="thumb">
                      		<span class="badge bg-theme"><i class="fa fa-clock-o"></i></span>
                      	</div>
                      	<div class="details" >
                      		<p> <%#Eval("notice") %></p>
                              <p> <%#Eval("class") %></p>
                              <p> <%#Eval("adfrom") %></p>
                              <p> <%#Eval("duedate") %></p>

                              <div class="right">
                              <asp:Table ID="Table1" Width="200px" runat="server"><asp:TableRow><asp:TableCell><asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/School/view-notice.aspx?id={0}") %>'>View Notice's Full Information</asp:HyperLink></asp:TableCell></asp:TableRow></asp:Table>
                      	</div></div>
                      </div></ItemTemplate></asp:DataList>
                      </div></div></div></section></section>



</asp:Content>

