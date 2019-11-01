using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace DTO
{
    public class VeiculoDTO
    {
        private int id;
        private string placa, ano, cor;
        private int id_dono, id_modelo;

        public int Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Id_dono { get => id_dono; set => id_dono = value; }
        public int Id_modelo { get => id_modelo; set => id_modelo = value; }
    }
}