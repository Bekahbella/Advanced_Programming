<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Class3_14_16._Default"  EnableViewState="false"%>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to your page!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    <p> More content can be added here. 
    </p>
    <asp:DropDownList ID="DropDownList1" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem>Becky</asp:ListItem>
    <asp:ListItem>George Clooney</asp:ListItem>
    <asp:ListItem>Bill</asp:ListItem>
    <asp:ListItem>Aardvark</asp:ListItem>
      
    
    </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Button" />

 <div>
    
        <asp:Label ID="lblFirstName" runat="server" Text="First Name "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="First Name is Required"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Last Name is Required"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    </div>


</asp:Content>
