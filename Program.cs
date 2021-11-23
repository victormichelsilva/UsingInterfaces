using System;

namespace UsandoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var registraConsole = new RegistraOcorrencias(new RegistrarNoConsole());
            registraConsole.Registrar("registro no console");

            var registraArquivo = new RegistraOcorrencias(new RegistrarNoArquivo(@"c:\dados\teste.txt"));

            registraArquivo.Registrar("registro no arquivo");
        }
    }
}
