<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 216px; width: 1612px">
    <form id="form1" runat="server">
        <div>
            <div>
            </div>
            <div>
                <asp:Button ID="Button2" runat="server" Style="z-index: 1; left: 38px; top: 85px; position: absolute; width: 61px;" Text="No" OnClick="BtnNo_Click" />
                  <asp:Button ID="Button1" runat="server" Style="z-index: 1; left: 148px; top: 86px; position: absolute; width: 61px;" Text="Yes" OnClick="BtnYes_Click" />
            </div>
                <asp:Label ID="Label1" runat="server" Text="Are you sure you want a delete this reccord? "></asp:Label>
        </div>
                
    </form>
</body>
</html>
