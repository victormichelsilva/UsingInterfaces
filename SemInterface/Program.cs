using System;

namespace SemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistraOcorrencia registraOcorrencia = new RegistraOcorrencia();
            registraOcorrencia.RegistrarNoConsole("registrar no console");

            Console.WriteLine("Hello World!");
        }
    }
}
