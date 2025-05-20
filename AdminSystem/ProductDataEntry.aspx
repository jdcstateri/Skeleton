﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 398px">
    <form id="form1" runat="server">
   &nbsp;<div>
            <asp:TextBox ID="txtItemID" runat="server" style="z-index: 1; left: 102px; top: 24px; position: absolute; " BorderStyle="Solid" width="128"></asp:TextBox>
           <asp:Button ID="btnFind" runat="server" Text="Find" Style="position:relative; left:445px; top: -14px; height: 26px; width: 39px;" OnClick="btnFind_Click" />


        </div>

        <div>
            <asp:Label ID="lblItemId" runat="server" style="z-index: 1; left: 13px; top: 33px; position: absolute" Text="Item ID"></asp:Label>
        </div>

        <div style="margin-top: 2px">
            <asp:TextBox ID="txtProductTitle" runat="server" style="z-index: 1; left: 102px; top: 53px; position: absolute; width: 128px" BorderStyle="Solid"></asp:TextBox>
            <asp:Label ID="lblProductDescription" runat="server" style="z-index: 1; left: 9px; top: 74px; position: absolute; height: 16px; width: 129px" Text="Product Description"></asp:Label>
        </div>

        <div style="height: 84px; width: 1561px; margin-top: 0px;" dir="auto">
            <asp:Label ID="lblProductTitle" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; bottom: 598px" Text="Product Title"></asp:Label>
            <asp:TextBox ID="txtProductDescription" runat="server" style="z-index: 1; left: 7px; top: 99px; position: absolute; height: 89px; width: 340px" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 102px; top: 200px; position: absolute; margin-top: 0px" BorderStyle="Solid"></asp:TextBox>
        </div>

        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 14px; top: 199px; position: absolute" Text="Price"></asp:Label>
        <div>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 249px; position: absolute" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"
    Style="z-index: 1; left: 102px; top: 250px; position: absolute; width: 180px;"
    BorderStyle="Solid" TextMode="DateTime" />

        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click"
    Style="position: absolute; left: 403px; top: 273px; height: 30px; width: 60px;"
    Text="OK" />

        </div>

        <div>
        <asp:CheckBox ID="chkIsPublished" runat="server" style="z-index: 1; left: 295px; top: 274px; position: absolute" Text="IsPublished" />
        <asp:Button ID="btnCancel" runat="server" style= "left: 827px; top: 272px; position: absolute; " Text="Cancel" width="60" />
        </div>

        <asp:Label ID="lblStockNumber" runat="server" style="z-index: 1; left: 8px; top: 228px; position: absolute" Text="Stock Number"></asp:Label>
        <asp:TextBox ID="txtStockNumber" runat="server" style="z-index: 1; left: 102px; top: 226px; position: absolute" BorderStyle="Solid"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 329px; position: absolute"></asp:Label>
    </form>

</body>
</html>