<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="tchatt.aspx.cs" Inherits="Teacher_tchatt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <section id="main-content">
          <section class="wrapper">


<div class="col-xs-8 col-xs-offset-2">
<div class="panel panel-primary">
<div class="panel-heading">
<h3>Employee Search Form</h3>
</div>
<div class="panel-body">
<div class="form-group">
<label class="control-label col-xs-2">Name</label>
<asp:TextBox runat="server" ID="txtname" class="form-control"></asp:TextBox>
<label class="control-label col-xs-2">Day</label>
<asp:TextBox runat="server" ID="txtday" class="form-control"></asp:TextBox>
<div class="col-xs-10 col-xs-offset-2">
<asp:Button Text="Search" ID="btn" CssClass="btn btn-primary" runat="server" 
        onclick="btn_Click" />
</div>
</div>
</div>
</div>

<div class="panel panel-primary">
<div class="panel-heading">
<h3>Search Results</h3>
</div>
<div class="panel-body">
<div class="col-xs-10">
<asp:GridView class="table table-bordered" ID="grdvw" runat="server"></asp:GridView>
</div>
</div>
</div>
</div>
</section></section>
</asp:Content>

