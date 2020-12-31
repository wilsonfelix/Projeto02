using System;
using System.Collections.Generic;
using System.Text;

//namespace ->Localização da clase no projeto
namespace Projeto02.Entities
{
    //public -> acesso total
    public class Produto
    {
        //properties (propriedades)
        //Campos da classe declarados com set(entrada)/get(saida)
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string DataCadastro { get; set; }

    }
}
