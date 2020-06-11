using System;

namespace Aula_15___Try_Catch
{
    public class Permissao
    {
        
        public bool Acesso { get; set; }

        public void Autorizar(){

            
            try{
                
                Console.WriteLine("Deseja que Mario continue correndo? Responda com True/False");
                Acesso = Boolean.Parse( Console.ReadLine() );
                if(Acesso){
                    System.Console.WriteLine("Mario continua a correr, em busca de sua princesa.");
                }

            }catch(Exception){

                Console.WriteLine("Erro na inserção, porfavor insira novamente os dados.");

            }


        }

    }
}