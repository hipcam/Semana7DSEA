<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCategoria.aspx.cs" Inherits="PruebaDll.FrmCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 518px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">CATEGORÍA </td>
                    <td>
                        <asp:DropDownList ID="DdCategoria" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="DdCategoria_SelectedIndexChanged" Width="129px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GvProductos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GvProductos_SelectedIndexChanged" Width="100%">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
