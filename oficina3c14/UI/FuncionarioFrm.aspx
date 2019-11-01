<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FuncionarioFrm.aspx.cs" Inherits="oficina3c14.UI.FuncionarioFrm" %>

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
        <center>
        <div class="mt-4">
                
        
            <asp:Label ID="lblnome" runat="server" Text="Nome: "></asp:Label>
                
        
            <asp:TextBox ID="txtnome" runat="server" Width="203px"></asp:TextBox>

        </div>
        <p>
            <asp:Label ID="lblDataNasc" runat="server" Text="Data de Nascimento: " ></asp:Label>
            <asp:Calendar ID="caledarNasc" runat="server" ForeColor="#9966FF" NextPrevFormat="ShortMonth"></asp:Calendar>
            </p>
        <p>
            <asp:Label ID="lbltelefone" runat="server" Text="Telefone:"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server" Width="203px" Height="23px"></asp:TextBox>

        </p>
        <asp:Label ID="lblCpf" runat="server" Text="CPF: "></asp:Label>
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        <p style="text-align: center">
            <asp:Button ID="btnSubmit" runat="server" Text="Gravar" Width="247px" OnClick="btnSubmit_Click1" class="btn btn-outline-success mt-4"/>
        <asp:GridView ID="DgvFuncionario" runat="server"    OnRowEditing="DgvFuncionario_RowEditing"
                                                            OnRowUpdating="DgvFuncionario_RowUpdating"
                                                            OnRowDeleting="DgvFuncionario_RowDeleting"
                                                            OnRowCancelingEdit="DgvFuncionario_RowCancelingEdit" OnSelectedIndexChanged="DgvFuncionario_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        </p>
        </center>
    </form>
        
</body>
</html>
