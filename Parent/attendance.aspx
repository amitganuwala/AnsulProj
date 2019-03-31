<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" Debug="true" AutoEventWireup="true" CodeFile="attendance.aspx.cs" Inherits="Teacher_attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    
    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD STUDENT's INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                           <asp:Label runat="server" ID="lblsch" Font-Size="XX-Large" ForeColor="Black"></asp:Label><br />  
                    <br />
                         <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" DataSourceID="SqlDataSource2" DataTextField="stu" DataValueField="stu"></asp:DropDownList>
                           <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [stu] FROM [parent] WHERE ([usr] = @usr)">
                               <SelectParameters>
                                   <asp:SessionParameter Name="usr" SessionField="Parent_name" Type="String" />
                               </SelectParameters>
              </asp:SqlDataSource>
                        
                          <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3" DataTextField="class" DataValueField="class"></asp:DropDownList>



              <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [parent] WHERE ([stu] = @stu)">
                  <SelectParameters>
                      <asp:ControlParameter ControlID="DropDownList1" Name="stu" PropertyName="SelectedValue" Type="String" />
                  </SelectParameters>
              </asp:SqlDataSource>


                    
                          <br />

    <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
            <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
           <asp:BoundField DataField="daay" HeaderText="daay" SortExpression="daay" />
           <asp:BoundField DataField="subject" HeaderText="subject" SortExpression="subject" />
            <asp:BoundField DataField="time" HeaderText="time" SortExpression="time" />
            <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            <asp:BoundField DataField="school" HeaderText="school" SortExpression="school" />
        </Columns>
    </asp:GridView>
 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [name], [class], [date], [daay], [subject], [time], [status], [school] FROM [attendance] WHERE (([name] = @name) AND ([school] = @school) AND ([class] = @class)) ORDER BY [id] DESC">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="name" PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
            <asp:ControlParameter ControlID="DropDownList2" Name="class" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
                           

          			</div>
          		</div></div> 

              

          </section></section>

</asp:Content>

