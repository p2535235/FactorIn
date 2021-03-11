<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" width="180px"></asp:Label>
                <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            </div>
            <div>
                <asp:Label ID="lblStaffName" runat="server" Text="Staff Name" width="180px"></asp:Label>
                <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblDateAccessed" runat="server" Text="Date Accessed" width="180px"></asp:Label>
                <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblTotalCost" runat="server" Text="Total Cost" width="180px"></asp:Label>
                <asp:TextBox ID="txtWage" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblProductID" runat="server" Text="Product ID" width="180px"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:CheckBox ID="chkGrantAccess" runat="server" Text="Grant Access" />
            </div>
        </div>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
