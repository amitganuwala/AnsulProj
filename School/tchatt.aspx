<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="tchatt.aspx.cs" Inherits="School_tchatt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD ATTENDANCE...</h3>
          	  <asp:Label runat="server" ID="lbltchnm"  ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" ></asp:Label>
                       
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                          
                    <br /> Today is <asp:Label runat="server" ID="lblday"></asp:Label> ..

                         
                          
    <asp:GridView ID="GridView1" class="table table-hover" runat="server" AllowSorting="True" 
                              AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
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
                                          <asp:TextBox runat="server" ID="txttime"></asp:TextBox>                               
                                    </ItemTemplate>

<ControlStyle ForeColor="Black"></ControlStyle>
                                    </asp:TemplateField>


        </Columns>
                          </asp:GridView>
   
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                              ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                              SelectCommand="SELECT [id], [name] FROM [teacher] WHERE ([school] = @school) ORDER BY [name]">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                      Type="String" />
                              </SelectParameters>
                          </asp:SqlDataSource>
 <asp:Button runat="server" class="btn btn-theme" ID="Button1" Text="Add Information" OnClick="Button1_Click"  />

          			</div>
          		</div></div> 

              
          </section></section>
  
</asp:Content>

