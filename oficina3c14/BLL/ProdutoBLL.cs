using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class ProdutoBLL
    {
        DALOficina dao;

        public ProdutoBLL()
        {
            dao = new DALOficina("localhost", "oficina", "root", "");
        }

        public void InserirProduto(ProdutoDTO dto)
        {
            dao.Insert("tbl_produto", dto);
        }

        public void AlterarProduto(ProdutoDTO dto)
        {
            dao.Update("tbl_produto", dto, 0);
        }

        public void ExcluirProduto(ProdutoDTO produto)
        {
            dao.Delete("tbl_produto", produto, 0);
        }

        public DataTable ListarTodosProdutos()
        {
            return dao.SelectAll("tbl_produto");
        }


    }
}