using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class VeiculoBLL
    {
        DALOficina dao;

        public VeiculoBLL()
        {
            dao = new DALOficina("localhost", "oficina", "root", "");
        }

        public void InserirVeiculo(VeiculoDTO dto)
        {
            dao.Insert("tbl_veiculo", dto);
        }

        public void AlterarVeiculo(VeiculoDTO dto)
        {
            dao.Update("tbl_veiculo", dto, 0);
        }

        public void ExcluirVeiculo(VeiculoDTO veiculo)
        {
            dao.Delete("tbl_veiculo", veiculo, 0);
        }

        public DataTable ListarTodosVeiculos()
        {
            return dao.SelectAll("tbl_veiculo");
        }

        public DataTable ListarTodosVeiculos(int id)
        {
            return dao.SelectWhere("tbl_veiculo", $"id = '{id}'");
        }


    }
}