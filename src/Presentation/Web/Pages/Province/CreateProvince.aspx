<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProvince.aspx.cs" Inherits="Web.Pages.Province.CreateProvince" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmCreateForm" runat="server">
        <div>
            <asp:TextBox ID="name" runat="server" OnTextChanged="name_TextChanged"></asp:TextBox>
            <asp:Label ID="lblName" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="btnCreateProvince" runat="server" OnClick="btnCreateProvince_Click"  Text="CreateProvince" />
            <br />
            <asp:Button ID="clearFrom" runat="server" OnClick="clearFrom_Click" Text="ClearForm" />
            <br />

            <br /><br /><br />
            <asp:Label ID="lblResult" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
