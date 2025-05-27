<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMenu" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 475px; text-align: center;" Text="Team Main Menu"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 10px; top: 65px; position: absolute" Text="Customer" height="26px" OnClick="btnCustomer_Click" width="94px" />
        <asp:Button ID="btnAddresses" runat="server" style="z-index: 1; left: 10px; top: 109px; position: absolute" Text="Addresses" height="26px" OnClick="btnAddresses_Click" width="94px" />

        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 140px; top: 65px; position: absolute" Text="Staff" height="26px" OnClick="btnStaff_Click" width="94px" />
        <asp:Button ID="btnActivityLog" runat="server" style="z-index: 1; left: 140px; top: 109px; position: absolute" Text="Activity Log" height="26px" OnClick="btnActivityLog_Click" width="94px" />

        <asp:Button ID="btnOrder" runat="server" style="z-index: 1; left: 268px; top: 65px; position: absolute" Text="Order" height="26px" OnClick="btnOrder_Click" width="94px" />

        <asp:Button ID="btnProduct" runat="server" style="z-index: 1; left: 395px; top: 65px; position: absolute" Text="Product" height="26px" OnClick="btnProduct_Click" width="94px" />
    </form>
</body>
</html>
