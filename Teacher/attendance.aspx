<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" Debug="true" AutoEventWireup="true" CodeFile="attendance.aspx.cs" Inherits="Teacher_attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lbl" runat="server" Visible="false"></asp:Label>
    
    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD ATTENDANCE...</h3>
          	  <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                       
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                          <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="class" DataValueField="class" ></asp:DropDownList>
              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id] DESC">
                  <SelectParameters>
                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                  </SelectParameters>
              </asp:SqlDataSource>
                    <br /> Today is <asp:Label runat="server" ID="lblday"></asp:Label> ..

                         
                          
    <asp:GridView ID="GridView1" class="table table-hover" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="roll" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="class" HeaderText="class" Visible="false" SortExpression="class" />
           <asp:BoundField DataField="school" HeaderText="school" Visible="false" SortExpression="school" />
           

                <asp:TemplateField HeaderText="" ControlStyle-ForeColor="Black">

                                    <ItemTemplate>
                                       <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server" AutoPostBack="true">
                                            <asp:ListItem Value="Present" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="Absent"></asp:ListItem>
                                        </asp:RadioButtonList>
                               
                                    </ItemTemplate>

<ControlStyle ForeColor="Black"></ControlStyle>
                                    </asp:TemplateField>

            
                                         <asp:TemplateField HeaderText="" ControlStyle-ForeColor="Black">

                                    <ItemTemplate>
   
                                          <asp:Label runat="server" ID="lbldate" Text="<%# (System.DateTime.Now.ToShortDateString()) %>"></asp:Label>
                                        
                                    </ItemTemplate>

<ControlStyle ForeColor="Black"></ControlStyle>
                                    </asp:TemplateField>
   
                                     
   
            <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
   
                                     
   
        </Columns>
    </asp:GridView>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [id], [name], [class], [mob], [school] FROM [parent] WHERE (([class] = @class) AND ([school] = @school)) ORDER BY [name]">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="class" PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
                             <asp:Button runat="server" class="btn btn-theme" ID="Button1" Text="Add Information" OnClick="Button1_Click"  />

          			</div>
          		</div>
                
                <div class="col-lg-4">
                <h4>Send SMS to absent students</h4><br />
                <asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox><br />

                <h4>Send SMS to all students</h4><br />
                <asp:CheckBox ID="CheckBox2" runat="server"></asp:CheckBox><br />

                </div>               
                </div> 

              
          </section></section>

</asp:Content>

