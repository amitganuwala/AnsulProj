<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="allot-subject.aspx.cs" Inherits="HOD_subject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD SUBJECT INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-6">
          			<div class="form-panel">
                  	     <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                      <form class="form-inline" role="form">
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Teacher Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                             <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" ></asp:DropDownList>
                               </div>
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              
                              <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" ></asp:DropDownList>
                         
                               </div>
                           <div class="form-group">
                             <asp:Label ID="Label4" runat="server" Text="Select Subject : " Font-Bold="true" ForeColor="Black"></asp:Label>
                             
                               <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                         
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Allot Subject" OnClick="btnadd_Click"  />
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	

            	<div class="col-lg-6">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> Teacher Information</h4>
            
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="name" HeaderText="name" SortExpression="name"  />
                                  <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                  <asp:BoundField DataField="subject" HeaderText="subject" SortExpression="subject" />
                                  <asp:BoundField DataField="school" HeaderText="school" SortExpression="school" />
                              </Columns>
                                    </asp:GridView>
                         
                                   
                         </div></div></div>

                         
                         


              </section></section>

</asp:Content>

