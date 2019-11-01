<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VeiculoFrm.aspx.cs" Inherits="oficina3c14.UI.VeiculoFrm" %>

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
            <asp:TextBox ID="txtplaca" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Label ID="Label5" runat="server" Text="Ano"></asp:Label>
        </p>
        <p class="auto-style1">
            <asp:TextBox ID="txtano" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Label ID="Cor" runat="server" Text="Cor"></asp:Label>
        </p>
        <p class="auto-style1">
            <asp:TextBox ID="txtCor" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Label ID="lblDono" runat="server" Text="Dono"></asp:Label>
        </p>
        <p class="auto-style1">
            <asp:DropDownList ID="ddlDono" runat="server">
            </asp:DropDownList>
        </p>
        <p class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Modelo"></asp:Label>
        </p>
        <asp:DropDownList ID="DdlModelo" runat="server" style="text-align: center">
        </asp:DropDownList>
        <p>
            
            <asp:Button ID="btnSubmit" runat="server" Text="Enviar" Width="205px" OnClick="btnSubmit_Click" class="btn btn-outline-success mt-4"/>

            <center>
                <asp:GridView ID="dtgVeiculos" runat="server" Width="791px" OnRowEditing="dtgVeiculos_RowEditing"
                                                                            OnRowUpdating="dtgVeiculos_RowUpdating"
                                                                            OnRowDeleting="dtgVeiculos_RowDeleting"
                                                                            OnRowCancelingEdit="dtgVeiculos_RowCancelingEdit" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3"
            >
                    <Columns>
                        <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="Selecionar">
                            <EditItemTemplate>
                                <asp:DynamicControl ID="DynamicControl1" runat="server" DataField="" Mode="Edit" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <a href="VisualizarVeiculo.aspx?id=<%# Eval("id") %>">
                                    Detalhes
                                </a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </center>
        </p>
    </form>
</body>
</html>
