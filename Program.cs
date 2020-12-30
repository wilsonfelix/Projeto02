using System;
using Projeto02.Entities; //importando
using Projeto02.Repositories; //importando
using System.IO;
using Projeto02.Inputs;



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
                var produtoRepositoryGeradorArq = new ProdutoRepositoryGeradorArq();
                
                var menu = new Menu();
                var produto = new Produto();
                produto.IdProduto = Guid.NewGuid();
                
                //********************************************
                //Recebe os metodos de entrada de dados da classe "ProdutoInput" para receber os dados
                //inseridos pelo usuário
                produto.Nome = ProdutoInput.LerNome();
                produto.Preco = ProdutoInput.LerPreco();
                produto.Quantidade = ProdutoInput.LerQuantidade();
                //********************************************
                produto.DataCadastro = DateTime.Now.ToString("HHmmss_dd-MM-yyyy");

                //exportar os dados do produto para arquivo...
                var menuJSON_XML = new MenuJSON_XML();
                menu.seletor = menuJSON_XML.SelecionarArquivo();
                
                if (menu.seletor == 1)
                {
                    produtoRepositoryGeradorArq.GeraJSON();
                
                }
                else if(menu.seletor == 2)
                {
                    produtoRepositoryGeradorArq.GeraXML();

                }
                else if(menu.seletor ==3)
                {
                    produtoRepositoryGeradorArq.GeraAmbos();

                }
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
