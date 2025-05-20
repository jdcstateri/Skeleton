<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDeleteQuestion" runat="server" Text="Are you sure you want to delete this record?" style="z-index: 1; left: 12px; top: 36px; position: absolute"></asp:Label>
            <asp:Button ID="btnYes" runat="server" Text="Yes" style="z-index: 1; left: 33px; top: 70px; position: absolute; width: 79px;" OnClick="btnYes_Click"/>
            <asp:Button ID="btnNo" runat="server" Text="No" style="z-index: 1; left: 147px; top: 70px; position: absolute; width: 79px;" OnClick="btnNo_Click"/>
        </div>
    </form>
</body>
</html>
