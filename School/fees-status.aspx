<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="fees-status.aspx.cs" Inherits="School_fees_status" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right">
                </i>ADD NOTICE...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
    
                             <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                    
                      <form class="form-inline" role="form">
                        
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:DropDownList CssClass="form-control" ID="DropDownList1" AppendDataBoundItems="true" runat="server" AutoPostBack="true" DataSourceID="SqlDataSource2" DataTextField="class" DataValueField="class"></asp:DropDownList>
          	
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                    </SelectParameters>
              </asp:SqlDataSource>

                          </div>
                           <div class="form-group">
                             <asp:Label ID="Label3" runat="server" Text="Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:DropDownList CssClass="form-control" ID="DropDownList2" 
                                      AppendDataBoundItems="True" runat="server" AutoPostBack="True" 
                                      DataSourceID="SqlDataSource3" DataTextField="name" DataValueField="name"></asp:DropDownList>
          	
                                  <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                                      ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                      SelectCommand="SELECT [name] FROM [parent] WHERE (([class] = @class) AND ([school] = @school)) ORDER BY [name]">
                                      <SelectParameters>
                                          <asp:ControlParameter ControlID="DropDownList1" Name="class" 
                                              PropertyName="SelectedValue" Type="String" />
                                          <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                              Type="String" />
                                      </SelectParameters>
                                  </asp:SqlDataSource>
                          </div>

                             <asp:Label ID="Label6" runat="server" Text="Fees Type: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:DropDownList CssClass="form-control" ID="DropDownList3" 
                                      AppendDataBoundItems="True" runat="server" AutoPostBack="True" 
                                      DataSourceID="SqlDataSource4" DataTextField="type" 
                                   DataValueField="type"></asp:DropDownList>
          	
                                  <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                                   ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                   SelectCommand="SELECT [type] FROM [fees] WHERE (([class] = @class) AND ([school] = @school)) ORDER BY [id] DESC">
                                      <SelectParameters>
                                          <asp:ControlParameter ControlID="DropDownList1" Name="class" 
                                              PropertyName="SelectedValue" Type="String" />
                                          <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                              Type="String" />
                                      </SelectParameters>
                               </asp:SqlDataSource>
                          
                       <asp:GridView runat="server" ID="gr" AutoGenerateColumns="False" 
                              DataSourceID="SqlDataSource1" AllowSorting="True" DataKeyNames="id">
                           <Columns>
                               <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                   ReadOnly="True" SortExpression="id" />
                               <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                               <asp:BoundField DataField="fees" HeaderText="fees" SortExpression="fees" />
                               <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                           </Columns>
                          </asp:GridView>
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                              ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                              
                        SelectCommand="SELECT [id], [type], [fees], [date] FROM [fees] WHERE (([class] = @class) AND ([school] = @school) AND ([type] = @type))">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="DropDownList1" Name="class" 
                                      PropertyName="SelectedValue" Type="String" />
                                  <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                      Type="String" />
                                  <asp:ControlParameter ControlID="DropDownList3" Name="type" 
                                      PropertyName="SelectedValue" Type="String" />
                              </SelectParameters>
                          </asp:SqlDataSource>
                          
                             <asp:Label ID="Label1" runat="server" Text=" Reciept no.: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="no" ></asp:TextBox>
                          
                         
                             <asp:Label ID="Label4" runat="server" Text=" Submission Date: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="subdate"></asp:TextBox>
                         
                         
                             <asp:Label ID="Label5" runat="server" Text=" Payment Method: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="paidby" placeholder="Cash / Cheque..."></asp:TextBox>
                             <asp:Label ID="Label7" runat="server" Text="Fees Ammount: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="fees" placeholder="In numbers..(1000/-)"></asp:TextBox>
                             <asp:Label ID="Label8" runat="server" Text=" Ammount in Words: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="words" ></asp:TextBox>
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" 
                                 Text="Add Information" onclick="btnadd_Click"   />
                      </div>
                      </form>
          			</div><!-- /form-panel -->

</asp:Content>

