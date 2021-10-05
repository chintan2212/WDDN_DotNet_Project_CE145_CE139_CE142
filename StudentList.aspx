<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="WebApplication8.StudentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="navbar.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
	            <a href="#">Home</a>
	            <a href="Student_Register.aspx">Register</a>
	            <a href="#">Logout</a>
	            <a href="#">Contact Us</a>
            </nav>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="student_name" HeaderText="student_name" SortExpression="student_name" />
                    <asp:HyperLinkField Text="open profile" DataNavigateUrlFields="Id,student_name" DataNavigateUrlFormatString="profile.aspx?Id={0}&Name={1}" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Student_managementConnectionString %>" SelectCommand="SELECT [Id], [student_name] FROM [Students]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
