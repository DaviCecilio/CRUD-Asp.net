using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace oficina3c14.UI
{
    public partial class ProdutoFrm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ExibirDados();
            }
        }

        public void ExibirDados()
        {
            DgvProduto.DataSource = new ProdutoBLL().ListarTodosProdutos();
            DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == string.Empty || txtpreco.Text == string.Empty || txtqtde_estoque.Text == string.Empty)
            {
                Response.Write("<script> alert('Favor preencher corretamente os dados!')</script>");
            }
            else{
                ProdutoDTO produtoDTO = new ProdutoDTO();

                produtoDTO.Nome = txtnome.Text;
                produtoDTO.Preco = Convert.ToInt32(txtpreco.Text);
                produtoDTO.Qtde_estoque = Convert.ToInt32(txtqtde_estoque.Text);


                new ProdutoBLL().InserirProduto(produtoDTO);

                new LimpaForm(this.Form.Controls);

                ExibirDados();

                Response.Write("<script> alert('Dados gravados corretamente.')</script>");
            }           


        }

        protected void DgvProduto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DgvProduto.EditIndex = e.NewEditIndex;
            ExibirDados();
        }

        protected void DgvProduto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();

            dto.Id = Convert.ToInt32(e.NewValues[0]);
            dto.Nome = e.NewValues[1].ToString();
            dto.Preco = Convert.ToInt32(e.NewValues[2]);
            dto.Qtde_estoque = Convert.ToInt32(e.NewValues[3]);

            new ProdutoBLL().AlterarProduto(dto);
            DgvProduto.EditIndex = -1;
            ExibirDados();
        }

        protected void DgvProduto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();

            dto.Id = Convert.ToInt32(e.Values[0]);

            new ProdutoBLL().ExcluirProduto(dto);
            DgvProduto.EditIndex = -1;
            ExibirDados();
        }

        protected void DgvProduto_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            DgvProduto.EditIndex = -1;
            ExibirDados();
        }
    }
}