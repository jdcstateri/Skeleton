<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 398px">
    &nbsp;<form id="form1" runat="server">
        <div>
            <asp:Label ID="lblItemId" runat="server" style="z-index: 1; left: 13px; top: 33px; position: absolute" Text="Item ID"></asp:Label>
            <asp:TextBox ID="txtItemId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 100px; top: 29px; position: absolute"></asp:TextBox>
        </div>
        <p style="margin-top: 2px">
            <asp:TextBox ID="txtProductTitle" runat="server" style="z-index: 1; left: 101px; top: 53px; position: absolute; width: 119px"></asp:TextBox>
            <asp:Label ID="lblProductDescription" runat="server" style="z-index: 1; left: 9px; top: 74px; position: absolute; height: 16px; width: 129px" Text="Product Description"></asp:Label>
        </p>
        <p style="height: 84px; width: 1561px; margin-top: 0px;" dir="auto">
            <asp:Label ID="lblProductTitle" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; bottom: 598px" Text="Product Title"></asp:Label>
            <asp:TextBox ID="txtProductDescription" runat="server" style="z-index: 1; left: 8px; top: 95px; position: absolute; height: 97px; width: 340px"></asp:TextBox>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 103px; top: 199px; position: absolute; margin-top: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 11px; top: 209px; position: absolute" Text="Price"></asp:Label>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 249px; position: absolute" Text="Date Added"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 102px; top: 250px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblIsPublished" runat="server" style="z-index: 1; left: 11px; top: 281px; position: absolute" Text="IsPublished"></asp:Label>
        <asp:TextBox ID="txtIsPublished" runat="server" style="z-index: 1; left: 101px; top: 278px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblStockNumber" runat="server" style="z-index: 1; left: 10px; top: 229px; position: absolute" Text="Stock Number"></asp:Label>
        <asp:TextBox ID="txtStock" runat="server" style="z-index: 1; left: 101px; top: 226px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="ChkActive" runat="server" style="z-index: 1; left: 100px; top: 309px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 329px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 288px; top: 330px; position: absolute; right: 1266px; height: 24px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 348px; top: 329px; position: absolute; right: 1179px" Text="Cancel" />
    </form>

</body>
</html>
