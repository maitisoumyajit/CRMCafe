<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        Username<br />
    
        <asp:TextBox ID="txtUsrName" runat="server"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <asp:TextBox ID="txtPasswd" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="Button1_Click" />
    
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Forgot Password</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
