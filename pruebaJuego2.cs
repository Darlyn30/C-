//esta es una prueba de un juego

//el juego se trata de un juego de rol basado en selecciones(condiciones)
//var danoBoss = "2 HP";
int vidaBoss = 15;
int ataqueMago;
Console.WriteLine(@"Bienvenidos a Dungeon Earth Survival
que personaje quieres
1er personaje: 
mago
==================
2do personaje: 
guerrero
==================
elige tu personaje: ");


var personajeSelect = Console.ReadLine();

if(personajeSelect == "mago"){
    Console.WriteLine(@"Haz escogido al Mago
    Este cuenta con 15 HP
    3 de da;o con cada golpe");
} else if(personajeSelect == "guerrero"){
    Console.WriteLine(@"Haz escogido al guerrero
    Este cuenta con 17 HP
    2 de da;o con cada golpe");
} else{}

//pelea

Console.WriteLine(@"Te haz encontrado al jefe final
escoge una habilidad");

if(personajeSelect == "mago"){
Console.WriteLine(@"1) bola de fuego
2) circulo de fuego");
             ataqueMago = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(@"bola de fuego
le haz hecho 3 de da;o al jefe final");
for(var i = ataqueMago; vidaBoss <= 0; i--){
    Console.WriteLine(i);
}
} else if(personajeSelect == "guerrero"){
Console.WriteLine(@"1) ataque con la espada
2) golpe critico");
var ataqueGuerrero = Console.ReadLine();

Console.WriteLine(@"bola de fuego");


}else{}



//boss 

