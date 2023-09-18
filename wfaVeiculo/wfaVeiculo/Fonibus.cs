using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaVeiculo
{
    internal class Fonibus : veiculo
    {
        //atributos
        protected int assentos;

        public int Assentos { get => assentos; set => assentos = value; }
        public Fonibus() { }
        public Fonibus(string _placa,int _ano,int _assentos) :base(_placa,_ano)
        {
            Placa = _placa;
            Ano = _ano;
            Assentos = _assentos;
        }
        //metodos
        public override double alugar()
        {
            return (30 * assentos) - (2023 - ano);
        }
    }
}
