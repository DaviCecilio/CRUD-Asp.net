using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class ProdutoDTO
    {
        private int id, qtde_estoque;
        private double preco;
        private string nome;

        public int Id { get => id; set => id = value; }
        public int Qtde_estoque { get => qtde_estoque; set => qtde_estoque = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}