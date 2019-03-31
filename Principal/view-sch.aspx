<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="view-sch.aspx.cs" Inherits="Principal_view_sch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



   <section id="main-content">
          <section class="wrapper">

              <div class="row">
                  <div class="col-lg-12 main-chart">
                  
         
                  <div class="col-lg-12 ds">
                    <!--COMPLETED ACTIONS DONUTS CHART-->
						<h2 class="text-capitalize text-center"><asp:Label runat="server" ID="lblsch" ></asp:Label></h2>
                  <asp:Image runat="server" ID="imgsch" Width="1100px" Height="380px" />
                     
                      </div>

                      <div class="col-lg-12">
                          <h4><asp:Label runat="server" ID="lbladdr"></asp:Label></h4>
                      </div>
                  </div></div></section></section>

    <br /><br />

</asp:Content>

