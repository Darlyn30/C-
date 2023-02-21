
 
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
    while(bossHealth >= 0){

        Console.WriteLine(bossHealth - 30);
        //bossHealth = 0;
    }
//  while(VIDA != 0) {
//      VIDA = VIDA - 30; 
//      Console.WriteLine(VIDA-30);
//      VIDA = 0;
}
 else{}

if (bossHealth == 0){
    Console.WriteLine("se termino el juego: gracias por jugar");
} else{}

// for(var i = bossHealth; i <=0; i-- ){
//     Console.WriteLine("la vida actual del boss final es " +bossHealth + "/270");
   
// }



// while(JUGADOR == bossHealth){
//     bossHealth = bossHealth-30;
//     Console.WriteLine(bossHealth);
// }
