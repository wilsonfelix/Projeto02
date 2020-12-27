using System;
using System.Collections.Generic;
using System.Text;
using Projeto02.Entities; //importando
using System.Xml.Serialization; //importando
using System.IO; //importando

namespace Projeto02.Repositories
{
    public class ProdutoRepositoryXML
    {
        
        //método para exportar os dados do produto
        //para um arquivo de extensão XML
        public void Exportar(Produto produto)
        {
            //serializar o objeto "produto" para o formato XML
            var xml = new XmlSerializer(produto.GetType());

            //definir nome do arquivo
            var nomeArquivo = @"h:\Projetos\Repositorio_local\Projeto02\produto_" + DateTime.Now.ToString("HHmmss_dd-MM-yy_") + $"{ produto.IdProduto}.xml";

            //abrindo o arquivo para gravação
            using (var streamWriter = new StreamWriter(nomeArquivo))
            {
                //escrever dentro do arquivo o conteúdo do JSON
                streamWriter.WriteLine(xml);
            }

            //ou
            //abrindo o arquivo para gravação
            //var streamWriter = new StreamWriter(nomeArquivo)
            //streamWriter.WriteLine(json);
            //streamWriter.Close(); --> não pode deixar de fechar

        }
    }

}

