using System;
using System.Collections.Generic;
using System.Text;


namespace Projeto02.Inputs
{
    public class ProdutoInput
    {
        //método ler nome do produto, informado no prompt
        public string LerNome()
        {
            Console.Write("Informe o nome do produto.........: ");
            return Console.ReadLine();
        }

        //método ler preço do produto, informado no prompt
        public decimal LerPreco()
        {
            Console.Write("Informe o preço do produto........: ");
            return decimal.Parse(Console.ReadLine());
        }

        //método ler quantidade do produto, informado no prompt
        public int LerQuantidade()
        {
            Console.Write("Informe o quantidade do produto...: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
