<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the Order Data Entry Page
    <form id="form1" runat="server">
        <asp:Label ID="lblAccountId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Account ID"></asp:Label>
        <asp:TextBox ID="txtAccountId" runat="server" style="z-index: 1; left: 250px; top: 34px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDeliveryInstructions" runat="server" style="z-index: 1; left: 10px; top: 64px; position: absolute" Text="Delivery Instructions"></asp:Label>
        <asp:TextBox ID="txtDeliveryInstructions" runat="server" style="z-index: 1; left: 250px; top: 64px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 10px; top: 94px; position: absolute" Text="Submit" OnClick="btnOk_Click" width="60px" />

        <div class="container">
            <h3 style="z-index: 1; left: 10px; top: 124px; position: absolute">Shopping Cart</h3>
            <asp:Label ID="lblGrandTotal" runat="server" Text="Grand Total: £0" style="z-index: 1; left: 10px; top: 174px; position: absolute"></asp:Label>

            <asp:ListBox ID="lstShoppingCart" runat="server" CssClass="listbox" style="z-index: 1; left: 10px; top: 204px; position: absolute"></asp:ListBox>
        </div>
    </form>
</body>
</html>
