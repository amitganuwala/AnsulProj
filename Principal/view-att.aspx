<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="view-att.aspx.cs" Inherits="Principal_view_att" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>VIEW ATTENDANCE...</h3>
          	  <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                   
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">

                               <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="class" DataValueField="class" ></asp:DropDownList>
              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id] DESC">
                  <SelectParameters>
                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                  </SelectParameters>
              </asp:SqlDataSource>
                   
                      

                    <br /> 

                         
                          
    <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
            <asp:BoundField DataField="class" HeaderText="Class" SortExpression="class" />
            <asp:BoundField DataField="date" HeaderText="Date" SortExpression="date" />
            <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
            <asp:BoundField DataField="school" HeaderText="School" SortExpression="school" />
        </Columns>
                               </asp:GridView>


                               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [name], [class], [date], [status], [school] FROM [attendance] WHERE (([school] = @school) AND ([class] = @class)) ORDER BY [name]">
                                   <SelectParameters>
                                       <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                       <asp:ControlParameter ControlID="DropDownList2" Name="class" PropertyName="SelectedValue" Type="String" />
                                   </SelectParameters>
                               </asp:SqlDataSource>


                          </div></div></div>
              <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" ></asp:DropDownList>
              </section></section>


</asp:Content>

