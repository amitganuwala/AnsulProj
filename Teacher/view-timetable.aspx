<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="view-timetable.aspx.cs" Inherits="Teacher_view_timetable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>TIMETABLE's INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">

                              
                          <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" AutoPostBack="true"></asp:DropDownList>
                          
                          <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch1" Visible="false"></asp:Label>
                       
                            <h2><asp:Label runat="server" ID="lblsch" Text="school" ForeColor="Black"></asp:Label></h2>
                         
                       <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" AllowSorting="True" ShowHeader="False">
                           <Columns>
                             
                            
                               <asp:TemplateField HeaderText="title" SortExpression="title">
                                   <EditItemTemplate>
                                       <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("title") %>'></asp:TextBox>
                                   </EditItemTemplate>
                                   <ItemTemplate>
                                       <table class="table table-striped table-advance table-hover nav-justified text-center">
                                           <tr>
                                               <td colspan="8"><asp:Label runat="server" ID="lblsch" Text='<%# Eval("school") %>'></asp:Label></td>
                                           </tr>
                                           <tr>
                                               <td colspan="8"><asp:Label runat="server" ID="lbltitle" Text='<%# Eval("title") %>'></asp:Label><asp:Label runat="server" ID="lblid" Text='<%# Eval("id") %>'></asp:Label></td>
                                           </tr>
                                           <tr>
                                               <td colspan="8"><asp:Label runat="server" ID="lblclass" Text='<%# Eval("class") %>'></asp:Label></td>
                                           </tr>
                                           <tr>
                                               <td>Lecture -><br />Days</td>
                                               <td><asp:Label runat="server" ID="lbllec1" Text='<%# Eval("lec1") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec2" Text='<%# Eval("lec2") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec3" Text='<%# Eval("lec3") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label1" Text='<%# Eval("lecbrk") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec4" Text='<%# Eval("lec4") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec5" Text='<%# Eval("lec5") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec6" Text='<%# Eval("lec6") %>'></asp:Label></td>                                               
                                           </tr>
                                           <tr>
                                               <td><asp:Label runat="server" ID="lblday1" Text='<%# Eval("day1") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld1l1" Text='<%# Eval("d1l1") %>'></asp:Label><br /><asp:Label runat="server" ID="Label69" Text='<%# Eval("d1l1tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld1l2" Text='<%# Eval("d1l2") %>'></asp:Label><br /><asp:Label runat="server" ID="Label68" Text='<%# Eval("d1l2tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld1l3" Text='<%# Eval("d1l3") %>'></asp:Label><br /><asp:Label runat="server" ID="Label67" Text='<%# Eval("d1l3tch") %>'></asp:Label></td>
                                               <td><b>B</b></td>
                                               <td><asp:Label runat="server" ID="lbld1l4" Text='<%# Eval("d1l4") %>'></asp:Label><br /><asp:Label runat="server" ID="Label66" Text='<%# Eval("d1l4tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld1l5" Text='<%# Eval("d1l5") %>'></asp:Label><br /><asp:Label runat="server" ID="Label65" Text='<%# Eval("d1l5tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld1l6" Text='<%# Eval("d1l6") %>'></asp:Label><br /><asp:Label runat="server" ID="Label64" Text='<%# Eval("d1l6tch") %>'></asp:Label></td>                                               
                                           </tr>
                                           <tr>
                                               <td><asp:Label runat="server" ID="lblday2" Text='<%# Eval("day2") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld2l1" Text='<%# Eval("d2l1") %>'></asp:Label><br /><asp:Label runat="server" ID="Label63" Text='<%# Eval("d2l1tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld2l2" Text='<%# Eval("d2l2") %>'></asp:Label><br /><asp:Label runat="server" ID="Label62" Text='<%# Eval("d2l2tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld2l3" Text='<%# Eval("d2l3") %>'></asp:Label><br /><asp:Label runat="server" ID="Label61" Text='<%# Eval("d2l3tch") %>'></asp:Label></td>
                                               <td><b>R</b></td>
                                               <td><asp:Label runat="server" ID="lbld2l4" Text='<%# Eval("d2l4") %>'></asp:Label><br /><asp:Label runat="server" ID="Label60" Text='<%# Eval("d2l4tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld2l5" Text='<%# Eval("d2l5") %>'></asp:Label><br /><asp:Label runat="server" ID="Label59" Text='<%# Eval("d2l5tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbld2l6" Text='<%# Eval("d2l6") %>'></asp:Label><br /><asp:Label runat="server" ID="Label58" Text='<%# Eval("d2l6tch") %>'></asp:Label></td>                                               
                                           </tr>
                                           <tr>
                                               <td><asp:Label runat="server" ID="Label2" Text='<%# Eval("day3") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label3" Text='<%# Eval("d3l1") %>'></asp:Label><br /><asp:Label runat="server" ID="Label57" Text='<%# Eval("d3l1tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label4" Text='<%# Eval("d3l2") %>'></asp:Label><br /><asp:Label runat="server" ID="Label56" Text='<%# Eval("d3l2tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label5" Text='<%# Eval("d3l3") %>'></asp:Label><br /><asp:Label runat="server" ID="Label55" Text='<%# Eval("d3l3tch") %>'></asp:Label></td>
                                               <td><b>E</b></td>
                                               <td><asp:Label runat="server" ID="Label7" Text='<%# Eval("d3l4") %>'></asp:Label><br /><asp:Label runat="server" ID="Label54" Text='<%# Eval("d3l4tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label8" Text='<%# Eval("d3l5") %>'></asp:Label><br /><asp:Label runat="server" ID="Label53" Text='<%# Eval("d3l5tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label9" Text='<%# Eval("d3l6") %>'></asp:Label><br /><asp:Label runat="server" ID="Label52" Text='<%# Eval("d3l6tch") %>'></asp:Label></td>                                               
                                           </tr>
                                           <tr>
                                               <td><asp:Label runat="server" ID="Label10" Text='<%# Eval("day4") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label11" Text='<%# Eval("d4l1") %>'></asp:Label><br /><asp:Label runat="server" ID="Label51" Text='<%# Eval("d4l1tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label12" Text='<%# Eval("d4l2") %>'></asp:Label><br /><asp:Label runat="server" ID="Label50" Text='<%# Eval("d4l2tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label13" Text='<%# Eval("d4l3") %>'></asp:Label><br /><asp:Label runat="server" ID="Label49" Text='<%# Eval("d4l3tch") %>'></asp:Label></td>
                                               <td><b>A</b></td>
                                               <td><asp:Label runat="server" ID="Label15" Text='<%# Eval("d4l4") %>'></asp:Label><br /><asp:Label runat="server" ID="Label48" Text='<%# Eval("d4l4tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label16" Text='<%# Eval("d4l5") %>'></asp:Label><br /><asp:Label runat="server" ID="Label47" Text='<%# Eval("d4l5tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label17" Text='<%# Eval("d4l6") %>'></asp:Label><br /><asp:Label runat="server" ID="Label46" Text='<%# Eval("d4l6tch") %>'></asp:Label></td>                                               
                                           </tr>
                                           <tr>
                                               <td><asp:Label runat="server" ID="Label18" Text='<%# Eval("day5") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label19" Text='<%# Eval("d5l1") %>'></asp:Label><br /><asp:Label runat="server" ID="Label45" Text='<%# Eval("d5l1tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label20" Text='<%# Eval("d5l2") %>'></asp:Label><br /><asp:Label runat="server" ID="Label44" Text='<%# Eval("d5l2tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label21" Text='<%# Eval("d5l3") %>'></asp:Label><br /><asp:Label runat="server" ID="Label43" Text='<%# Eval("d5l3tch") %>'></asp:Label></td>
                                               <td><b>K</b></td>
                                               <td><asp:Label runat="server" ID="Label23" Text='<%# Eval("d5l4") %>'></asp:Label><br /><asp:Label runat="server" ID="Label42" Text='<%# Eval("d5l4tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label24" Text='<%# Eval("d5l5") %>'></asp:Label><br /><asp:Label runat="server" ID="Label41" Text='<%# Eval("d5l5tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label25" Text='<%# Eval("d5l6") %>'></asp:Label><br /><asp:Label runat="server" ID="Label40" Text='<%# Eval("d5l6tch") %>'></asp:Label></td>                                               
                                           </tr>
                                           <tr>
                                               <td><asp:Label runat="server" ID="Label26" Text='<%# Eval("day6") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label27" Text='<%# Eval("d6l1") %>'></asp:Label><br /><asp:Label runat="server" ID="Label34" Text='<%# Eval("d6l1tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label28" Text='<%# Eval("d6l2") %>'></asp:Label><br /><asp:Label runat="server" ID="Label35" Text='<%# Eval("d6l2tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label29" Text='<%# Eval("d6l3") %>'></asp:Label><br /><asp:Label runat="server" ID="Label36" Text='<%# Eval("d6l3tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label30"><br /></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label31" Text='<%# Eval("d6l4") %>'></asp:Label><br /><asp:Label runat="server" ID="Label37" Text='<%# Eval("d6l4tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label32" Text='<%# Eval("d6l5") %>'></asp:Label><br /><asp:Label runat="server" ID="Label38" Text='<%# Eval("d6l5tch") %>'></asp:Label></td>
                                               <td><asp:Label runat="server" ID="Label33" Text='<%# Eval("d6l6") %>'></asp:Label><br /><asp:Label runat="server" ID="Label39" Text='<%# Eval("d6l6tch") %>'></asp:Label></td>                                               
                                           </tr>
                                       </table>
                                   </ItemTemplate>
                               </asp:TemplateField>
                           </Columns>
                        </asp:GridView>



<%--                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [timetable] WHERE (([class] = @class) AND ([school] = @school)) ORDER BY [id] DESC">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="DropDownList1" Name="class" PropertyName="SelectedValue" Type="String" />
                                  <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                              </SelectParameters>
                        </asp:SqlDataSource>--%>



                          </div></div></div>

              </section></section>

</asp:Content>

