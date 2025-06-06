<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <div class="card shadow text-center">
                        <div class="card-body">
                            <h5 class="card-title text-danger mb-4">Delete Confirmation</h5>
                            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?" CssClass="d-block mb-4 fw-bold"></asp:Label>
                            
                            <div class="d-flex justify-content-center gap-3">
                                <asp:Button ID="Button1" runat="server" Text="Yes" CssClass="btn btn-danger" OnClick="BtnYes_Click" />
                                <asp:Button ID="Button2" runat="server" Text="No" CssClass="btn btn-secondary" OnClick="BtnNo_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- Bootstrap JS Bundle -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
