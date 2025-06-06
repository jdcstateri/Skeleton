<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <!-- Find Orders by Account ID search -->

        <h3 style="z-index: 1; left: 10px; top: 41px; position: absolute">Order Viewer</h3>

        <asp:Label ID="lblAccountId" runat="server" style="z-index: 1; left: 10px; top: 98px; position: absolute" Text="Account ID to search:" width="143px"></asp:Label>
        <asp:TextBox ID="txtAccountId" runat="server" style="z-index: 1; left: 164px; top: 98px; position: absolute" width="156px"></asp:TextBox>

        <asp:Button ID="btnSearchByAccountId" runat="server" style="z-index: 1; left: 340px; top: 98px; position: absolute" Text="Search" width="60px" OnClick="btnSearchOrderById_Click" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 430px; top: 9px; position: absolute" ForeColor="Red"></asp:Label>

        <!-- Order Display and Editing -->

        <div class="container">
            <h3 style="z-index: 1; left: 10px; top: 124px; position: absolute">Orders</h3>
            <asp:ListBox ID="lstOrders" runat="server" CssClass="listbox" style="z-index: 1; left: 10px; top: 184px; position: absolute; height: 300px; width: 850px"></asp:ListBox>
        </div>
        
        <asp:Button ID="btnUpdateOrder" runat="server" style="z-index: 1; left: 550px; top: 540px; position: absolute" Text="Edit Order" width="100px" OnClick="btnUpdateOrder_Click" />        
        <asp:Button ID="btnDeleteOrder" runat="server" style="z-index: 1; left: 550px; top: 570px; position: absolute" Text="Delete Order" width="100px" OnClick="btnDeleteOrder_Click" />
    
        <asp:Label ID="lblDateOfDelivery" runat="server" style="z-index: 1; left: 10px; top: 540px; position: absolute" Text="Date Of Delivery:" width="143px"></asp:Label>
        <asp:TextBox ID="txtDateOfDelivery" runat="server" TextMode="Date" style="z-index: 1; left: 164px; top: 540px; position: absolute" width="156px"></asp:TextBox>

        <asp:RadioButtonList ID="rblDelivered" runat="server" style="z-index: 1; left: 10px; top: 570px; position: absolute">
            <asp:ListItem Text="Delivered" Value="true"></asp:ListItem>
            <asp:ListItem Text="Not Delivered" Value="false"></asp:ListItem>
        </asp:RadioButtonList>


        <asp:Label ID="lblDeliveryInstructions" runat="server" style="z-index: 1; left: 10px; top: 630px; position: absolute" Text="Delivery Instructions:" width="143px"></asp:Label>
        <asp:TextBox ID="txtDeliveryInstructions" runat="server" TextMode="MultiLine" style="z-index: 1; left: 164px; top: 630px; position: absolute; width: 300px; height: 100px"></asp:TextBox>
   
        
        <!-- Order lines Display and Editing -->
        
        <asp:Button ID="btnSearchForOrderLines" runat="server" style="z-index: 1; left: 900px; top: 98px; position: absolute" Text="Search for order lines" width="150px" OnClick="btnSearchForOrderLines_Click" />
     
        <div class="container">
            <h3 style="z-index: 1; left: 900px; top: 124px; position: absolute">Order lines</h3>
            <asp:ListBox ID="lstOrderLines" runat="server" CssClass="listbox" style="z-index: 1; left: 900px; top: 184px; position: absolute; height: 300px; width: 850px"></asp:ListBox>
        </div>

        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 900px; top: 540px; position: absolute" Text="Status:" width="143px"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server" style="z-index: 1; left: 1010px; top: 540px; position: absolute" width="156px"></asp:TextBox>

        <asp:Label ID="lblAgreedPrice" runat="server" style="z-index: 1; left: 900px; top: 570px; position: absolute" Text="Agreed Price £:" width="143px"></asp:Label>
        <asp:TextBox ID="txtAgreedPrice" runat="server" style="z-index: 1; left: 1010px; top: 570px; position: absolute" width="156px"></asp:TextBox>

        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 900px; top: 600px; position: absolute" Text="Quantity:" width="143px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 1010px; top: 600px; position: absolute" width="156px"></asp:TextBox>

        <asp:Button ID="btnUpdateOrderline" runat="server" style="z-index: 1; left: 1230px; top: 540px; position: absolute" Text="Edit Orderline" width="130px" OnClick="btnUpdateOrderline_Click" />        
        <asp:Button ID="btnDeleteOrderline" runat="server" style="z-index: 1; left: 1230px; top: 570px; position: absolute" Text="Delete Orderline" width="130px" OnClick="btnDeleteOrderline_Click" />
 
    </form>
</body>
</html>
