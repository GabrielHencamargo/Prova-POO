using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaVeiculo
{
    internal class Fcaminhao : veiculo
    {
        //atributos de classe filha
        private int eixos;

        public Fcaminhao() { }
        public Fcaminhao(string _placa,int _ano,int _eixos) : base(_placa,_ano)
        {
            eixos = _eixos;
            Placa = _placa;
            Ano = _ano;
        }

        public int Eixos { get => eixos; set => eixos = value; }

        //metodos classe filha
        public override double alugar()
        {
            return (300 * eixos) - (2023 - Ano);
        }
    }
}
