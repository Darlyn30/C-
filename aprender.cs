
/*aqui estare anotando todo lo que vamos aprendiendo de c# 
 
 c# es muy parecido a JS 

 por ejemplo, las variables se llaman de igual forma solo que utilizando var(variable)
estoy utilizando visual studio porque es mas oara c#
en el code hay que hacer unas cuantas cosas para hacer un console program en #*/

// variables

var nombre = "darlyn";
var apellido = "olivo"; //solo se pueden utilizar comillas dobles en c# a no ser que sea de un tipo "CHAR" que es un caracter, ahi si se usa comilla simple

Console.WriteLine("hola cual es su nombre"); //esto es un "console.log" de JS para que te imprima por consola
Console.WriteLine(nombre); //esta linea me mostrara por consola el valor de la variable

Console.WriteLine("cual es su apellido");
Console.WriteLine(apellido);
Console.WriteLine("su nombre es: " + nombre + apellido);

// este programa me mostrara por consola los valores de la variable nombre y apellido

//todo este proceso se puede simplicar de la siguiente forma
// comentare todo el programa para que no salga tan larga la consola

//hacer un programa que solicite nombre y apellido y los muestre con un saludo



Console.WriteLine("ingrese su nombre");
var name = Console.ReadLine();
Console.WriteLine("ingrese su apellido");
var surName = Console.ReadLine();
Console.WriteLine("hola bienvenido: " + name + " " + surName); //coloque esas comillas para que haya un espacio entre las 2 variables cuando lo muestre a la consola


//condicionales

// como en todos los lenguajes de programacion estan las condicionales if, else if, else, acompañadas de parentesis() y llaves{}
// en los parentesis va la condicion a probar y en las llaves va el camino para ver cual es el resultado

//                   example: 

// hacer un programa que solicite password, y si es incorrecta mandar un mensaje de error


Console.WriteLine("ingrese la contraseña");
var pass = Console.ReadLine();

if(pass == "darlyn123" ) {

   Console.WriteLine ("Bienvenido ITLA Virtual");
} else{
	Console.WriteLine("error");
}

// como llamar funciones en c#
// las funcioes se declaran distinto a js, aqui no es con la reserva function sino con la reserva "static void<function Name>(){}"
//algunas veces es necesario que usas parametros dentro de las funciones y estos se ponen en el parentesis, estos parametros son 
// por ejemplo variables declaradas pero no inicializada
static void jugar(){
   console.WriteLine("hola, soy una funcion");
} 