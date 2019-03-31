<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="addhomework.aspx.cs" Inherits="Teacher_addhomework" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD HOMEWORK...</h3>
          	
                             <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
            
                <div class="row mt">           
                           <div class="col-lg-12">
                           <div class="form-panel">
                           <div class="row">
                           <div class="col-lg-5">
                           
                           <div class="form-group">
                          
                                <asp:Label ID="Label2" runat="server" Text="Submission Date:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtsubdt" ></asp:TextBox>
                             </div>
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Select Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:DropDownList ID="DropDownList1" class="form-control" runat="server" AutoPostBack="true" DataSourceID="SqlDataSource37" DataTextField="class" DataValueField="class"></asp:DropDownList>
                          <asp:SqlDataSource ID="SqlDataSource37" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [subject] WHERE (([name] = @name) AND ([school] = @school))">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="lbltchnm" Name="name" PropertyName="Text" Type="String" />
                                  <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                              </SelectParameters>
                        </asp:SqlDataSource>
                          </div>
                           <cc1:ToolkitScriptManager ID="ToolkitScriptManager2" runat="server"></cc1:ToolkitScriptManager>
                         
                          <div class="form-group">
                                     <asp:Label ID="Label3" runat="server" Text="Subject:" Font-Bold="true" ForeColor="Black"></asp:Label>
                             <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server" DataSourceID="SqlDataSource3" DataTextField="subject" DataValueField="subject"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [subject] FROM [subject] WHERE (([class] = @class) AND ([name] = @name) AND ([school] = @school))">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="DropDownList1" Name="class" PropertyName="SelectedValue" Type="String" />
                                        <asp:ControlParameter ControlID="lbltchnm" Name="name" PropertyName="Text" Type="String" />
                                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                    </SelectParameters>
              </asp:SqlDataSource>
                     </div>
                              </div>
                          <div class="col-lg-1">
                          <br />
                              <asp:ImageButton ID="img" runat="server" Height="20px" Width="20px" ImageUrl="~/Principal/icons/6-512.png" />
                                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" PopupPosition="BottomRight" TargetControlID="txtsubdt" PopupButtonID="img"></cc1:CalendarExtender>
                             </div>

                          <div class="col-lg-5">
                         <div class="form-group">
                                <asp:Label ID="Label4" runat="server" Text="Homework Details:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txthw" placeholder="Example :- Description goes here."></asp:TextBox>
                      </div>      
                          <div class="form-group">
                                <asp:Label ID="Label5" runat="server" Text="School Photo:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="Button2" class="btn" runat="server" Text="UploadPic" OnClick="Button2_Click" /> <- Click Here first after selecting Photo...
                              <asp:TextBox runat="server" ID="txtpic" class="form-control" placeholder="Image name goes here."></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="Button3" Text="Add Information" OnClick="btnadd2_Click" />
                    </div></div></div></div></div>
            

                
               
    </section></section>

</asp:Content>

