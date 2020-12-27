using System;
using System.Collections.Generic;
using System.Text;
using Projeto02.Entities;
using Newtonsoft.Json;
using System.Xml.Serialization;
using Projeto02.Repositories;
using Projeto02.Inputs;


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
    

        }
    
}
