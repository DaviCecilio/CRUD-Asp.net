<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProdutoFrm.aspx.cs" Inherits="oficina3c14.UI.ProdutoFrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" ></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" ></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" ></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Oficina</title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        

                
        
            <asp:Label ID="lblnome" runat="server" Text="Nome: "></asp:Label>
                
        
        </div>
        <p>
                
        
            <asp:TextBox ID="txtnome" runat="server" Width="207px"></asp:TextBox>

            </p>
        <p>
            <asp:Label ID="lblpreco" runat="server" Text="Preço: "></asp:Label>

        </p>
            <asp:TextBox ID="txtpreco" runat="server" Width="204px"></asp:TextBox>    
            <p>
            <asp:Label ID="lblqtde_estoque" runat="server" Text="Qtde. em Estoque:"></asp:Label>
            </p>
            <asp:TextBox ID="txtqtde_estoque" runat="server" Width="203px"></asp:TextBox>

        <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Enviar" Width="242px" OnClick="btnSubmit_Click" class="btn btn-outline-success mt-4" />
        </p>
            <center>
                <asp:GridView ID="DgvProduto" runat="server" Width="826px" onRowEditing="DgvProduto_RowEditing"
                                                                           onRowUpdating="DgvProduto_RowUpdating"
                                                                           onRowDeleting="DgvProduto_RowDeleting"
                                                                           onRowCancelingEdit="DgvProduto_RowCancelingEdit"     
                    >
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </center>
    </form>
</body>
</html>
