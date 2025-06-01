<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:ListBox ID="lstProductList" runat="server" Height="297px" Width="319px"></asp:ListBox>
            
        </div>

      <p style="margin-top: 20px;">
   
    <asp:Button ID="btnAdd_Click" runat="server" OnClick="btnAdd_Click_Click" Text="Add" style="margin-right: 20px;" Width="90" />
    <asp:Button ID="btn_Edit" runat="server" Text="Edit" style="margin-right: 20px;" Width="90" OnClick="btn_Edit_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" Width="90"/>
    <asp:Label ID="lblError" runat="server" Text="lblError" style="margin-left: 40px;" />
    </p>
        <p style="margin-top: 20px;">
   
            Enter a Product Title<asp:TextBox ID="txtFilter" runat="server" style="margin-left: 30px" Width="230px"></asp:TextBox>
        </p>

        <p>

        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" style="margin-right: 50px" Width="90"/>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" style="margin-right: 50px" Width="90"/>

        </p>

    </form>
</body>
</html>
