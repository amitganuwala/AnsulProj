<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" Debug="true" AutoEventWireup="true" CodeFile="upload.aspx.cs" Inherits="School_upload" %>

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
                  	 <br />
                          <asp:Button ID="download" runat="server" Text="Download Sample Excel File" CssClass="btn btn-block btn-primary" OnClick="download_Click"  />

                      <form class="form-inline" role="form">
                              <h3><asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label></h3>
            <br />
                          <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="class" DataValueField="class"></asp:DropDownList>
		            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>              

                          <div class="form-group"> 
                            Import Excel File:  
        <asp:FileUpload ID="FileUpload1" runat="server" />  
        <br />  
        <br />  
        <asp:Button ID="btnUpload" CssClass="btn btn-theme" runat="server" OnClick="btnUpload_Click" Text="Show Data" />  
        <br />  
        <br />  
                               <asp:Button ID="btnsend" CssClass="btn btn-theme" runat="server" OnClick="btnsend_Click" Text="UPLOAD" />  
                              <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>  
        <br />
                                
        <asp:GridView ID="gvExcelFile" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">  
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />  
            <EditRowStyle BackColor="#999999" />  
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />  
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />  
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />  
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />  
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />  
            <SortedAscendingCellStyle BackColor="#E9E7E2" />  
            <SortedAscendingHeaderStyle BackColor="#506C8C" />  
            <SortedDescendingCellStyle BackColor="#FFFDF8" />  
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />  
        </asp:GridView>  
       
                              
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
          	
          	
		</section><!--/wrapper -->
      </section><!-- /MAIN CONTENT -->

      <!--main content end-->


</asp:Content>

