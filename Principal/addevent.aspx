﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="addevent.aspx.cs" Inherits="Principal_addevent" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD EVENT's INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	
          		           <asp:Label runat="server" ID="lblprinm" Visible="false" ></asp:Label>
                         <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Visible="false" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
            <div class="row mt">           
                           <div class="col-lg-12">
                           <div class="form-panel">
                           <div class="row">
                           <div class="col-lg-5">
                           
                           <div class="form-group">
                          
                                <asp:Label ID="Label2" runat="server" Text="Date:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtdate" placeholder="Example :- DD/MM/YYYY"></asp:TextBox>
                              </div>
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Event Title: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtevent" placeholder="Example :- Annual day Celebration"></asp:TextBox>
                          </div>
                           <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
                         
                          <div class="form-group">
                                <asp:Label ID="Label3" runat="server" Text="Description:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" ID="txtdescr" class="form-control" placeholder="Details about event goes here"></asp:TextBox>
                          </div>
                              </div>
                          <div class="col-lg-1">
                          <br />
                              <asp:ImageButton ID="img" runat="server" Height="20px" Width="20px" ImageUrl="~/Principal/icons/6-512.png" />
                                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" PopupPosition="BottomRight" TargetControlID="txtdate" PopupButtonID="img"></cc1:CalendarExtender>
                             </div>

                          <div class="col-lg-5">
                         <div class="form-group">
                                <asp:Label ID="Label4" runat="server" Text="Class:" Font-Bold="true" ForeColor="Black"></asp:Label>
                          <asp:DropDownList CssClass="form-control" ID="DropDownList1" AppendDataBoundItems="true" runat="server" DataSourceID="SqlDataSource2" DataTextField="class" DataValueField="class"></asp:DropDownList>
          	
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                    </SelectParameters>
              </asp:SqlDataSource>
          	           </div>      
                          <div class="form-group">
                                <asp:Label ID="Label5" runat="server" Text="School Photo:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" /><- Click here to upload photo..
                              <asp:TextBox runat="server" ID="txtpic" class="form-control" Visible="false"></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme03" ID="Button3" Text="Add Information" OnClick="btnadd2_Click" />
                    </div></div></div></div></div>
                          
                </section></section>

</asp:Content>

