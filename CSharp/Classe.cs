using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Uma Classe tem campos, propriedades,
//métodos e eventos dentro dela, os chamados "membros".

//Quando uma classe é "instanciada", essa instância é chamada de 
//"Objeto", e é nesse objeto que podem ser criados os valores
//de acordo com os campos da classe


namespace Classe
{
    class Animal
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Especie { get; set; }

    }

    class Pessoa
    { 
        public string? Nome { get; set; }
        public string? Estado { get; set; }  
        public int Idade { get; set; }
    }
}
