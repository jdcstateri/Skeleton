<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <h3 class="text-center mb-4">Staff Data Entry</h3>
                    <div class="card shadow p-4">
                        <div class="mb-3 row">
                            <label for="txtStaffID" class="col-sm-3 col-form-label">Staff ID</label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtStaffID" runat="server" CssClass="form-control" />
                            </div>
                            <div class="col-sm-3">
                                <asp:Button ID="Button3" runat="server" Text="Find" CssClass="btn btn-secondary w-100" OnClick="Button3_Click" />
                            </div>
                        </div>

                        <div class="mb-3 row">
                            <label for="txtName" class="col-sm-3 col-form-label">Name</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                            </div>
                        </div>

                        <div class="mb-3 row">
                            <label for="txtEmail" class="col-sm-3 col-form-label">Email</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
                            </div>
                        </div>

                        <div class="mb-3 row">
                            <label for="txtPassword" class="col-sm-3 col-form-label">Password</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" />
                            </div>
                        </div>

                        <div class="mb-3 row">
                            <label for="ChkAdmin" class="col-sm-3 col-form-label">Admin</label>
                            <div class="col-sm-9">
                                <asp:CheckBox ID="ChkAdmin" runat="server" CssClass="form-check-input me-2" />
                                <label class="form-check-label" for="ChkAdmin">Is Admin</label>
                            </div>
                        </div>

                        <div class="mb-3 row">
                            <label for="txtDateAdded" class="col-sm-3 col-form-label">Date Added</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtDateAdded" runat="server" CssClass="form-control" TextMode="Date" />
                            </div>
                        </div>


                        <div>


                            <div class="mb-3 row">
                                <label for="txtLastLogin" class="col-sm-3 col-form-label">Last Login</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="txtLastLogin" runat="server" CssClass="form-control" TextMode="DateTimeLocal" />
                                </div>
                            </div>

                            <div class="text-center mt-4">
                                <asp:Button ID="Button1" runat="server" Text="OK" CssClass="btn btn-primary me-2" OnClick="btnOK_Click" />
                                <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="BtnCancel_Click" />
                            </div>

                            <div class="mt-3 text-danger text-center">
                                <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
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
