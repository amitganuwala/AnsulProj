<%@ Page Title="" Language="C#" MasterPageFile="~/parent/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="parent_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div id="mainSchool">
	<div class="headtop">
    	<!--<div class="col-sm-1 col-md-1 col-xs-1 col-lg-1"><span class="glyphicon glyphicon-menu-hamburger"> </span></div>-->
        <span class="glyphicon glyphicon-menu-hamburger" onclick="openNav()"> </span> <span class="schoolname"><asp:Label runat="server" ID="lblsch"></asp:Label></span> 
        <br />
        <asp:Label runat="server" ID="lblstdnm" Visible="false"></asp:Label>
        <asp:Label runat="server" ID="lblclass" Visible="false"></asp:Label>
    </div>
    <div class="coverPictureSchool">
    	<asp:Image runat="server" ID="img" CssClass="img-responsive schoolImg" />
    </div>
    <div class="quickview row">
    	<div class="col-lg-4 col-sm-4 col-md-4 col-xs-12 seprationquickview">
        	<div class="heading">Notification <span class="glyphicon glyphicon-bell indicategly"></span></div>
           
               <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
            
            <div class="detailsindicate">
            	<h6><%# Eval("id") %></h6>
            	<h5><%# Eval("duedate") %></h5>
                <p><%# Eval("notice") %></p>
             
            </div><hr />
                            </ItemTemplate>
                   </asp:DataList>
        </div>
        <div class="col-lg-4 col-sm-4 col-md-4 col-xs-12 seprationquickview">
        	<div class="heading">Homework <i class="fa fa-circle-o-notch fa-fw w3-margin-right indicategly"></i></div>
            <asp:DataList class="list" ID="rptitem1" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
            
            
             <div class="detailsindicate">
            	<h6><%# Eval("subdate") %></h6>
            	<h5><%# Eval("subject") %></h5>
                <p><%# Eval("hw") %></p>
                 <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","../Parent/view-homework.aspx?id={0}") %>'>View</asp:HyperLink>
            </div><hr />
                            </ItemTemplate>
                </asp:DataList>
                   </div>
        <div class="col-lg-4 col-sm-4 col-md-4 col-xs-12 seprationquickview">
        	<div class="heading">Events <i class="glyphicon glyphicon-bookmark fa-fw w3-margin-right indicategly"></i></div>
             <asp:DataList class="list" ID="rptitem2" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
            
            <div class="detailsindicate">
                <h6><%# Eval("date") %></h6>
                  <table class="nav-justified">
            <tr>
            
                <td rowspan="2"> <asp:Image runat="server" ID="img"  Height="90px" Width="90px" ImageUrl='<%# Eval("pic","../Teacher/img/{0}") %>' /></td>
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
    </div>
    <script>
        var fixmeTop = $('.headtop').offset().top;       // get initial position of the element

        $(window).scroll(function () {                  // assign scroll event listener

            var currentScroll = $(window).scrollTop(); // get current position

            if (currentScroll >= fixmeTop) {           // apply position: fixed if you
                $('.headtop').css({                      // scroll to that element or below it
                    position: 'fixed',
                    top: '0',
                    left: '0'
                });

                $(document).ready(function () {
                    if ($(window).width() > 687) {
                        $(".schoolname").css({ "margin-left": "21%" });
                    }
                });

            } else {                                   // apply position: static
                $('.headtop').css({                      // if you scroll above it
                    position: 'static'
                });
            }

        });
    </script>
</asp:Content>

