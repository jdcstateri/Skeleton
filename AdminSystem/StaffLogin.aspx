<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 2px; top: 2px; position: absolute; height: 114px; width: 1033px">
    Staff Login Page
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmail" runat="server" Style="left: 18px; top: 50px; position: absolute" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" Style="left: 137px; top: 50px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblPassword" runat="server" Style="left: 18px; top: 70px; position: absolute" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Style="left: 137px; top: 70px; position: absolute" TextMode="Password"></asp:TextBox>
        </div>
        <div>
             <asp:Label ID="lblError" runat="server" Text="[lblError]" Style=" left: 4px; top: 126px; position: absolute; height: 73px; width: 322px" ForeColor="#FF3300"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Style="left: 23px; top: 218px; position: absolute" />
            <asp:Button ID="btnCancel" runat="server"  Text="Cancel" Style="left: 136px; top: 219px; position: absolute" />
        </div>
    </form>
</body>
</html>
