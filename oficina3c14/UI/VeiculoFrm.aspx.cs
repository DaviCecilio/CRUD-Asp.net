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
    public partial class VeiculoFrm : System.Web.UI.Page
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
            dtgVeiculos.DataSource = new VeiculoBLL().ListarTodosVeiculos();

            ddlDono.DataSource = new ClienteBLL().ListarClientes();
            ddlDono.DataTextField = "nome";
            ddlDono.DataValueField = "id";

            DdlModelo.DataSource = new ModeloBLL().ListarModelos();
            DdlModelo.DataTextField = "nome";
            DdlModelo.DataValueField = "id";

            DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtplaca.Text == string.Empty || txtCor.Text == string.Empty || txtCor.Text  == string.Empty)
            {
                Response.Write("<script> alert('Favor preencher corretamente os dados!')</script>");
            }
            else
            {
                VeiculoDTO veiculoDTO = new VeiculoDTO();

                veiculoDTO.Placa = txtplaca.Text;
                veiculoDTO.Ano = txtano.Text;
                veiculoDTO.Cor = txtCor.Text;
                veiculoDTO.Id_dono = Convert.ToInt32(ddlDono.SelectedValue);
                veiculoDTO.Id_modelo = Convert.ToInt32(DdlModelo.SelectedValue);

                new VeiculoBLL().InserirVeiculo(veiculoDTO);

                new LimpaForm(this.Form.Controls);

                ExibirDados();

                Response.Write("<script> alert('Dados gravados corretamente.')</script>");


            }

        }

        protected void dtgVeiculos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dtgVeiculos.EditIndex = e.NewEditIndex;
            ExibirDados();
        }

        protected void dtgVeiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            VeiculoDTO dto = new VeiculoDTO();

            dto.Id = Convert.ToInt32(e.NewValues[0]);
            dto.Placa = e.NewValues[1].ToString();
            dto.Ano = e.NewValues[2].ToString();
            dto.Cor = e.NewValues[3].ToString();

            new VeiculoBLL().AlterarVeiculo(dto);
            dtgVeiculos.EditIndex = -1;
            ExibirDados();
        }

        protected void dtgVeiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            VeiculoDTO dto = new VeiculoDTO();

            dto.Id = Convert.ToInt32(e.Values[0]);

            new VeiculoBLL().ExcluirVeiculo(dto);
            dtgVeiculos.EditIndex = -1;
            ExibirDados();
        }

        protected void dtgVeiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dtgVeiculos.EditIndex = -1;
            ExibirDados();
        }
    }
}