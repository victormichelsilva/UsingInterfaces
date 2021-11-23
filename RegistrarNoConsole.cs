using System;
using System.Collections.Generic;
using System.Text;

namespace UsandoInterfaces
{
    public class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"infor : {mensagem}");
        }
    }
}
