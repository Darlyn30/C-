using System;
using System.Threading.Tasks;

namespace Primeros_pasos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"SALUDOS CAMPEON, BIENVENIDO A LA  DUNGEON: NOMBRE DEL PROYECTO ");
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

               Console.WriteLine(@"SALUDOS CAMPEON, BIENVENIDO A DUNGEON: ");// nombre del projecto

                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para empezar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(@"SALUDOS CAMPEON, BIENVENIDO A LA  DUNGEON: ");
                Console.WriteLine(@"Selecciona uno de los Heroes ");
                int JUGADOR;
                //int MAGO, CABALLERO, ARQUERO;
                Console.WriteLine("MAGO (1), CABALLERO (2), ARQUERO(3), Selecciona 1 2 o 3 segun corresponda: ");
                JUGADOR = Convert.ToInt32(Console.ReadLine());



                if(JUGADOR == 3){
                    int VIDA = 350;
                    Console.WriteLine($"Muy bien, haz seleccionado el arquero , que cuenta con {VIDA} HP");

                }

                int bossHealth = 270;
                Console.WriteLine("te toca pelear contra el boss final");
                //boss pelea

                //tendras que atacar y recibiras un golpe del boss


                Console.WriteLine("atacar S/n"); // JUGAR
                var ataque = Console.ReadLine();
                while(ataque != "s"){
                    Console.WriteLine("debes atacar");
                    ataque = "";
                    ataque = Console.ReadLine();

                } 



                if(ataque == "s"){ // si es true
                    bossHealth = bossHealth - 30;
                    Console.WriteLine(bossHealth + "/270");
                    int VIDA = 350;
                    VIDA = VIDA - 40;
                    Console.WriteLine($"su vida actualmente es {VIDA}/350");
                    Console.WriteLine("la vida actual del boss es: ");
                

                    while(bossHealth > 0 ){
                        bossHealth = bossHealth - 50;
                        Console.WriteLine(bossHealth);
                        bossHealth = bossHealth-50;
                        Console.WriteLine(bossHealth);
                        bossHealth = 0;
                        Console.WriteLine($"la vida del boss es: {bossHealth}/270" );
                        
                    }
                while(bossHealth != 0) {
                    VIDA = VIDA - 30; 
                    Console.WriteLine(VIDA-30);
                    VIDA = 0;
                }
                if(VIDA == 0){
                    Console.WriteLine("has perdido");
                
                } else {}

                if (bossHealth == 0){
                    Console.WriteLine("se termino el juego: gracias por jugar");
                } else {}
                while(VIDA == 0){
                    Console.WriteLine("deseas continuar?");
                    var continuar = Console.ReadLine();
                    if(continuar == "s"){
                        
                Console.WriteLine(@"SALUDOS CAMPEON, BIENVENIDO A DUNGEON: ");// nombre del projecto

                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para empezar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(@"SALUDOS CAMPEON, BIENVENIDO A LA  DUNGEON: ");
                Console.WriteLine(@"Selecciona uno de los Heroes ");
                        JUGADOR = Convert.ToInt32(Console.ReadLine());
                    }
                }
                }



                // for(var i = bossHealth; i <=0; i-- ){
                //     Console.WriteLine("la vida actual del boss final es " +bossHealth + "/270");
                
                // }



                // while(JUGADOR == bossHealth){
                //     bossHealth = bossHealth-30;
                //     Console.WriteLine(bossHealth);
                // }





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
