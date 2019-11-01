using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class ModeloBLL
    {
        DALOficina dao;

        public ModeloBLL()
        {
            dao = new DALOficina("localhost", "oficina", "root", "");
        }

        public DataTable ListarModelos()
        {
            return dao.SelectAll("tbl_modelo");
        }
    }
}