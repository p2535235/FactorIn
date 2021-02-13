<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="StockDataEntry" %>

<!DOCTYPE html>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductID" runat="server" Text="Product ID" Width="180px"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" Width="180px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblLocation" runat="server" Text="Location of the Stock" width="180px"></asp:Label>
        <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price per Stock" Width="180px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateUpdate" runat="server" Text="Date of today" Width="180px"></asp:Label>
            <asp:TextBox ID="txtDateUpdated" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Available " />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
