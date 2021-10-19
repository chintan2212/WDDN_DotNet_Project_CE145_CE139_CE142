<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sem5.aspx.cs" Inherits="WebApplication8.sem5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="navbar.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="AA"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ``<asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="WDDN"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="MFP"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="AT"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ``
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="OS"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; `&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
