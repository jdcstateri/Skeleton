<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row">
                <div class="col-md-6 offset-md-3">
                    <h3 class="text-center mb-4">Staff List</h3>

                    <!-- Action Buttons For Logout and Cancel-->
                    <div class="d-flex justify-content-end mb-3">
                        <asp:Button ID="BtnLogout" runat="server" OnClick="ButtonLogout_Click" Text="Logout" CssClass="btn btn-secondary" />
                    </div>

                    <!-- Staff List Box-->
                    <div class="mb-3">
                        <asp:ListBox ID="lstStaffList" runat="server" CssClass="form-select" Rows="10" Style="height: 320px;"></asp:ListBox>
                    </div>

                    <!-- Action Buttons For CRUD-->
                    <div class="d-flex justify-content-between mb-3">
                        <asp:Button ID="BtnAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add" CssClass="btn btn-success" />
                        <asp:Button ID="BtnEdit" runat="server" OnClick="ButtonEdit_Click1" Text="Edit" CssClass="btn btn-primary" />
                        <asp:Button ID="BtnDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" CssClass="btn btn-danger" />
                    </div>

                    <!-- Filter TextBox Field-->
                    <div class="mb-3">
                        <label for="txtFilter" class="form-label">Filter by Name</label>
                        <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control" />
                    </div>

                    <!-- Filter Action Buttons -->
                    <div class="d-flex justify-content-between mb-3">
                        <asp:Button ID="BtnFilter" runat="server" OnClick="ButtonFilter_Click" Text="Apply Filter" CssClass="btn btn-outline-primary" />
                        <asp:Button ID="BtnClear" runat="server" OnClick="ButtonClear_Click" Text="Clear Filter" CssClass="btn btn-outline-secondary" />
                    </div>

                    <!-- Error Message -->
                    <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>

                </div>
            </div>
        </div>
    </form>

    <!-- Bootstrap JS Bundle -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
