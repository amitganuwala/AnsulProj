<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="course.aspx.cs" Inherits="pr_list" %>

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

                          <asp:Label runat="server" ID="lbltchnm" Visible="false" Text="payal" ></asp:Label>
                       
                            <h2><asp:Label runat="server" ID="lblsch" Text="school" ForeColor="Black"></asp:Label></h2>
                         
                       <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" AllowSorting="True">
                           <Columns>
                               <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" 
                                   ReadOnly="True" SortExpression="id" />
                               <asp:BoundField DataField="subject" HeaderText="Subject" 
                                   SortExpression="subject" />
                               <asp:BoundField DataField="class" HeaderText="Class" SortExpression="class" />
                               <asp:BoundField DataField="school" HeaderText="School" 
                                   SortExpression="school" />
                               <asp:BoundField DataField="tchnm" HeaderText="Teacher name" SortExpression="tchnm" />
                               <asp:BoundField DataField="day" HeaderText="Day" SortExpression="day" />
                               <asp:BoundField DataField="date" HeaderText="Date" 
                                   SortExpression="date" />
                               <asp:BoundField DataField="time" HeaderText="Time" SortExpression="time" />
                               <asp:BoundField DataField="course" HeaderText="Course" 
                                   SortExpression="course" />
                           </Columns>
                          </asp:GridView>
                           
                           
                      </div></div></div></section></section>



</asp:Content>

