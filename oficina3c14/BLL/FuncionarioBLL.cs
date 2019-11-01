using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class FuncionarioBLL
    {
        DALOficina dao;

        public FuncionarioBLL()
        {
            dao = new DALOficina("localhost", "oficina", "root", "");
        }

        public void InserirFuncionario(FuncionarioDTO dto)
        {
            dao.Insert("tbl_funcionario", dto);
        }

        public void AlterarFuncionario(FuncionarioDTO dto)
        {
            dao.Update("tbl_funcionario", dto, 0);
        }

        public void ExcluirFuncionario(FuncionarioDTO funcionario)
        {
            dao.Delete("tbl_funcionario", funcionario, 0);
        }

        public DataTable ListarTodosFuncionarios()
        {
            return dao.SelectAll("tbl_funcionario");
        }
    }
}