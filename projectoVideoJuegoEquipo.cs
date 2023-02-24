using System;
using System.Threading.Tasks;

namespace Primeros_pasos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"SALUDOS CAMPEON, BIENVENIDO A LA  DUNGEON: "); // NOMBRE DEL PROYECTO
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para empezar");
            Console.ReadKey();
            Console.Clear();
            // Console.WriteLine(@"SALUDOS CAMPEON, BIENVENIDO A LA  DUNGEON: NOMBRE DEL PROYECTO "); // puse esto de nuevo para limpiar cuando se ejecute el readkey
            Console.WriteLine(@"Selecciona uno de los Heros ");
            int JUGADOR;
            //int MAGO, CABALLERO, ARQUERO;
            Console.WriteLine("MAGO (1), CABALLERO (2), ARQUERO(3), Selecciona A B o C segun corresponda: ");
            JUGADOR = Convert.ToInt32(Console.ReadLine());
            if ( JUGADOR != 0){
                //OMAR AQUI PROGRAMAS:
                if ( JUGADOR == 1)
                {
                    int VIDAF = 4;
                    Console.WriteLine("Felicidaddes, acabas de escoger al mago, tienes {0}/4", VIDAF);
                    Console.WriteLine("Eres un mago con el hechizo de salvar tu vida, y tu objetivo es encontrar el baculo del poder");
                    Console.WriteLine("Cuentas con mana suficiente para salvar tu vida 4 veces, evita morir a toda costa!"); 

                    int vidasF = 4; // cantidad de hechizos 

                Console.WriteLine("Tienes dos opciones A o B, dependiendo del camino que escojas tendras que usar un hechizo o no.");
                Console.WriteLine("Spoiler, no saldras vivo de este dungeon");
                
                while (vidasF > 0) // while para mantener las vidas
                {
                    ConsoleKeyInfo input = Console.ReadKey(true); // recibir la letra del usuario

                    Console.WriteLine("Tienes dos opciones A o B, dependiendo del camino que escojas tendras que usar un hechizo o no.");
                    Console.Write(" ");
                    Console.WriteLine("Escuchas un sonido y por el tunel A y nada por el B, por cual tunel iras?");
                    Console.Write(" ");
                    Console.WriteLine("Ingresa tu seleccion A o B");

                    if (input.Key == ConsoleKey.A) // si presiona el A 
                    {
                        Console.WriteLine("El tunel A ha sido el correcto, estaras vivo por un rato mas");
                        continue;
                    }

                    // Si el jugador presiona la B, pierde una vida
                    Console.WriteLine("Al entrar al camino te esperaba un caballero con una bayoneta, utilizaste uno de tus hechizos");
                    vidasF--;

                    // verificar si posee hechizos disponibles
                    if (vidasF == 0)
                    {
                        Console.WriteLine("El caballero te clavo una flecha con su ballesta y moriste, intentalo de nuevo");
                        break;
                    }

                    Console.WriteLine("Te quedan: " + " " + vidasF + " hechizos utilizalos sabiamente. ");
                }

                Console.ReadKey();

                //OLIVER AQUI PROGRAMAS
                if ( JUGADOR == 2){
                    int VIDA = 500;
                    Console.WriteLine("Felicidaddes, acabas de escoger al caballero, tiene {0}/500", VIDA);
                }
                
                //DARLYN AQUI PROGRAMAS
                // if ( JUGADOR == 3){
                //     int VIDA = 350;
                //     Console.WriteLine("Felicidaddes, acabas de escoger al arquero, tiene {0}/350", VIDA);
                // }

                if(JUGADOR == 3){
                    int bossHealth = 4;
                    int VIDA = 5;
                    Console.WriteLine($"felicidades, elegiste al arquero");
                    Console.WriteLine($"este cuenta con {VIDA} vidas");

                    Console.WriteLine("te haz encontrado con el boss final");
                    Console.WriteLine("deseas atacar S/n");
                    var atacar = Console.ReadLine();
                    while(atacar != "s"){ //mientras la respuesta del ataque no sea atacar el juego se termina
                        Console.WriteLine("no puedes continuar");
                        Console.WriteLine("para jugar debes atacar");
                        Console.WriteLine("deseas atacar S/n");
                        atacar = Console.ReadLine();
                    }
                    if(atacar == "s"){
                        Console.WriteLine("tienes 3 habilidades disponibles");
                        Console.WriteLine("habilidades disponibles: 1) flecha explosiva, 2) flecha criptoniana 3) flecha con veneno");
                        int ataque = Convert.ToInt32(Console.ReadLine());
                        if(ataque == 1){
                            Console.WriteLine("usaste la flecha explosiva");
                            Console.WriteLine($"destruiste al boss que cuenta con {bossHealth-bossHealth} vidas pero no sobreviviste al impacto, y terminaste salvando a la dungeon");
                            Console.WriteLine("JUEGO TERMINADO");
                        } else if(ataque == 2){
                            Console.WriteLine("usaste flecha criptoniana y solo infectaste al boss");
                            Console.WriteLine($"mataste al boss {bossHealth-bossHealth}");
                            Console.WriteLine("JUEGO TERMINADO");
                        } else if(ataque == 3){
                            Console.WriteLine("usaste flecha con veneno y no le hiciste suficiente daño");
                            Console.WriteLine($"morirste y contigo toda la dungeon y terminaste con {VIDA - VIDA} vidas");
                        } else {
                            // si decide ponerse de trol y elegir una habilidad que no esta entre las opciones, se cierra automaticamente el juego
                            if(ataque != 1){
                                Console.WriteLine("JUEGO TERMINADO, NO DECIDISTE JUGAR");
                            } else if(ataque != 2){
                                Console.WriteLine("JUEGO TERMINADO, NO DECIDISTE JUGAR");
                            } else if(ataque != 3){
                                Console.WriteLine("JUEGO TERMINADO, NO DECIDISTE JUGAR");
                            }
                        }
                    }
                }







            }
            Console.WriteLine("Escoge un valor real");


            //para evitar poner tantos Console.WriteLine();
            //podemos usar esto || Console.WriteLine(@""); 
            //con esa arroba podemos hacer varios write sin tener que estar poniendo el comando completo

           //personaje 1
           //personaje 2

           //D
           //arquero






           //boss


        }
    }
}
}
