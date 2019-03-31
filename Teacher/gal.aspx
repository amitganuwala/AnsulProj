<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="gal.aspx.cs" Inherits="Teacher_gal" %>

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
						<h3>Photo Gallery</h3>
         
            <asp:DataList ID="rptitem" class="list-group-item" RepeatColumns="5" RepeatLayout="Flow" RepeatDirection="Horizontal" runat="server">
          
          <ItemTemplate>
          <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/Teacher/zoom.aspx?id={0}") %>'>
          <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("pic","../Teacher/pic/{0}") %>'  Height="120px" Width="130px"></asp:Image>
          </asp:HyperLink>
          </ItemTemplate>
          
          </asp:DataList>
        </div></div></div></div></section></section>
</asp:Content>

