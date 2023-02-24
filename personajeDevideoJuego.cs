 
 
 
 
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


