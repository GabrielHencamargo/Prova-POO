using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNome
{
    internal class NomeProprio
    {
        //atributos
        private string nomecompleto;
        private string nome_paper;

        public NomeProprio() { }
        public NomeProprio(string _nomecompleto)
        {
            nomecompleto = _nomecompleto;
        }
        public string Nomecompleto { get => nomecompleto; set => nomecompleto = value; }
        public string Nome_paper { get => nome_paper; set => nome_paper = value; }
        
        //metodos
        public void geranomepaper()
        {
            if ((nomecompleto.Split(" ")).Length >= 3)
            {
                string primeironome = nomecompleto.Split(" ")[0];
                string nomemeio = (nomecompleto.Split(" ")[1]);
                string sobrenome = nomecompleto.Split(" ")[2];
                char inicial = char.ToUpper(nomemeio[0]);
                nome_paper =  sobrenome + "," + primeironome + " " +inicial + ".";
            }
            if ((nomecompleto.Split(" ")).Length < 3)
            {
                string primeironome = nomecompleto.Split(" ")[0];
                string sobrenome = (nomecompleto.Split(" ")[1]);
                nome_paper =  sobrenome + "," + primeironome;
            }
            

            
            
            
        }
    }
}
