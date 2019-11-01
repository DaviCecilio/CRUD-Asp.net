<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarVeiculo.aspx.cs" Inherits="oficina3c14.UI.VisualizarVeiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" ></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" ></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" ></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            <asp:Label ID="Label4" runat="server" Text="Placa"></asp:Label>
        </p>
        <p class="auto-style1">
            <asp:TextBox ID="txtplaca" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Label ID="Label5" runat="server" Text="Ano"></asp:Label>
        </p>
        <p class="auto-style1">
            <asp:TextBox ID="txtano" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Label ID="Cor" runat="server" Text="Cor"></asp:Label>
        </p>
        <p class="auto-style1">
            <asp:TextBox ID="txtCor" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Label ID="lblDono" runat="server" Text="Dono"></asp:Label>
        </p>
        <p class="auto-style1">
            <asp:DropDownList ID="ddlDono" runat="server" Enabled="False">
            </asp:DropDownList>
        </p>
        <p class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Modelo"></asp:Label>
        </p>
        <asp:DropDownList ID="DdlModelo" runat="server" style="text-align: center" Enabled="False">
        </asp:DropDownList>

    </form>
</body>
</html>
