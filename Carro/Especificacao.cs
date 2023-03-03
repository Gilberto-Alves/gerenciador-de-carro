using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRegistroCarro2.Carro
{
    public class Especificacao
    {
        public string Modelo {get; set;}
        public string Placa { get; set; }
        public string Exercicio { get; set; }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Modelo: " + this.Modelo + " | ";
            retorno += "Placa: " + this.Placa + " | ";
            retorno += "Exercicio: " + this.Exercicio;
            return retorno;
        }

    }
}