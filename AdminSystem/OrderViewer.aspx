<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3 style="z-index: 1; left: 10px; top: 41px; position: absolute">Order Viewer</h3>

        <asp:Label ID="lblAccountId" runat="server" style="z-index: 1; left: 10px; top: 98px; position: absolute" Text="Account ID to search:" width="143px"></asp:Label>
        <asp:TextBox ID="txtAccountId" runat="server" style="z-index: 1; left: 164px; top: 98px; position: absolute" width="156px"></asp:TextBox>

        <asp:Button ID="btnSearchByAccountId" runat="server" style="z-index: 1; left: 340px; top: 98px; position: absolute" Text="Search" width="60px" OnClick="btnSearchOrderById_Click" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 430px; top: 93px; position: absolute" ForeColor="Red"></asp:Label>

        <div class="container">
            <h3 style="z-index: 1; left: 10px; top: 124px; position: absolute">Orders</h3>
            <asp:ListBox ID="lstOrders" runat="server" CssClass="listbox" style="z-index: 1; left: 10px; top: 184px; position: absolute; height: 300px; width: 850px"></asp:ListBox>
        </div>

        <div class="container">
            <h3 style="z-index: 1; left: 900px; top: 124px; position: absolute">Order lines</h3>
            <asp:ListBox ID="LstOrderLines" runat="server" CssClass="listbox" style="z-index: 1; left: 900px; top: 184px; position: absolute; height: 300px; width: 850px"></asp:ListBox>
        </div>

        <asp:Button ID="btnSearchForOrderLines" runat="server" style="z-index: 1; left: 340px; top: 98px; position: absolute" Text="Search" width="60px" OnClick="btnSearchForOrderLines_Click" />

    </form>
</body>
</html>
