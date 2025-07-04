﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 41px; position: absolute" Text="Order system login"></asp:Label>
        
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 40px; top: 93px; position: absolute" Text="Email:" width="63px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 124px; top: 93px; position: absolute" width="156px"></asp:TextBox>

        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 40px; top: 122px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 124px; top: 122px; position: absolute; width: 156px;" TextMode="Password"></asp:TextBox>

        <div>
            <asp:CheckBox ID="checkStaff" runat="server" Style="z-index: 1; left: 40px; top: 151px; position: absolute" Text="Are you logging in as staff?" />
        </div>

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 327px; top: 122px; position: absolute" ForeColor="Red"></asp:Label>

        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 127px; top: 180px; position: absolute" Text="Login" width="60px" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 222px; top: 180px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    
    </form>
</body>
</html>
