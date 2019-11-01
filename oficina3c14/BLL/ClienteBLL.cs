using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class ClienteBLL
    {
        DALOficina dao;

        public ClienteBLL()
        {
            dao = new DALOficina("localhost", "oficina", "root", "");
        }
            public DataTable ListarClientes()
        {
            return dao.SelectAll("tbl_cliente");
        }
    }
}