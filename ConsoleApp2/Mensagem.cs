using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Mensagem
    {
        //    private string TextoMensagem;

        //    public void ExibirMensagem()
        //    {
        //        Console.WriteLine(this.TextoMensagem);
        //    }
        //    public string getTextoMensagem()
        //    {
        //        return this.TextoMensagem;
        //    }   
        //            public void setTextoMensagem(string valor)
        //    {
        //this.TextoMensagem = valor.ToUpper();

        private string textoMensagem;
        public string TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }
            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }
        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
    

    

