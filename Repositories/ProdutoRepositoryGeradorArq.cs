using System;
using Projeto02.Entities;


namespace Projeto02.Repositories
{
    public class ProdutoRepositoryGeradorArq
    {
        
            public void GeraJSON()
                {

                var produto = new Produto();
                var produtoRepositoryJSON = new ProdutoRepositoryJSON();

                produtoRepositoryJSON.Exportar(produto);

                Console.WriteLine("\nArquivo JSON gerado com sucesso!!!");
                }
            
    
        
            public void GeraXML()
                {

                var produto = new Produto();
                var produtoRepositoryXml = new ProdutoRepositoryXML();

                produtoRepositoryXml.Exportar(produto);

                Console.WriteLine("\nArquivo XML gerado com sucesso!!!");

                }

            public void GeraAmbos()
                {

                var produto = new Produto();
                var produtoRepositoryJSON = new ProdutoRepositoryJSON();
                var produtoRepositoryXml = new ProdutoRepositoryXML();

                produtoRepositoryJSON.Exportar(produto);
                produtoRepositoryXml.Exportar(produto);

                Console.WriteLine("\nArquivos JSON e XML gerados com sucesso!!!");

                }
    

        }
    
}
