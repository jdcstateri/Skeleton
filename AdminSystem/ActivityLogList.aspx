<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActivityLogList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Activity Log List</title>
    <!-- Bootstrap CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
    <style>
        .listbox {
            height: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h2 class="mb-4">Activity Log List</h2>
            <div class="d-flex gap-2 justify-content-end mb-3">
                <asp:Button ID="BtnLogOut" runat="server" Text="Logout" CssClass="btn btn-secondary" OnClick="BtnLogout_Click" />
            </div>

            <asp:ListBox ID="lstActivityLogList" runat="server" CssClass="form-control listbox mb-3" />

            <div class="d-flex gap-2">
                <asp:Button ID="BtnView" runat="server" Text="View" CssClass="btn btn-primary" OnClick="BtnView_Click" />
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="text-danger mt-3 d-block" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
