using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoRegistroCarro2.Carro;

namespace ProjetoRegistroCarro2.Operacoes
{
    public class RegistroDeCarro
    {

        public void RegistrarCarro(){
            var especificacao = new Especificacao();

            Console.WriteLine("-------------------------------------");
            
            Console.WriteLine("Modelo do carro: ");
            especificacao.Modelo = Console.ReadLine();

            Console.WriteLine("Placa do carro: ");
            especificacao.Placa = Console.ReadLine();

            Console.WriteLine("Exercicio do carro: ");
            especificacao.Exercicio = Console.ReadLine();

            ListaDeCarro lista = new ListaDeCarro();
            lista.AddCarro(especificacao);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Registro realizado com sucesso!");
            Console.WriteLine("-------------------------------------");

            return;            
        }
    }
}