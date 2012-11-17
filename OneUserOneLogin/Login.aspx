<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OneUserOneLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSubmit" runat="server" Text="Button" OnClick="ButtonSubmit_Click" /><br />
        <asp:Label ID="LabelWelcome" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
