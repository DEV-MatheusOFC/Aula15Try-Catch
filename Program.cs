using System;
using System.IO;

namespace Aula_15___Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mario mario = new Mario();
            mario.Correr();


            Permissao app = new Permissao();
            app.Autorizar();

            
        }
    }
}
