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
                <asp:Label ID="lblStaffID" runat="server" BorderWidth="0px" Text="Staff ID" width="92px"></asp:Label>
                <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblStaffName" runat="server" BorderWidth="0px" Text="Staff Name" width="92px"></asp:Label>
                <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblDateAccessed" runat="server" BorderWidth="0px" Text="Date Accessed"></asp:Label>
                <asp:TextBox ID="txtDateAccessed" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblTotalCost" runat="server" BorderWidth="0px" Text="Total Cost" width="92px"></asp:Label>
                <asp:TextBox ID="txtTotalCost" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblProductID" runat="server" BorderWidth="0px" Text="Product ID" width="92px"></asp:Label>
                <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:CheckBox ID="chkGrantAccess" runat="server" Text="Grant Access" />
            </div>
            <div>
                <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
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
