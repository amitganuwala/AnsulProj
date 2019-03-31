<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="appev.aspx.cs" Inherits="Principal_appev" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>Pending Homework...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
                                    			<div class="form-panel">
                             <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                       
                           <form class="form-inline" role="form">
                         
                      <div class="content-panel">
                     <asp:Button ID="Button1" class="btn-success" runat="server" Text="Approve" 
                              onclick="Button1_Click"></asp:Button><asp:Button ID="Button2" 
                              class="btn-danger" runat="server" Text="Reject" onclick="Button2_Click"></asp:Button>
                          <section id="unseen">
                            <asp:table ID="Table1" runat="server" class="table table-bordered table-striped table-condensed">
   <asp:TableRow>

       <asp:TableCell RowSpan="7" CssClass="text-center"><asp:Image runat="server" ID="img" ImageUrl="view-homework.aspx?pid='Request[pid]'" Height="300px" Width="280px" CssClass="img-rounded" /><br /><asp:Label runat="server" ID="st"></asp:Label></asp:TableCell>
       <asp:TableCell><asp:Label runat="server" ID="lblid"></asp:Label></asp:TableCell>
   </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell> <asp:Label runat="server" ID="lbltitle"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                                   
                                <asp:TableRow>
                                    <asp:TableCell> <asp:Label runat="server" ID="lbldate"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                               
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbldescr"></asp:Label></asp:TableCell>

                                </asp:TableRow>

                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lblclass"></asp:Label></asp:TableCell>

                                </asp:TableRow>

                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbladtch"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbladdt"></asp:Label></asp:TableCell>

                                </asp:TableRow>



                                </asp:table></section></div></div>

            </div></form></div></div></div></section></section>
</asp:Content>

