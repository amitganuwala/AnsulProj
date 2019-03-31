<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="course.aspx.cs" Inherits="Teacher_event_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>Course's INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">

                          <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                       
                            <h2><asp:Label runat="server" ID="lblsch" Text="school" ForeColor="Black"></asp:Label></h2>
                         
                       <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" AllowSorting="True">
                           <Columns>
                               <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" 
                                   ReadOnly="True" SortExpression="id" />
                               <asp:BoundField DataField="subject" HeaderText="Subject" 
                                   SortExpression="subject" />
                               <asp:BoundField DataField="class" HeaderText="Class" SortExpression="class" />
                               <asp:BoundField DataField="day" HeaderText="Day" SortExpression="day" />
                               <asp:BoundField DataField="date" HeaderText="Date" SortExpression="date" />
                               <asp:BoundField DataField="time" HeaderText="Time" SortExpression="time" />
                               <asp:BoundField DataField="course" HeaderText="Course" 
                                   SortExpression="course" />
                           </Columns>
                          </asp:GridView>
                           
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                              ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                              SelectCommand="SELECT [id], [subject], [class], [day], [date], [time], [course] FROM [course] WHERE (([tchnm] = @tchnm) AND ([school] = @school)) ORDER BY [id] DESC">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="lbltchnm" Name="tchnm" PropertyName="Text" 
                                      Type="String" />
                                  <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                      Type="String" />
                              </SelectParameters>
                          </asp:SqlDataSource>
                           
                      </div></div></div></section></section>



</asp:Content>

