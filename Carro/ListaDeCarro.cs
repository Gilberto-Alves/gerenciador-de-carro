using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRegistroCarro2.Carro
{
    public class ListaDeCarro
    {
        Especificacao especificacao;
        private static List<Especificacao> especif = new List<Especificacao>();

        public void AddCarro(Especificacao carro){
            especif.Add(carro);
        }

        public void deleteCarro(int indice){
            especif.RemoveAt(indice);
        }

        public List<Especificacao> retornoLista(){
            return especif;
        }
    }
}