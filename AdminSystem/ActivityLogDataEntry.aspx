<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActivityLogDataEntry.aspx.cs" Inherits="ActivityLogDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Activity Log Details (Immutable)</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <div class="card shadow p-4">
                        <h3 class="card-title text-center mb-4">Activity Log Details</h3>

                        <div class="mb-3">
                            <label for="txtActivityId" class="form-label">Activity ID</label>
                            <asp:TextBox ID="txtActivityId" runat="server" CssClass="form-control" ReadOnly="true" />
                        </div>

                        <div class="mb-3">
                            <label for="txtUserId" class="form-label">User ID</label>
                            <asp:TextBox ID="txtUserId" runat="server" CssClass="form-control" ReadOnly="true" />
                        </div>

                        <div class="mb-3">
                            <label for="txtAction" class="form-label">Action</label>
                            <asp:TextBox ID="txtAction" runat="server" CssClass="form-control" ReadOnly="true" />
                        </div>

                        <div class="mb-3">
                            <label for="txtDetail" class="form-label">Detail</label>
                            <asp:TextBox ID="txtDetail" runat="server" CssClass="form-control" ReadOnly="true" TextMode="MultiLine" Rows="3" />
                        </div>

                        <div class="mb-3">
                            <label for="txtTimeStamp" class="form-label">Timestamp</label>
                            <asp:TextBox ID="txtTimeStamp" runat="server" CssClass="form-control" ReadOnly="true" />
                        </div>

                        <div class="text-danger mb-3">
                            <asp:Label ID="lblError" runat="server" />
                        </div>

                        <div class="text-center">
                            <asp:Button ID="btnBack" runat="server" Text="Back to List" CssClass="btn btn-secondary" OnClick="btnBack_Click" />
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
