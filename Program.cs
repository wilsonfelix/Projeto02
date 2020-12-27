using System;
using Projeto02.Entities; //importando
using Projeto02.Repositories; //importando
using System.IO;

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
                Console.Write("Nome do produto.........: ");
                produto.Nome = Console.ReadLine();
                Console.Write("Preço do produto........: ");
                produto.Preco = decimal.Parse(Console.ReadLine());
                Console.Write("Quantidade do produto...: ");
                produto.Quantidade = int.Parse(Console.ReadLine());
                produto.DataCadastro = DateTime.Now.ToString("HHmmss_dd-MM-yyyy");

                //exportar os dados do produto para arquivo...

                var produtoRepositoryJSON = new ProdutoRepositoryJSON();

                produtoRepositoryJSON.Exportar(produto);

                Console.WriteLine("\nArquivo JSON gerado com sucesso!!!");

            }
            catch(Exception e) //captura do erro!
            {
                //imprimir mensagem de erro
                Console.WriteLine("\nOcorreu um erro: " + e.Message + "\nO log do erro pode ser lido no caminho: " + @"h:\Projetos\Repositorio_local\Projeto02\");

                //Criando arquivo de log
                var logErro = @"h:\Projetos\Repositorio_local\Projeto02\Log_Erro" + DateTime.Now.ToString("HHmmss_dd-MM-yy_") + $"{e.Message}.txt";

                using (var streamWriter = new StreamWriter(logErro))
                {
                    //escrever dentro do arquivo o conteúdo do JSON
                    streamWriter.WriteLine(logErro);
                }
            }
            Console.ReadKey();
        }
    }
}
