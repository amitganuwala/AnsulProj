<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="gal.aspx.cs" Inherits="Teacher_gal" %>

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
  <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/Principal/zoom.aspx?id={0}") %>'>
               
          <asp:Image ID="Image1" class="img" runat="server" ImageUrl='<%# Eval("pic","../Teacher/pic/{0}") %>' Style="cursor: pointer" OnClientClick="return LoadDiv(this.src);" Height="250px" Width="250px"></asp:Image>
               </asp:HyperLink>
          
          </ItemTemplate>
          
          </asp:DataList>
</div>
     </div></div></section></section>
</asp:Content>

