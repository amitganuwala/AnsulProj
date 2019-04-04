<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="viewtch.aspx.cs" Inherits="Principal_viewtch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="main-content">
          <section class="wrapper">
                  <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
              	
              <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> Teacher Information</h4>
                
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False"  AllowSorting="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                              <Columns>

                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                    
                                  <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                  <asp:BoundField DataField="post" HeaderText="post" SortExpression="post" />
                                  <asp:BoundField DataField="addr" HeaderText="addr" SortExpression="addr" />
                                  <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                  <asp:BoundField DataField="usr" HeaderText="usr" SortExpression="usr" ReadOnly="True" />
                                  <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                  <asp:BoundField DataField="school" HeaderText="school" SortExpression="school" />
                                  
                              </Columns>
                                    </asp:GridView>
          	


                                 </div></div></div></section></section>

</asp:Content>

