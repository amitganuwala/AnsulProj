<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apk.aspx.cs" Inherits="apk" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta name="viewport" content="width=device-width, initial-scale=1">
<meta charset="utf-8">
<meta name="keywords" content="Graduation a Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />

<!-- default-css-files -->
	<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
	<link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" media="all" />
<!-- default-css-files -->

<!-- gallery css file-->
<link rel="stylesheet" href="css/lightGallery.css" type="text/css" media="all" />
<!-- //gallery css file-->

<!-- Online fonts -->
	<link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i&amp;subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese" rel="stylesheet" />
	<link href="//fonts.googleapis.com/css?family=Titillium+Web:200,200i,300,300i,400,400i,600,600i,700,700i,900" rel="stylesheet" />
<!-- //Online fonts -->

<!-- style.css-file -->
	<link href="css/style.css" rel='stylesheet' type='text/css' />
<!-- //style.css-file -->

<!-- Script-for-nav-scrolling -->
<script type="text/javascript">
    jQuery(document).ready(function ($) {
        $(".scroll").click(function (event) {
            event.preventDefault();
            $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
        });
    });
</script> 
<!-- //Script-for-nav-scrolling -->

<!-- Default-JavaScript-File -->
	<script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
<!-- //Default-JavaScript-File -->

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br /><br />
      <br />
            <asp:Button Text="Download Apk" CssClass="btn btn-primary btn-theme btn-block" runat="server" ID="btndownload" OnClick="btndownload_Click" />
            <br />
            <br /><br /><br />
    </div>
    </form>
</body>
</html>
