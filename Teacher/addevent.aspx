<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="addevent.aspx.cs" Inherits="Teacher_addevent" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD EVENT's INFORMATION...</h3>
          	           <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                
             <div class="row mt">           
                           <div class="col-lg-12">
                           <div class="form-panel">
                           <div class="row">
                           <div class="col-lg-5">
                           
                           <div class="form-group">
                          <asp:Label ID="Label2" runat="server" Text="Date:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtdate"></asp:TextBox>
                                     </div>
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Event Title: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtevent" placeholder="Example :- Annual day Celebration"></asp:TextBox>
                           </div>
                           <cc1:ToolkitScriptManager ID="ToolkitScriptManager2" runat="server"></cc1:ToolkitScriptManager>
                         
                          <div class="form-group">
                                <asp:Label ID="Label3" runat="server" Text="Description:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" ID="txtdescr" class="form-control" placeholder="Details about event goes here"></asp:TextBox>
                          </div>
                              </div>
                          <div class="col-lg-1">
                          <br />
                              <asp:ImageButton ID="img" runat="server" Height="20px" Width="20px" ImageUrl="~/Principal/icons/6-512.png" />
                                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" PopupPosition="BottomRight" TargetControlID="txtdate" PopupButtonID="img"></cc1:CalendarExtender>
                             </div>

                          <div class="col-lg-5">
                         <div class="form-group">
                                <asp:Label ID="Label4" runat="server" Text="Class:" Font-Bold="true" ForeColor="Black"></asp:Label>
                          <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" AppendDataBoundItems="true"></asp:DropDownList>
           </div>      
                          <div class="form-group">
                                <asp:Label ID="Label5" runat="server" Text="Event Photo:" Font-Bold="true" ForeColor="Black"></asp:Label>
                            <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="Button2" class="btn" runat="server" Text="UploadPic" OnClick="Button2_Click" /> <- Click Here first after selecting Photo...
                              <asp:TextBox runat="server" ID="txtpic" class="form-control" placeholder="Image name goes here."></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="Button3" Text="Add Information" OnClick="btnadd2_Click" />
                    </div></div></div></div></div>
                          
                </section></section>

                </asp:Content>