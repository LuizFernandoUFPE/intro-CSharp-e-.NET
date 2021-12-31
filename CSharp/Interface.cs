using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//A Interface é como uma classe base
//que serve de molde para várias classes
//Uma classe que implementa uma interface deve implementar 
//todos os membros
//É uma forma de não esquecer quais campos nossa classe tem que ter
//pois ela obrigatoriamente vai ter que herdar os campos da interface.

namespace Interface
{
 
    interface IPassaro
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Passaro : IPassaro
    {

    
        public string? Nome { get; set; }
        public string? Dono { get; set; }
        public string? Especie { get; set; }

        void IPassaro.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IPassaro.Dono(string nomeDono)
        {
            this.Dono = nomeDono;
        }
        void IPassaro.Especie(string especie)
        {
            this.Especie = especie;
        }
    }

}
  
