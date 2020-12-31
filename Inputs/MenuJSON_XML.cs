using System;


namespace Projeto02.Inputs
{
    public class MenuJSON_XML
    {
        public int SelecionarArquivo()
        {
            Console.Write("\nDeseja exportar em qual extensão de arquivo? \n");
            Console.Write("Selecione 1 para JSON, 2 para XML ou 3 para ambos: ");
            return int.Parse(Console.ReadLine());
            
            
        }
    }
}
