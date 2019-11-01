using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace oficina3c14.UI
{
    public partial class VisualizarVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarDonos_e_Modelos();

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    DataTable dt = new VeiculoBLL().ListarTodosVeiculos(id);

                    if(dt.Rows.Count > 0)
                    {
                        txtplaca.Text = dt.Rows[0][1].ToString();
                        txtano.Text = Convert.ToInt32(dt.Rows[0][2]).ToString();
                        txtCor.Text = dt.Rows[0][3].ToString();
                        ddlDono.SelectedValue = Convert.ToInt32(dt.Rows[0][4]).ToString();
                        DdlModelo.SelectedValue = Convert.ToInt32(dt.Rows[0][5]).ToString();
                    }
                    else
                    {
                        Response.Redirect("VeiculoFrm.aspx");
                    }
                }
            }
            else
            {
                Response.Redirect("VeiculoFrm.aspx");
            }
        }

        private void ListarDonos_e_Modelos()
        {
            ddlDono.DataSource = new ClienteBLL().ListarClientes();
            ddlDono.DataValueField = "id";
            ddlDono.DataTextField = "nome";

            DdlModelo.DataSource = new ModeloBLL().ListarModelos();
            DdlModelo.DataValueField = "id";
            DdlModelo.DataTextField = "nome";

            DataBind();
        }
    }
}