using System;
using Projeto02.Entities; //importando
using Projeto02.Repositories; //importando
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n *** EXPORTADOR DE PRODUTOS *** \n");
            
            //tratamento de exceções
            try //tentativa!
            {
                //criar um objeto para a classe produto...
                //ler os dados do produto informado pelo usuário...
                var produto = new Produto();
                
                produto.IdProduto = Guid.NewGuid();
                produto.DataCadastro = produto.DataCadastro;
                Console.Write("Nome do produto.........: ");
                produto.Nome = Console.ReadLine();
                Console.Write("Preço do produto........: ");
                produto.Preco = decimal.Parse(Console.ReadLine());
                Console.Write("Quantidade do produto...: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                //exportar os dados do produto para arquivo...

                var produtoRepositoryJSON = new ProdutoRepositoryJSON();

                produtoRepositoryJSON.Exportar(produto);

                Console.WriteLine("\nArquivo JSON gerado com sucesso!!!");

            }
            catch(Exception e) //captura do erro!
            {
                //imprimir mensagem de erro
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
