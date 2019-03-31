<%@ Page Title="" Language="C#" MasterPageFile="~/parent/MasterPage.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="parent_update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div id="mainSchool">
  <div class="text-center center-block">
     <asp:Label runat="server" ID="lblstdnm"  ></asp:Label><br />
                           <asp:Label runat="server" ID="lblsch" ></asp:Label><br />
              <asp:Label runat="server" ID="lblclass" ></asp:Label><br />
  	<h3><i class="fa fa-angle-right"></i> Update Profile</h3>
                                <asp:Label runat="server" ID="lblid"  ></asp:Label>
                                </div>
                       <br /><hr />
                       
                             <asp:Label ID="Label3" runat="server" Text="Update Mobile No. : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" id="txtmob"></asp:TextBox>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnmob" Text="Update" OnClick="btnmob_Click" />
                      
    <hr />
    <br /><br /><br />
                      
                                <asp:Label ID="Label4" runat="server" Text="Update Address:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" id="txtaddr" ></asp:TextBox>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Update" OnClick="btnadd_Click" />
                       <br /><br /><br />
          <hr />        	 
                             <asp:Label ID="Label5" runat="server" Text="Change Password: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" id="txtpass" ></asp:TextBox>
                          <br />
                                <asp:Label ID="Label6" runat="server" Text="Change User ID:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" id="txtusr" ></asp:TextBox>
                      
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnpass" Text="Change" OnClick="btnpass_Click" />
                      
                <br /><br /><br />
                <hr />  	 
                                <asp:Label ID="Label8" runat="server" Text="Change Profile Pic:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:FileUpload ID="FileUpload1" runat="server" />
                              <asp:TextBox runat="server" id="txtpic" Visible="false" ></asp:TextBox>
                          
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnpic" Text="Add Information" OnClick="btnpic_Click" />
       
        <br /><hr />
        
         </div>



</asp:Content>

