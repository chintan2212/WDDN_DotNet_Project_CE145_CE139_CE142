<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication8.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="navbar.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            margin-top: 4px;
        }
    </style>
</head>
    <script>
        function idvalidation(source, arguements) {
            var data = arguements.Value.split('');
            arguements.IsValid = false;
            if (isNaN(data)) {
                return;
            }
            
            arguements.IsValid = true;
            return;
        }
    </script>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            Enter Your Id :
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="* required"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
            <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="idvalidation" ControlToValidate="TextBox1" ErrorMessage="CustomValidator"></asp:CustomValidator>
            <br />
            <br />
            Enter Your Password:
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" ForeColor="Black" OnClick="Button1_Click" Text="Login" />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminLogin.aspx">Admin?</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
