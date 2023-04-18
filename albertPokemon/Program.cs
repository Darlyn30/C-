using System;
namespace pokemon {
    class Program {
        static void Main(string[] args){
            // code here
            string? [] pokemon = {
                "Charmander", "boulbasur", "squirtle", "pikachu"
            };
            int ataque = 100;
            Console.WriteLine("Bienvenidos a pokemon\n"); // titulo
            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
            Console.Clear();
            menu();
            int pokemonSelect = Convert.ToInt32(Console.ReadLine());
 // selecciona el pokemon
            selectPokemon(pokemonSelect, pokemon!, ataque); // funcion de seleccion

        }
        static void menu(){
            Console.WriteLine("selecciona un pokemon\n");
            Console.WriteLine("1) [Charmander]");
            Console.WriteLine("2) [Boulbasur]");
            Console.WriteLine("3) [Squirtle]");
            Console.WriteLine("4) [Pikachu]");
            
        }
        static void selectPokemon(int pokemonSelect, string[] pokemon, int ataque){
            // pokemonSelect = Convert.ToInt32(Console.ReadLine());
            switch(pokemonSelect){
                case 1:
                    Console.WriteLine("seleccionaste a " + pokemon[0]+"\n");
                    int HP = 100;
                    Console.WriteLine("este pokemon cuenta con " + HP + " de vida");
                    Console.Clear();
                    Console.WriteLine("habilidad: tipo fuego, ataque: lanzallama, bola de fuego");
                    Charmander(ataque);
                    break;
                case 2: 
                    Console.WriteLine("seleccionaste a " + pokemon[1] + "\n");
                    HP = 100;
                    Console.WriteLine("este pokemon cuenta con " + HP + " de vida");
                    Console.Clear();
                    Console.WriteLine("habilidad: tipo planta, ataque: hoja afilada, sequia de oxigeno");
                    boulbasur(ataque);
                    break;
                case 3:
                    Console.WriteLine("seleccionaste a " + pokemon[2]);
                    HP = 100;
                    Console.WriteLine("este pokemon cuenta con " + HP + " de vida");
                    Console.Clear();
                    Console.WriteLine("habilidad: tipo agua, ataque: hidrobomba, bola de agua");
                    squirtle(ataque);
                    break;
                case 4: 
                    Console.WriteLine("seleccionaste a " + pokemon[3]);
                    HP = 100;
                    Console.WriteLine("este pokemon cuenta con " + HP + " de vida");
                    Console.Clear();
                    Console.WriteLine("habilidad: tipo trueno, ataque: electricidad estatica, tormenta electrica");
                    pikachu(ataque);
                    break;
            }
        }
        static void Charmander(int ataque){
            Console.WriteLine("elija una habilidad");
            Console.WriteLine("1) [Bola de fuego]");
            Console.WriteLine("2) [lanzallama]");
            int vidaBoss = 100;
            while(vidaBoss > 0){
                 ataque = Convert.ToInt32(Console.ReadLine());
                switch(ataque){
                    case 1:
                    for(int i = vidaBoss; i >= 0; i -= 10){
                        Console.WriteLine("la bola de fuego le ha sacado -10 de vida al boss");
                        //  i = vidaBoss;
                        // i -= 10;
                        Console.WriteLine("la vida actual del boss es: " + i);
                            if(i <= 0){
                                Console.Clear();
                                Console.WriteLine("haz ganado");
                                Console.WriteLine("deseas salir?");
                                Console.WriteLine("S/n");
                                char exit = Console.ReadKey().KeyChar;
                                Console.Clear();
                                    if(exit == 's'){
                                        salir();
                                    } else if(exit == 'n'){
                                        menu();
                                    } else {
                                        while(exit != 's' || exit != 'n'){
                                            Console.WriteLine("opcion no encontrada");
                                            Console.WriteLine("por favor ingresa una opcion correcta");
                                            Console.WriteLine("deseas salir?");
                                            Console.WriteLine("S/n");
                                            exit = Console.ReadKey().KeyChar;
                                        }
                                    }
                        }
                        ataque = Convert.ToInt32(Console.ReadLine());
                        // if(vidaBoss <= 0){
                        //     Console.WriteLine("haz ganado");
                        //     Console.WriteLine("deseas salir?");
                        //     Console.WriteLine("S/n");
                        //     char exit = Console.ReadKey().KeyChar;
                        //     Console.Clear();
                        //         if(exit == 's'){
                        //             salir();
                        //         }
                        // }
                        
                        
                        // salir();


                        // salir();
                    }
                        // while(vidaBoss > 0){
                        //     // Console.WriteLine("lanza llamas quito -10 de vida al boss");
                        //     Console.WriteLine("lanza llamas quito -10 de vida al boss");
                        //     vidaBoss -= -10;
                        //     Console.WriteLine("la vida actual del boss es "+vidaBoss);
                        //     Charmander(ataque);
                        //     ataque = Convert.ToInt32(Console.ReadLine());
                        //     // Console.WriteLine("lanza llamas quito -10 de vida al boss");
                        //     // vidaBoss -= -10;
                        //     // Console.WriteLine("la vida actual del boss es "+vidaBoss);
                        //     // Charmander(ataque);
                        //     // vidaBoss -= -10;
                        //     // vidaBoss = vidaBoss - 10; 
                        //     // Console.WriteLine("la vida actual del boss es "+vidaBoss);
                            
                        // }       
                        break;
                    case 2: //habilidad de charmander
                        for(int i = vidaBoss; i >= 0; i -= 25){
                        Console.WriteLine("lanzallama:  le ha sacado -25 de vida al boss");
                        //  i = vidaBoss;
                        // i -= 10;
                        Console.WriteLine("la vida actual del boss es: " + i);
                            if(i <= 0){
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("haz ganado");
                                Console.WriteLine("deseas salir?");
                                Console.WriteLine("S/n");
                                char exit = Console.ReadKey().KeyChar;
                                Console.Clear();
                                    if(exit == 's'){
                                        salir();
                                    } else if(exit == 'n'){
                                        menu();
                                        Console.WriteLine("presione una tecla para continuar . . .");
                                        Console.ReadKey();
                                        salir();
                                    } else {
                                        while(exit != 's' || exit != 'n'){
                                            Console.WriteLine("opcion no encontrada");
                                            Console.WriteLine("por favor ingresa una opcion correcta");
                                            exit = Console.ReadKey().KeyChar;
                                            if(exit == 's'){
                                                salir();
                                            } else if(exit == 'n'){
                                                menu();
                                                Console.WriteLine("presione una tecla para continuar . . .");
                                                Console.ReadKey();
                                                salir();
                                            } 
                                        }
                                    }
                                 }   
                                ataque = Convert.ToInt32(Console.ReadLine());
                             }
                        break;
                    //case 2:
                        //  while(vidaBoss > 0){
                        //     // Console.WriteLine("bola de fuego quito -25 de vida al boss");
                        //     ataque = Convert.ToInt32(Console.ReadLine());
                        //     Console.WriteLine("bola de fuego quito -25 de vida al boss");
                        //     vidaBoss -= 25;
                        //     Console.WriteLine("la vida actual del boss es "+vidaBoss);
                        //     Charmander(ataque);
                            // vidaBoss = vidaBoss - 25;
                            // Console.WriteLine("la vida actual del boss es "+vidaBoss); 
                            
                        //} 
                      //  break;
                }
                // vidaBoss -= -10;
                // vidaBoss = vidaBoss - 10; 

            }
        }
        static void boulbasur(int ataque){
            Console.WriteLine("elija una habilidad");
            Console.WriteLine("1) [hoja afilada]");
            Console.WriteLine("2) [sequia de oxigeno]");
            int vidaBoss = 100;
            while(vidaBoss > 0){
                 ataque = Convert.ToInt32(Console.ReadLine());
                switch(ataque){
                    case 1:
                    for(int i = vidaBoss; i >= 0; i -= 10){
                        Console.WriteLine("hoja afilada le ha sacado -10 de vida al boss");
                        //  i = vidaBoss;
                        // i -= 10;
                        Console.WriteLine("la vida actual del boss es: " + i);
                            if(i <= 0){
                                Console.Clear();
                                Console.WriteLine("haz ganado");
                                Console.WriteLine("deseas salir?");
                                Console.WriteLine("S/n");
                                char exit = Console.ReadKey().KeyChar;
                                Console.Clear();
                                    if(exit == 's'){
                                        salir();
                                    } else if(exit == 'n'){
                                        menu();
                                        Console.WriteLine("presione una tecla para continuar . . .");
                                        Console.ReadKey();
                                        salir();
                                    } else {
                                        while(exit != 's' || exit != 'n'){
                                            Console.WriteLine("opcion no encontrada");
                                            Console.WriteLine("por favor ingresa una opcion correcta");
                                            exit = Console.ReadKey().KeyChar;
                                        }
                                    }
                        }
                        ataque = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case 2: //habilidad 2 de boul
                    for(int i = vidaBoss; i >= 0; i -= 25){
                    Console.WriteLine("sequia de oxigeno:  le ha sacado -25 de vida al boss");
                    Console.WriteLine("la vida actual del boss es: " + i);
                    Console.ReadKey();
                    Console.Clear();
                        if(i <= 0){
                            Console.WriteLine("haz ganado");
                            Console.WriteLine("deseas salir?");
                            Console.WriteLine("S/n");
                            char exit = Console.ReadKey().KeyChar;
                            Console.Clear();
                                if(exit == 's'){
                                    salir();
                                } else if(exit == 'n'){
                                    menu();
                                        Console.WriteLine("presione una tecla para continuar . . .");
                                        Console.ReadKey();
                                        salir();
                                } else {
                                    while(exit != 's' || exit != 'n'){
                                        Console.WriteLine("opcion no encontrada");
                                        Console.WriteLine("por favor ingresa una opcion correcta");
                                        exit = Console.ReadKey().KeyChar;
                                    }
                                }
                        }   
                        ataque = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                }
            }

        }
        static void squirtle(int ataque){
            Console.WriteLine("elija una habilidad");
            Console.WriteLine("1) [hidrobomba]");
            Console.WriteLine("2) [bola de agua]");
            int vidaBoss = 100;
            while(vidaBoss > 0){
                 ataque = Convert.ToInt32(Console.ReadLine());
                switch(ataque){
                    case 1:
                    for(int i = vidaBoss; i >= 0; i -= 10){
                        Console.WriteLine("hidrobomba le ha sacado -10 de vida al boss");
                        //  i = vidaBoss;
                        // i -= 10;
                        Console.WriteLine("la vida actual del boss es: " + i);
                            if(i <= 0){
                                Console.Clear();
                                Console.WriteLine("haz ganado");
                                Console.WriteLine("deseas salir?");
                                Console.WriteLine("S/n");
                                char exit = Console.ReadKey().KeyChar;
                                Console.Clear();
                                    if(exit == 's'){
                                        salir();
                                    } else if(exit == 'n'){
                                        menu();
                                        Console.WriteLine("presione una tecla para continuar . . .");
                                        Console.ReadKey();
                                        salir();
                                    } else {
                                        while(exit != 's' || exit != 'n'){
                                            Console.WriteLine("opcion no encontrada");
                                            Console.WriteLine("por favor ingresa una opcion correcta");
                                            exit = Console.ReadKey().KeyChar;
                                        }
                                    }
                        }
                        ataque = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case 2: // habilidad 2 de squirtle
                    for(int i = vidaBoss; i >= 0; i -= 25){
                    Console.WriteLine("bola de agua:  le ha sacado -25 de vida al boss");
                        //  i = vidaBoss;
                        // i -= 10;
                    Console.WriteLine("la vida actual del boss es: " + i);
                    Console.ReadKey();
                    Console.Clear();
                        if(i <= 0){
                            Console.WriteLine("haz ganado");
                            Console.WriteLine("deseas salir?");
                            Console.WriteLine("S/n");
                            char exit = Console.ReadKey().KeyChar;
                            Console.Clear();
                                if(exit == 's'){
                                    salir();
                                } else if(exit == 'n'){
                                    menu();
                                        Console.WriteLine("presione una tecla para continuar . . .");
                                        Console.ReadKey();
                                        salir();
                                } else {
                                    while(exit != 's' || exit != 'n'){
                                        Console.WriteLine("opcion no encontrada");
                                        Console.WriteLine("por favor ingresa una opcion correcta");
                                        exit = Console.ReadKey().KeyChar;
                                    }
                                }
                        }   
                        ataque = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                }
            }
        }
        static void pikachu(int ataque){
            Console.WriteLine("elija una habilidad");
            Console.WriteLine("1) [electricidad estatica]");
            Console.WriteLine("2) [tormenta electrica]");
            int vidaBoss = 100;
            while(vidaBoss > 0){
                 ataque = Convert.ToInt32(Console.ReadLine());
                switch(ataque){
                    case 1:
                    for(int i = vidaBoss; i >= 0; i -= 10){
                        Console.WriteLine("electricidad estatica: le ha sacado -10 de vida al boss");
                        //  i = vidaBoss;
                        // i -= 10;
                        Console.WriteLine("la vida actual del boss es: " + i);
                        Console.ReadKey();
                        Console.Clear();
                            if(i <= 0){
                                Console.WriteLine("haz ganado");
                                Console.WriteLine("deseas salir?");
                                Console.WriteLine("S/n");
                                char exit = Console.ReadKey().KeyChar;
                                Console.Clear();
                                if(exit == 's'){
                                    salir();
                                } else if(exit == 'n'){
                                    menu();
                                        Console.WriteLine("presione una tecla para continuar . . .");
                                        Console.ReadKey();
                                        salir();
                                } else {
                                    while(exit != 's' || exit != 'n'){
                                        Console.WriteLine("opcion no encontrada");
                                        Console.WriteLine("por favor ingresa una opcion correcta");
                                        exit = Console.ReadKey().KeyChar;
                                    }
                                }
                        }
                        ataque = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case 2:
                    for(int i = vidaBoss; i >= 0; i -= 25){
                    Console.WriteLine("tormenta electrica: le ha sacado -25 de vida al boss");
                        //  i = vidaBoss;
                        // i -= 10;
                    Console.WriteLine("la vida actual del boss es: " + i);
                    Console.ReadKey();
                    Console.Clear();
                        if(i <= 0){
                            Console.WriteLine("haz ganado");
                            Console.WriteLine("deseas salir?");
                            Console.WriteLine("S/n");
                            char exit = Console.ReadKey().KeyChar;
                            Console.Clear();
                                if(exit == 's'){
                                    salir();
                                } else if(exit == 'n'){
                                    menu();
                                        Console.WriteLine("presione una tecla para continuar . . .");
                                        Console.ReadKey();
                                        salir();
                                } else {
                                    while(exit != 's' || exit != 'n'){
                                        Console.WriteLine("opcion no encontrada");
                                        Console.WriteLine("por favor ingresa una opcion correcta");
                                        exit = Console.ReadKey().KeyChar;
                                    }
                                }
                        }   
                        ataque = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                }
            }
        }
        static void salir(){
            Console.WriteLine("ADIOS . . .");
            Environment.Exit(0);
        }
    }
}
