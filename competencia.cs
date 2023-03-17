using System;
namespace competencia {
    class Program {
        static void Main(string[] args) {
              Random namesRandom = new Random();

            List<string> names = new List<string> {
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

            int firstName;
            int secondName;
            int namesLength = names.Count-1; //se pone -1 porque esta variable se usara para generar el indice que se va a buscar en la lista al usar Random.Next();
            int counter = 1;

            Console.WriteLine("\nbienvenido al programa de autoseleccion\n");
            Console.WriteLine("deseas mostrar la lista con todos los integrantes?");
            Console.WriteLine("s/n");

            char ans = Console.ReadKey().KeyChar;

            if (ans == 's'){
                Console.WriteLine("\naqui esta la lista: ");
                mostrarEstudiantes(names); // esta es una funcion
            }
            else {
                Console.WriteLine("\nok no se mostrara la lista");
            }

            Console.WriteLine("\ncontinuemos");

            Console.WriteLine("presione cualquier tecla para continuar...\n");

            // se utiliza un ciclo infinito para esperar a que se presione cualquier tecla
            while (true){
                // se genera un numero aleatorio entre el inicio de la lista y el ultimo elemento de esta
                firstName = namesRandom.Next(0, namesLength);
                secondName = namesRandom.Next(0, namesLength);

                // se verifica que el primer numero y el segundo numero generados nunca sean iguales
                while (firstName == secondName){
                    secondName = namesRandom.Next(0, namesLength);
                }

                // se usan codigos de escape ANSI para decorar el texto en la terminal
                Console.ReadKey();
                Console.WriteLine("\x1B[0;32m**************************************************************************\x1B[0;37m\n"); // colores
                Console.WriteLine(names[firstName] + " es el primer agraciado, pase al frente");
                Console.WriteLine(names[secondName] + " pase al frente tambien, " + "que programara su compa?\n");
                Console.WriteLine("\x1B[0;33mpresione una tecla para mostrar el proximo:\x1B[0;37m");
                Console.WriteLine("\n\x1B[0;32m**************************************************************************\x1B[0;37m\n\n"); // colores

                // se elimina de la lista names los nombres que ya fueron elegidos
                names.Remove(names[firstName]);
                names.Remove(names[secondName]);
                namesLength-=2; // se resta de la variable los 2 elementos que fueron eliminados de la lista
                counter+=2; // se aumenta el contador que se usara para salir del ciclo

                if (counter == 43) {
                    Console.WriteLine("Ya no quedan mas estudiantes\nPresione cualquier tecla para continuar . . .");
                    Console.ReadKey();
                    break;
                }
            }
        }
        static void mostrarEstudiantes(List<string> names){ // esto es una funcion que sirve para mostrar la lista
            foreach (string name in names){
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");

        }
    }
}
