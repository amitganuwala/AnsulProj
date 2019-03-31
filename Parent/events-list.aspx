<%@ Page Title="" Language="C#" MasterPageFile="~/Parent/MasterPage.master" AutoEventWireup="true" CodeFile="events-list.aspx.cs" Inherits="Teacher_event_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <div id="mainSchool">
  <div class="center-block text-center">
     <asp:Label runat="server" ID="lblstdnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
              <asp:Label runat="server" ID="lblclass" Visible="false"></asp:Label>
                                      
                
       <div class="headtop">
    	<!--<div class="col-sm-1 col-md-1 col-xs-1 col-lg-1"><span class="glyphicon glyphicon-menu-hamburger"> </span></div>-->
        <span class="glyphicon glyphicon-menu-hamburger" onclick="openNav()"> </span> <span class="schoolname">
    </div>
    <div class="coverPictureSchool">
    
    </div>
    <div class="quickview row">
    <div class="col-lg-4 col-sm-4 col-md-4 col-xs-12 seprationquickview">
        	<div class="heading">Events <i class="glyphicon glyphicon-bookmark fa-fw w3-margin-right indicategly"></i></div>
             <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
            
            <div class="detailsindicate">
                <h6><%# Eval("date") %></h6>
                  <table class="nav-justified">
            <tr>
                <td rowspan="2"></td>
                <td><h5><%# Eval("title") %></h5></td>
            </tr>
            <tr>
                <td> <p class="right"><%# Eval("descr") %></p></td>
                 <td><asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","../Parent/view-event.aspx?id={0}") %>'>View</asp:HyperLink></td>
            </tr>
        </table>
   
                <div class="clearfix">
               
                </div>
                
            </div><hr />
                            </ItemTemplate>
                </asp:DataList>
           
        </div>
    </div>                    </div>


</asp:Content>

