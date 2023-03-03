using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRegistroCarro2.Execucao
{
    public class Instrucoes
    {
        public string primeiraInstrucao(){
            Console.WriteLine("");
            Console.WriteLine("Digite um numero de 1 a 5");
            Console.WriteLine("1- Para registrar um carro");
            Console.WriteLine("2- Para listar os carros");
            Console.WriteLine("3- Para apagar um carro");
            Console.WriteLine("X- Para finalizar o programa");
            Console.WriteLine("");

            string OpcaoUsuario = Console.ReadLine();
            return OpcaoUsuario;
        }
    }
}