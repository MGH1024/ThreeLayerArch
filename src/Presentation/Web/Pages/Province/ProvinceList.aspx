<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProvinceList.aspx.cs" Inherits="Web.Pages.Province.ProvinceList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div id="panel" style="height: 500px; background-color: red; padding: 10px; overflow: auto">
                <h1>
                    Provinces  
                </h1>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePaneleProvince" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:GridView ID="ProvinceGrid" runat="server" AutoGenerateColumns="false"
                            ShowFooter="true">
                            <Columns>
                                <asp:TemplateField ItemStyle-Width="30px" HeaderText="Id">
                                    <ItemTemplate>
                                        <asp:Label ID="lblId" runat="server"
                                            Text='<%#Eval("Id")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="600px" HeaderText="Name">
                                    <ItemTemplate>
                                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtProvince" runat="server" Text='<%#Eval("Name")%>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtService" runat="server"></asp:TextBox>
                                    </FooterTemplate>
                                </asp:TemplateField>
                                <asp:CommandField ShowEditButton="True" />
                            </Columns>
                        </asp:GridView>
                    </ContentTemplate>
                    <Triggers>
                    </Triggers>
                </asp:UpdatePanel>
            </div>
    </form>
</body>
</html>
