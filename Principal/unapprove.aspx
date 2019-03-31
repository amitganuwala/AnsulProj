<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="unapprove.aspx.cs" Inherits="Principal_unapprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>Pending Items...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
                                    			<div class="form-panel">
                             <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                       
                           <form class="form-inline" role="form">
                          <div class="form-group">
                          


                              <table border="1px" class="w-100 table table-bordered table-advanced">
                                  <tr>
                                      <th>Homeworks</th>
                                      <th>Notices</th>
                                      <th>Events</th>
                                  </tr>
                                  <tr>
                                      <td><br /> <asp:DataList class="list" ID="DataList2" runat="server"  RepeatLayout="flow" RepeatDirection="Horizontal" >
                        <ItemTemplate>
                   <div class="desc">
                      	
                      	<div class="details">
                      		 <p> <%#Eval("class") %></p>
                            <p> <%#Eval("hw") %></p>
                            <p> <%#Eval("addtch") %></p>
                            <p> <%#Eval("adddate") %></p>
                             <p> <%#Eval("subject") %></p>
                              <div class="right">
                              <asp:Table ID="Table1" class="right" Width="200px" runat="server"><asp:TableRow><asp:TableCell>
                              <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/Principal/apphw.aspx?id={0}") %>'>
                              View</asp:HyperLink></asp:TableCell></asp:TableRow></asp:Table>
                      	</div></div>
                      </div></ItemTemplate></asp:DataList>
               </td>
                                      <td><br /> <asp:DataList class="list" ID="DataList1" runat="server"  RepeatLayout="flow" RepeatDirection="Horizontal" >
                        <ItemTemplate>
                   <div class="desc">
                      	
                      	<div class="details">
                      		<p> <%#Eval("notice") %></p>
                            <p> <%#Eval("duedate") %></p>
                              <p> <%#Eval("adfrom") %></p>
                          <p> <%#Eval("class") %></p>
                              <div class="right">
                              <asp:Table ID="Table1" class="right" Width="200px" runat="server"><asp:TableRow><asp:TableCell>
                              <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/Principal/appno.aspx?id={0}") %>'>
                              View</asp:HyperLink></asp:TableCell></asp:TableRow></asp:Table>
                      	</div></div>
                      </div></ItemTemplate></asp:DataList>
               </td>
                                      <td> <br /><asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Horizontal" >
                        <ItemTemplate>
                   <div class="desc">
                      	
                      	<div class="details">
                      		 <p> <%#Eval("title") %></p>
                             <p> <%#Eval("adddate") %></p>
                             <p> <%#Eval("addtch") %></p>
                             <p> <%#Eval("class") %></p>
                              <div class="right">
                              <asp:Table ID="Table1" Width="200px" class="right" runat="server"><asp:TableRow><asp:TableCell>
                              <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/Principal/appev.aspx?id={0}") %>'>
                              View</asp:HyperLink></asp:TableCell></asp:TableRow></asp:Table>
                      	</div></div>
                      </div></ItemTemplate></asp:DataList>
               </td>
                                  </tr>
                              </table>



                          </div></form></div></div></div></section></section>
                 
</asp:Content>

