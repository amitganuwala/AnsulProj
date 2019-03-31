<%@ Page Title="" Language="C#" MasterPageFile="~/parent/Masterpage.master" AutoEventWireup="true" CodeFile="view-homework.aspx.cs" Inherits="Parent_view_event" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


       <!-- **********************************************************************************************************************************************************
      MAIN CONTENT
      *********************************************************************************************************************************************************** -->
      <!--main content start-->
     <div class="mainSchool">
     
       <div class="content-panel">
                     
                          <section id="unseen">
                            <asp:table runat="server" class="table table-bordered table-striped table-condensed">
   <asp:TableRow>

       <asp:TableCell RowSpan="5" CssClass="text-center"><asp:Image runat="server" ID="img" ImageUrl="view-homework.aspx?pid='Request[pid]'" Height="300px" Width="280px" CssClass="img-rounded" /><asp:Label runat="server" id="msg" Font-Bold="true" Font-Size="X-Large" Fore-Color="Black"></asp:Label><asp:Label runat="server" id="msgg" Font-Bold="true" Font-Size="X-Large" Fore-Color="Black"></asp:Label></asp:TableCell>
       <asp:TableCell><asp:Label runat="server" ID="lblid"></asp:Label></asp:TableCell>
   </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>Homework :- <asp:Label runat="server" ID="lbltitle"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                                   
                                <asp:TableRow>
                                    <asp:TableCell>Subject :- <asp:Label runat="server" ID="lbldate"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                               
                                <asp:TableRow>
                                    <asp:TableCell>Class :-<asp:Label runat="server" ID="lbldescr"></asp:Label></asp:TableCell>

                                </asp:TableRow>

                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lblschool"></asp:Label></asp:TableCell>

                                </asp:TableRow>




                                </asp:table></section></div></div></div></section></section>

</asp:Content>

