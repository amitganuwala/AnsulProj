<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zoom.aspx.cs" Inherits="Principal_zoom" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    
    

    <!-- Global stylesheets -->
    <link href="css1/bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Saira+Extra+Condensed:100,200,300,400,500,600,700,800,900" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet" />
    <link href="font-awesome1/css/font-awesome.min.css" rel="stylesheet" />
    <link href="css1/devicons/css/devicons.min.css" rel="stylesheet" />
    <link href="css1/simple-line-icons/css/simple-line-icons.css" rel="stylesheet" />
    <link href="css1/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
          <div class="modal-content">
              <div class="close-modal" data-dismiss="modal">
                  <div class="lr">
                      <div class="rl"></div>
                  </div>
              </div>
              <div class="container">
                  <div class="row">
                          <div class="modal-body">
                              <div class="title-bar">
                                <div class="col-md-12">
                                  <h2 class="text-center"><asp:Label ID="lblhead" runat="server"></asp:Label></h2>
                                  <div class="heading-border"></div>
                                </div>
                              </div>
                              <div class="row">
                                <div class="col-md-8">
                                 <asp:Image runat="server" ID="img" Height="650px" Width="700px" ImageUrl="zoom.aspx?pid='Request[id]'" class="img-fluid img-centered" />
                                <asp:Label ID="lblid" runat="server"></asp:Label></div>
                                <div class="col-md-4">
                                  <p><asp:Label runat="server" ID="description"></asp:Label></p>
                                 <asp:Button runat="server" class="btn btn-general btn-white" Text="Close" 
                                        onclick="Unnamed1_Click" />
                                      
                                  
                              </div>
                            </div>
                          </div>
                  </div>
              </div>
          </div>
      </div>
    </div>
    
    </div>
    </form>
</body>
</html>
