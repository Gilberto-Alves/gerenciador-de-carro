using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoRegistroCarro2.Carro;
using ProjetoRegistroCarro2.Execucao;

namespace ProjetoRegistroCarro2.Operacoes
{
    public class RemoverCarro
    {

        private Instrucoes instrucoes = new Instrucoes();
        private ListaDeCarro listaDeCarro = new ListaDeCarro();

        public void removerIndice(){
            var lista = listaDeCarro.retornoLista;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Digite o indice em que o carro está:");

            int indice = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Carro removido com sucesso!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");

            listaDeCarro.deleteCarro(indice);

        }
    }
}