<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Principal_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="~/Principal/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="../js/bootstrap.min.js"></script>

       
    <meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-blue-grey.css"/>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Open+Sans'/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
 <link rel="Stylesheet" href="vendor/bootstrap/css/new.css" />
 <link rel="Stylesheet" href="vendor/bootstrap/css/bootstrap.min-fds90[2].css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


<style>
html,body,h1,h2,h3,h4,h5,td,th,table {font-family: "Open Sans", sans-serif;
                                      background-color: #F5F5F5;
                                      }
                                      .style1{color:white;background-color:#66c2ff}
                                                      .style2{color:white;background-color:#ff8533}
                                                                      .style3{color:white;background-color:#cc6699}

.w3-col, .w3-half, .w3-third, .w3-twothird, .w3-threequarter, .w3-quarter {
    float: left;
    width: 50%;
}
    @media (min-width: 601px) {
        .w3-col.m4, .w3-third {
            width: 25%;
        }
    }


</style>
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <section id="main-content">
          <section class="wrapper">
      
      <h3><asp:Label runat="server" ID="lblsch"></asp:Label></h3>
      <br />
 <div class="row">
 
          <div class="col-xl-2 col-sm-6 mb-3">
               <div class="card text-white style1 o-hidden h-100">
             
        
                      <div class="card-body">
                <div class="card-body-icon">
                  <i class="fa fa-fw fa-address-book"></i>
                </div>
                <div class="mr-5 text-white">
                  <asp:Label ID="lblclass" runat="server"></asp:Label> Classes 
                </div>
              </div>
              <a href="view.aspx" class="card-footer text-white clearfix small z-1">
                <span class="float-left">View Details</span>
                <span class="float-right">
                  <i class="fa fa-angle-right"></i>
                </span>
                     </a>
             
            </div>
              
          </div>
          <div class="col-xl-2 col-sm-6 mb-3">
               <div class="card text-white style2 o-hidden h-100">
             
        
                      <div class="card-body">
                <div class="card-body-icon">
                  <i class="fa fa-fw fa-comments"></i>
                </div>
                <div class="mr-5 text-white">
                  <asp:Label ID="lblalerts" runat="server"></asp:Label> Alerts
                </div>
              </div>
              <a href="alerts.aspx" class="card-footer text-white clearfix small z-1">
                <span class="float-left">View Details</span>
                <span class="float-right">
                  <i class="fa fa-angle-right"></i>
                </span>
                     </a>
             
            </div>
              
          </div>
         
          <div class="col-xl-2 col-sm-6 mb-3">
            <div class="card text-white bg-success o-hidden h-100">
              <div class="card-body">
                <div class="card-body-icon">
                  <i class="fa fa-fw fa-list"></i>
                </div>
                <div class="mr-5">
                   <asp:Label ID="lblpending" runat="server"></asp:Label> Pending Items
                </div>
              </div>
              <a href="unapprove.aspx" class="card-footer text-white clearfix small z-1">
                <span class="float-left">View Details</span>
                <span class="float-right">
                  <i class="fa fa-angle-right"></i>
                </span>
              </a>
            </div>
          </div>
          <div class="col-xl-2 col-sm-6 mb-3">
            <div class="card text-white bg-warning o-hidden h-100">
              <div class="card-body">
                <div class="card-body-icon">
                  <i class="fa fa-fw fa-shopping-cart"></i>
                </div>
                <div class="mr-5">
                    <asp:Label ID="lblatt" runat="server" Text=""></asp:Label> Attendance
                </div>
              </div>
              <a href="" class="card-footer text-white clearfix small z-1">
                <span class="float-left">View Details</span>
                <span class="float-right">
                  <i class="fa fa-angle-right"></i>
                </span>
              </a>
            </div>
          </div>
            <div class="col-xl-2 col-sm-6 mb-3">
               <div class="card text-white style3 o-hidden h-100">
             
        
                      <div class="card-body">
                <div class="card-body-icon">
                  <i class="fa fa-fw fa-clipboard"></i>
                </div>
                <div class="mr-5 text-white">
                  <asp:Label ID="lblblog" runat="server"></asp:Label> Pending Blogs
                </div>
              </div>
              <a href="Copy of blog.aspx" class="card-footer text-white clearfix small z-1">
                <span class="float-left">View Details</span>
                <span class="float-right">
                  <i class="fa fa-angle-right"></i>
                </span>
                     </a>
             
            </div>
              
          </div>
         
          <div class="col-xl-2 col-sm-6 mb-3">
            <div class="card text-white bg-danger o-hidden h-100">
              <div class="card-body">
                <div class="card-body-icon">
                  <i class="fa fa-fw fa-support"></i>
                </div>
                <div class="mr-5">
                    <asp:Label ID="lblleave" runat="server" Text=""></asp:Label> Pending leave applications
                </div>
              </div>
              <a href="lvapp.aspx" class="card-footer text-white clearfix small z-1">
                <span class="float-left">View Details</span>
                <span class="float-right">
                  <i class="fa fa-angle-right"></i>
                </span>
              </a>
            </div>
          </div>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        
    <div class="col-lg-12 col-xs-12">
              <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

    <div class="row">
        <div class="col-lg-12 col-sm-12 col-xs-12">
                
            <center>
                 <button class="w3-btn w3-green" style="width:100%; max-width:400px" >Present Students
                    <span class="w3-badge w3-margin-left w3-white">  <asp:Label ID="lblpresentstudent" runat="server" Text="0"></asp:Label></span>
                    </button>
                   
                    <button class="w3-btn w3-green"  style="width:100%; max-width:400px" >Absent Students
                    <span class="w3-badge w3-margin-left w3-white">   <asp:Label ID="lblabsentstudent" runat="server" Text="0"></asp:Label></span>
                    </button>

            </center>
             
                   
              
               
                
                 </div>
            </div>           
                 

                <div class="w3-container" style="padding: 0px;    margin: 0px;">
 
  <div class="w3-row">
    <a href="javascript:void(0)" onclick="openCity(event, 'London');">
      <div class="w3-third tablink w3-bottombar w3-hover-light-grey w3-padding">
           Homework 
            <asp:Label ID="lblhomeworkcount" cssclass="label label-danger" runat="server" Text=""></asp:Label>
      </div>
    </a>
    <a href="javascript:void(0)" onclick="openCity(event, 'Paris');">
      <div class="w3-third tablink w3-bottombar w3-hover-light-grey w3-padding">
              Notices
            <asp:Label ID="lblnoticecount" cssclass="label label-danger" runat="server" Text=""></asp:Label>
        
      </div>
    </a>
    <a href="javascript:void(0)" onclick="openCity(event, 'Tokyo');">
      <div class="w3-third tablink w3-bottombar w3-hover-light-grey w3-padding">
               Event
        <asp:Label ID="lbleventcount" cssclass="label label-danger" runat="server" Text=""></asp:Label>
      
      </div>
    </a>
        <a href="javascript:void(0)" onclick="openCity(event, 'india');">
      <div class="w3-third tablink w3-bottombar w3-hover-light-grey w3-padding">
                  Timetable
            <asp:Label ID="lbltimetablecount" cssclass="label label-danger" runat="server" Text=""></asp:Label>
     
      </div>
    </a>
  </div>
  
  <div id="London" class="w3-container city" style="display:none">
    <h3>Homework</h3>
          <asp:ListView ID="listhomework" runat="server">
                                    <ItemTemplate>
                                         <div class='panel panel-default accordion-toggle' data-toggle='collapse' data-parent='#accordion'  href='#collapse<%# Eval("id")%>'>
                                        <div class='panel-heading headsubject'>
                                           <span class='glyphicon glyphicon-triangle-right'></span>
                                          <span> <%# Eval("class")%>  </span>
                                          <span> <%# Eval("subject")%> </span>
                                        </div>
                                        <div class='panel-collapse collapse'>
                                          <div class='panel-body'>
                                        <%# Eval("hw")%> <br />
                                        Should be competed till date <%# Eval("subdate") %>
                                        <br />
                                        -By <%# Eval("addtch") %>
                                        
                                         </div>
                                        </div>
                                       </div>
                                    </ItemTemplate>
                                </asp:ListView>
               <asp:Label ID="lblhomeworkmgs" runat="server" Text=""></asp:Label>
             
  </div>

  <div id="Paris" class="w3-container city" style="display:none">
    <h3>Notice</h3>
                   <asp:ListView ID="listnotice" runat="server">
                    <ItemTemplate>
                         <div class='panel panel-default accordion-toggle' data-toggle='collapse' data-parent='#accordion'  >
                        <div class='panel-heading headsubject'>
                           <span class='glyphicon glyphicon-triangle-right'></span>
                              <span> <%# Eval("notice")%>  </span><br />
                              On dated <%# Eval("duedate") %><br />
                          <span> <%# Eval("class")%>  </span><br />
                          <span><h4>-By <%# Eval("adfrom")%> </h4></span>
                        </div>
                        <div class='panel-collapse collapse'>
                          <div class='panel-body'>
                        <%# Eval("id")%> 
                         </div>
                        </div>
                       </div>
                    </ItemTemplate>
                </asp:ListView>
            <asp:Label ID="lblnoticemgs" runat="server" Text=""></asp:Label>
       
  </div>

  <div id="Tokyo" class="w3-container city" style="display:none">
      <h3>Event</h3>
         <asp:ListView ID="listevents" runat="server">
                    <ItemTemplate>
                    <div class='panel panel-default accordion-toggle' data-toggle='collapse' data-parent='#accordion'  href='#collapseevent<%# Eval("id")%>'>
                        <div class='panel-heading headsubject'>
                           <span class='glyphicon glyphicon-triangle-right'></span>
                              <span> <%# Eval("title")%>  </span><br />
                              On dated <%# Eval("date") %><br />
                              For <%# Eval("class") %><br />
                              -By <%# Eval("addtch") %>
                          </div>
                        <div class='panel-collapse collapse'>
                          <div class='panel-body'>
                      <div class="clearFix">
                              <%# Eval("descr")%> 
                          </div>
                         </div>
                        </div>
                       </div>
                    </ItemTemplate>
                </asp:ListView>
        <asp:Label ID="lbleventmgs" runat="server" Text=""></asp:Label>
   </div>
 
 <div id="india" class="w3-container city" style="display:none; padding: 0px;    margin: 0px;"">
 

      <h3>Timetable</h3>
       <div class="col-lg-12 col-sm-12 col-xs-12" style="padding: 0px;  margin: 0px;">
          
      </div>
  
              <asp:ListView ID="listtimetable" runat="server">
                        <ItemTemplate>
                               <%# Eval("class")%><br />
                               <%# Eval("time") %><br />
                               <%# Eval("course") %><br />
                               <%# Eval("subject") %>
                            <hr />
                         </ItemTemplate>
                </asp:ListView>
          <asp:Label ID="lbltimetablemgs" runat="server" Text=""></asp:Label>
       
  </div>
</div>

<script>
    function openCity(evt, cityName) {
        var i, x, tablinks;
        x = document.getElementsByClassName("city");
        for (i = 0; i < x.length; i++) {
            x[i].style.display = "none";
        }
        tablinks = document.getElementsByClassName("tablink");
        for (i = 0; i < x.length; i++) {
            tablinks[i].className = tablinks[i].className.replace(" w3-border-red", "");
        }
        document.getElementById(cityName).style.display = "block";
        evt.currentTarget.firstElementChild.className += " w3-border-red";
    }
</script>   
            </ContentTemplate>
        </asp:UpdatePanel>

    </div> 

</section></section>
       
</asp:Content>

