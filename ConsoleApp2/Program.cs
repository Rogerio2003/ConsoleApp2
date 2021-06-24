using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;

            msg1 = new Mensagem();

            msg1.TextoMensagem = "acorda vagaba";
            msg1.ExibirMensagem();
            

            Console.ReadKey();
        }
    }
}
