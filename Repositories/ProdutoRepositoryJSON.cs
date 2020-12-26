using System;
using System.Collections.Generic;
using System.Text;
using Projeto02.Entities; //importando
using Newtonsoft.Json; //importando
using System.IO; //importando


namespace Projeto02.Repositories
{
    public class ProdutoRepositoryJSON
    
    {
        //método para exportar os dados do produto
        //para um arquivo de extensão .json
        public void Exportar(Produto produto)
        {
            //serializar o objeto "produto" para o formato JSON
            var json = JsonConvert.SerializeObject(produto, Formatting.Indented);

            //definir nome do arquivo
            var nomeArquivo = @"h:\Projetos\Repositorio_local\Projeto02\produto_" + DateTime.Now.ToString("HHmmss_dd-MM-yy_") + $"{ produto.IdProduto}.json";
            
            //abrindo o arquivo para gravação
            using (var streamWriter = new StreamWriter(nomeArquivo))
            {
                //escrever dentro do arquivo o conteúdo do JSON
                streamWriter.WriteLine(json);
            }

            //ou
            //abrindo o arquivo para gravação
            //var streamWriter = new StreamWriter(nomeArquivo)
            //streamWriter.WriteLine(json);
            //streamWriter.Close(); --> não pode deixar de fechar

        }
    }
    
    // Sobrecarga

    //public class Test
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("Olá!");

    //    }
    //    public void Print(string name)
    //    {
    //        Console.WriteLine("Olá, " + name);
    //    }
    //}

    //class Program2
    //{
    //    void Main()
    //    {
    //        var test = new Test();
    //        test.Print();
    //    }
    //}
}
