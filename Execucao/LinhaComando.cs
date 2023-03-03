using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoRegistroCarro2.Operacoes;

namespace ProjetoRegistroCarro2.Execucao
{
    public class LinhaComando
    {
        RemoverCarro removerCarro = new RemoverCarro();
        Instrucoes instrucoes = new Instrucoes();
        RegistroDeCarro registroDeCarro = new RegistroDeCarro();
        LerRegistro lerRegistro = new LerRegistro();

        public void escolha(){
            string Opcao = instrucoes.primeiraInstrucao();

            while(Opcao.ToUpper() != "X"){
                switch(Opcao){
                    case "1":
                        registroDeCarro.RegistrarCarro();
                        break;
                    case "2":
                        lerRegistro.leituraTotal();
                        break;
                    case "3":
                        removerCarro.removerIndice();
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Opcao = instrucoes.primeiraInstrucao();
                        Console.WriteLine("");
                        break;
                }

                Opcao = instrucoes.primeiraInstrucao();
                Console.WriteLine("");
            }
        }
    }
}