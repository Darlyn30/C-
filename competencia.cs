
using System;
namespace competencia {
    class Program {
        static void Main (string [] args) {
            Random randomNumber = new Random();
            string[] names = {
                "albani nicole solano", "alvaro estefan santana corporan", "anderson david montero gonzalez", "andy mu?oz capellan", "antony jose mendez guerrero",
                "benjamin aguero madera", "carlos daniel tejada marte", "carlos enrique matos feliz", "christopher franco veras", "cruz abel montero mercado",
                "daimon alexander aquino chalas", "dariana cabrera castillo", "darlyn olivo payano", "denzel alexander rodriguez ferreras", "elias manuel rosario",
                "emil junior piron marcelo", "ernesto antonio castillo herrera", "fernando brayan juliao de los santos", "francisco jose lopez ozuna", "genesis jahel mojica mateo",
                "jan marco romero peralta", "jesus alejandro pe?a soto", "jhon axell almanzar fernandez", "joely morales", "jose ismael leon cuevas", "joseph ruben lopez feliz",
                "kelvin andres feliz santana", "luis alejandro hernandez gonzalez", "luis francisco geronimo dipp", "meinard martinez beltres", "nicole tremols samboy",
                "nicolle batista soto", "oliver abreu mateo", "omar de jesus fajardo burgos", "roither sanchez sosa", "ryan svelti dominguez", "sebastian valdez espaillat",
                "tahis paola hernandez sanchez", "thomas de los santos aracena de la cruz", "waniel alexander torres ramirez", "waskar enrique a?il", "yanser manuel nu?ez", 
                "yeicol jose camacho calderon", "yeremi sanchez rodriguez"

            };

            int firstName = randomNumber.Next(0,43);
            int secondName = randomNumber.Next(0,43);

            if( firstName == secondName){
                while(firstName == secondName){
                    secondName = randomNumber.Next(0,43);
                }
            }
            Console.WriteLine(names[firstName] + " pase al frente");
            Console.WriteLine("\n");
            Console.WriteLine(names[secondName] + " pase al frente tambien " + "que programa su compa?");

            // Console.WriteLine("\n");
            // foreach (string name in names){
            //     Console.WriteLine(name);
            // }
            // Console.WriteLine("\n");

        }
    }
}
