<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 24px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Are you sure you want to delete this record?</p>
       
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Style="position: absolute; left: 47px; top: 97px; height: 30px; width: 60px; right: 1499px;" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Style="position: absolute; left: 166px; top: 96px; height: 30px; width: 60px;" Text="No" />
    </form>
</body>
</html>
