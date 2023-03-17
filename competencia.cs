
using System;
namespace competencia {
    class Program {
        static void Main (string [] args) {
            
            Random namesRandom = new Random();
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
            List<string> alumnos = new List<string>(names.Length);
            Console.WriteLine("presione una tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine("deseas mostrar la lista con todos los integrantes?");
            Console.WriteLine("S/n");
            char ans = Console.ReadKey().KeyChar;

            
             if(ans == 's'){
                Console.WriteLine("aqui esta la lista: ");
                mostrarEstudiantes(names);
             } else {
                Console.WriteLine("ok no se mostrara la lista");
             }
             Console.WriteLine("continuemos");
             Console.WriteLine("presione cualquier tecla para continuar...");
             Console.ReadKey();
                Console.Clear();
            int firstName = namesRandom.Next(0,43);
            int secondName = namesRandom.Next(0,43);
            while(firstName == secondName){
                secondName = namesRandom.Next(0,43);
            }
            Console.WriteLine(names[firstName] + " primer agraciado, pase al frente");
            Console.WriteLine("presione una tecla para mostrar el proximo:");
            Console.ReadKey();
            Console.WriteLine("\n");
            Console.WriteLine(names[secondName] + " pase al frente tambien, " + "que programara su compa?");

            // Console.WriteLine("\n");
            // foreach (string name in names){
            //     Console.WriteLine(name);
            // }
            // Console.WriteLine("\n");

        }
        static void mostrarEstudiantes(string[] names){
            foreach (string name in names){
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");
          
        }
    }
}
