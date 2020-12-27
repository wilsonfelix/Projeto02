using System;
using System.Collections.Generic;
using System.Text;
using Projeto02.Entities;
using Projeto02.Inputs;
using Projeto02.Repositories;


namespace Projeto02.Inputs
{
    public class MenuJSON_XML
    {
        public static int SelecionarArquivo()
        {
            Console.Write("\nDeseja exportar em qual extensão de arquivo? \n");
            Console.Write("\nSelecione 1 para JSON, 2 para XML ou 3 para ambos: \n");
            return int.Parse(Console.ReadLine());
            Console.ReadKey();
            
        }
    }
}
