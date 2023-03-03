using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoRegistroCarro2.Carro;

namespace ProjetoRegistroCarro2.Operacoes
{
    public class LerRegistro
    {

        public void leituraTotal(){
            ListaDeCarro totalCarros = new ListaDeCarro();

            var listaDeCarro = totalCarros.retornoLista();

            if(listaDeCarro.Count == 0) {
                Console.WriteLine("Até o momento nenhuma conta foi cadastrada.");
                return;
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Contas cadastradas: ");
            Console.WriteLine("-------------------------------------");
            for(int i = 0; i < listaDeCarro.Count; i++){
                Especificacao especificacao = listaDeCarro[i];
                Console.Write($"{i} : ");
                Console.WriteLine(especificacao);
            }
            Console.WriteLine("-------------------------------------");

        }
    }
}