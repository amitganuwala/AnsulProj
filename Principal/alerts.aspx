<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="alerts.aspx.cs" Inherits="Principal_alerts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <section id="main-content">
          <section class="wrapper">
          
          	
          <div class="row">
          		<div class="col-lg-12">
          			<div class="form-panel">
                    	<div class="form-panel">
                           <asp:Label runat="server" ID="lblprinm" Visible="false" ></asp:Label>
                         <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                       
                    
                                    <h4><i class="fa fa-angle-right"></i> Alert Information</h4>
            <br /><br />

            <asp:Button ID="btn" class="btn btn-primary btn-success" runat="server" onclick="btn_Click" Text="Add Alerts" />
            <br /><br />
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" 
                                        runat="server" AutoGenerateColumns="False" AllowSorting="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" />
                                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                      ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="tname" HeaderText="tname" SortExpression="tname" />
                                  <asp:BoundField DataField="msg" HeaderText="msg" SortExpression="msg" />
                                  <asp:BoundField DataField="school" HeaderText="school" 
                                      SortExpression="school" />
                                  <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                  <asp:CommandField ShowEditButton="True" />
                              </Columns>
            
            </asp:GridView>



            </div></div></div>
            </section></section>
</asp:Content>

