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
    public partial class FuncionarioFrm : System.Web.UI.Page
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
            DgvFuncionario.DataSource = new FuncionarioBLL().ListarTodosFuncionarios();
            DataBind();
        }

        protected void DgvFuncionario_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DgvFuncionario.EditIndex = e.NewEditIndex;
            ExibirDados();
        }

        protected void DgvFuncionario_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            FuncionarioDTO dto = new FuncionarioDTO();

            dto.Id = Convert.ToInt32(e.NewValues[0]);
            dto.Nome = e.NewValues[1].ToString();
            dto.Data_nascimento = Convert.ToDateTime(e.NewValues[2]);
            dto.Telefone = Convert.ToInt32(e.NewValues[3]);
            dto.Cpf = Convert.ToInt32(e.NewValues[4].ToString());

            new FuncionarioBLL().AlterarFuncionario(dto);
            DgvFuncionario.EditIndex = -1;
            ExibirDados();
        }

        protected void DgvFuncionario_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            FuncionarioDTO dto = new FuncionarioDTO();

            dto.Id = Convert.ToInt32(e.Values[0]);

            new FuncionarioBLL().ExcluirFuncionario(dto);
            DgvFuncionario.EditIndex = -1;
            ExibirDados();

        }

        protected void DgvFuncionario_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            DgvFuncionario.EditIndex = -1;
            ExibirDados();
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {

            if (txtnome.Text == string.Empty || txtTelefone.Text == string.Empty || txtCpf.Text == string.Empty)
            {
                Response.Write("<script> alert('Favor preencher corretamente os dados!')</script>");
            }
            else
            {
                FuncionarioDTO funcionarioDTO = new FuncionarioDTO();


                funcionarioDTO.Nome = txtnome.Text;
                funcionarioDTO.Data_nascimento = caledarNasc.SelectedDate;
                funcionarioDTO.Telefone = Convert.ToInt32(txtTelefone.Text);
                funcionarioDTO.Cpf = Convert.ToInt32(txtCpf.Text);


                new FuncionarioBLL().InserirFuncionario(funcionarioDTO);

                ExibirDados();
                new LimpaForm(this.Form.Controls);

                Response.Write("<script> alert('Dados gravados corretamente.')</script>");

            }            
       

        }

        protected void DgvFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}