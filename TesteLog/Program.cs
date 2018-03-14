using System;
using TesteLog.Domain.Entities;

namespace TesteLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Renato");

            user.Add().Info("Teste");
           
        }
    }
}
