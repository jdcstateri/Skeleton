<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 41px; position: absolute" Text="Order Viewer"></asp:Label>

        <asp:Label ID="lblAccountId" runat="server" style="z-index: 1; left: 40px; top: 93px; position: absolute" Text="Account ID to search:" width="63px"></asp:Label>
        <asp:TextBox ID="txtAccountId" runat="server" style="z-index: 1; left: 124px; top: 93px; position: absolute" width="156px"></asp:TextBox>

        <asp:Button ID="btnSearchByAccountId" runat="server" style="z-index: 1; left: 127px; top: 180px; position: absolute" Text="Search" width="60px" OnClick="btnSearchOrderById_Click" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 327px; top: 122px; position: absolute" ForeColor="Red"></asp:Label>

        <div class="container">
            <h3 style="z-index: 1; left: 10px; top: 124px; position: absolute">Orders</h3>
            <asp:ListBox ID="lstOrders" runat="server" CssClass="listbox" style="z-index: 1; left: 10px; top: 204px; position: absolute"></asp:ListBox>
        </div>
    </form>
</body>
</html>
