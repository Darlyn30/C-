//esta es una prueba de un juego


Console.WriteLine("BIENVENIDO A DUNGEON LIFE");
Console.WriteLine("selecciona tu personaje");

Console.WriteLine("1er personaje");
Console.WriteLine("guerrero"); // clase personaje1

Console.WriteLine("==============");
Console.WriteLine("2do personaje");
Console.WriteLine("mago"); // clase personaje2

Console.WriteLine("===============");
Console.WriteLine("3er personaje");
Console.WriteLine("curandero"); // clase personaje3

Console.WriteLine("selecciona tu personaje");
var personajeSeleccionado = Console.ReadLine();

if(personajeSeleccionado == "mago") {
    Console.WriteLine("seleccionaste MAGO"); // seleccion personaje2
Console.WriteLine("12 HP, 4 da;o golpe basico"); // info personaje2
} else if(personajeSeleccionado == "guerrero"){
    Console.WriteLine("seleccionaste GUERRERO"); // seleccion personaje1
Console.WriteLine("15 HP, 3 da;o golpe basico"); // info de personaje1
} else if(personajeSeleccionado == "curandero"){
    Console.WriteLine("seleccionaste CURANDERO"); // seleccion personaje3
Console.WriteLine("20 HP 1 da;o golpe basico"); // info personaje3
} else{}


if(personajeSeleccionado == "guerrero"){
    Console.WriteLine("guerrero habilidades");
Console.WriteLine("a golpe basico");
Console.WriteLine("b golpe critico");

} else if(personajeSeleccionado == "mago"){
    Console.WriteLine("mago habilidades");
    Console.WriteLine("a golpe basico");
    Console.WriteLine("b golpe critico");

} else if(personajeSeleccionado == "curandero"){
    Console.WriteLine("curandero habilidades");
    Console.WriteLine("a golpe basico");
} else{}

//habilidades

string? mago, guerrero, curandero;




mago = Console.ReadLine();




if(mago == "a"){
    Console.WriteLine("has elegido 'a' le quita 4 de da;o al boss");
    Console.WriteLine("el boss tira un ataque y deja al mago 10/12 HP");
} else if( mago == "b"){
    Console.WriteLine("has elegido 'b' le quita 8 de da;o al boss");
    Console.WriteLine("el boss tira un ataque y deja al mago 10/12 HP");
} else{}
    guerrero = Console.ReadLine();
if(guerrero == "a"){
     Console.WriteLine("has elegido 'a' le quita 3 de da;o al boss");
    Console.WriteLine("el boss tira un ataque y deja al guerrero 13/15 HP");
} else if(guerrero == "b"){
    Console.WriteLine("has elegido 'a' le quita 5 de da;o al boss");
    Console.WriteLine("el boss tira un ataque y deja al guerrero 13/15 HP");
} else{}
    curandero = Console.ReadLine();
if(curandero == "a"){
    Console.WriteLine("has elegido 'a' le quita 1 de da;o al boss");
     Console.WriteLine("el boss tira un ataque y deja al guerrero 17/20 HP");
}




//final BOSS



Console.WriteLine("Final Boss");
var bossHealth = Convert.ToInt32(30 + "HP");

//boss vs mago
if(mago == "a"){
    bossHealth = bossHealth - 3;
    
} else if(mago == "b"){
    bossHealth = bossHealth - 8;
    Console.WriteLine($"la vida del boss es {bossHealth} HP");
} else{}

// boss vs guerrero

if(guerrero == "a"){
    bossHealth = bossHealth - 3;
    Console.WriteLine($"la vida del boss es {bossHealth} HP");
} else if(guerrero == "b"){
    bossHealth = bossHealth - 5;
    Console.WriteLine($"la vida del boss es {bossHealth} HP");
} else{}

// boss vs curandero

if(curandero == "a"){
     bossHealth = bossHealth - 1;
    Console.WriteLine($"la vida del boss es {bossHealth} HP");
} else{}




while(personajeSeleccionado == "mago"){
    if(mago == "a"){
    bossHealth = bossHealth - 3;
    
} else if(mago == "b"){
    bossHealth = bossHealth - 8;
    Console.WriteLine($"la vida del boss es {bossHealth} HP");
} else{}
}


while(personajeSeleccionado == "guerrero"){
    if(guerrero == "a"){
    bossHealth = bossHealth - 3;
    Console.WriteLine($"la vida del boss es {bossHealth} HP");
} else if(guerrero == "b"){
    bossHealth = bossHealth - 5;
    Console.WriteLine($"la vida del boss es {bossHealth} HP");
} else{}

}


while(personajeSeleccionado == "curandero"){
    if(curandero == "a"){
     bossHealth = bossHealth - 1;
    Console.WriteLine($"la vida del boss es {bossHealth} HP");
} else{}
}


