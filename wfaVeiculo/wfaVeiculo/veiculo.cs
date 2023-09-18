using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaVeiculo
{
    abstract class veiculo
    {
        //atributos
        protected string placa;
        protected int ano;

        public veiculo() { }
        public veiculo(string placa, int ano)
        {
            this.placa = placa;
            this.ano = ano;
        }

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }
        //metodos
        public abstract double alugar();
        
    }
}
