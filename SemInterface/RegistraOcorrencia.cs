using System;
using System.Collections.Generic;
using System.Text;

namespace SemInterface
{
    public class RegistraOcorrencia
    {
        public void RegistrarNoConsole(string mensagem) 
        {
            Console.WriteLine($" {mensagem} : {DateTime.Now}");
        }

        public void RegistrarNoArquivo(string caminho) 
        {
            // codigo para registrar no arquivo
        }

        public void RegistrarNoDataBase(string conexao, string mensagem) 
        {
            // codigo para registrar no database
        }
    }
}
