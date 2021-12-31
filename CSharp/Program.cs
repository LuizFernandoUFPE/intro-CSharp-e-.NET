using System;
using Primeiro;
using Terceiro;
using Classe;
using Interface;
using Enum;

namespace CSharp
{ 
    class Program
    {
        static void Main(string[]args)
        {

            Console.WriteLine("Hello, World!");

            //treinando sobre namespace
            var classe = new Primeiro.Classe();
            var classe2 = new Segundo.Classe();
            var classe3 = new Teste();

            //treinando sobre Classe
            Animal animal1 = new Animal();
            animal1.Nome = "Max";
            animal1.Idade = 5;
            animal1.Especie = "Cachorro";

            Animal animal2 = new Animal();
            animal2.Nome = "Chloe";
            animal2.Idade = 10;
            animal2.Especie = "Golfinho";

            Pessoa person1 = new Pessoa();
            person1.Nome = "Rachel";
            person1.Estado = "PE";
            person1.Idade = 22;

            var person2 = new Pessoa();
            person2.Nome = "Amber";
            person2.Estado = "Teyvat";
            person2.Idade = 16;

            //treinando sobre Interface
            var passaro = new Passaro();
            passaro.Nome = "Happy";
            passaro.Dono = "Luiz";
            passaro.Especie = "Calopsita";

            //treinando sobre Enum
            var estacao1 = (Estacao)0;
            Estacao estacao2 = (Estacao)1;
            Estacao estacao3 = (Estacao)(2);
            Estacao estacao4 = Estacao.inverno;

            //Debugging: A depuração pode ser feita colocando um BreakPoint
            //no canto esquerdo do código e executando ele. Assim o código vai parar onde foi colocado
            //o BreakPoint e daí então podemos inspecioná-lo. O f9 altera entre BreakPoints
            //e o f10 vai pulando de método em método. 
            Console.WriteLine(estacao1);
            Console.WriteLine(estacao2);
            Console.WriteLine(estacao3);
            Console.WriteLine(estacao4);

        }
    }

}