/*
pedir la edad de un usuario y validar si es mayor o menor de edad, si es mayor a 18, es mayor de edad y si no, es menor de edad.
*/
/*
int edad;

Console.WriteLine("que edad tienes");

edad = Convert.ToInt32(Console.ReadLine());

if(edad >=18){ // dandole la condicion a cumplir si es verdadera
    Console.WriteLine("eres mayor de edad");
} else{
    Console.WriteLine("eres menor de edad"); // si es falsa hara esto
} */

//segundo ejercicio
/*
hacer un porgrama que pida dos veces  una contraseña, si las dos contraseñas son iguales,
 mostrar un mensaje diciendo que la contraseña es valida, en el caso contrario, mostrar que la contraseña es incorrecta
*/
/*
Console.WriteLine("escriba una contraseña");
var password = Console.ReadLine();
Console.WriteLine("confirme la contraseña");
var passwordConfirm = Console.ReadLine();



if(password == passwordConfirm){
    Console.WriteLine("la contraseña es correcta");
    Console.WriteLine("bienvenido a ITLA virtual");
} else{
    Console.WriteLine("contraseña incorrecta");
    Console.WriteLine("ingrese otra vez la contraseña");
}*/

//3er ejercicicio
/*
realizar un programa que lea por teclado dos numeros.
 si el primero es mayor que el segundo, mostrar la suma y la resta de esos numeros,
  en caso contrario, mostrar la multiplicacion y division, y si son iguales, un mensaje que diga los numeros son iguales
*/

int primerNumero, segundoNumero;

Console.WriteLine("ingrese un numero");
primerNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese otro numero");
segundoNumero = Convert.ToInt32(Console.ReadLine());

// las operaciones para las condiciones 
 int totalSuma = primerNumero + segundoNumero;
 int totalResta = primerNumero - segundoNumero;
  int totalMulti = primerNumero * segundoNumero;
   int totalDiv = primerNumero / segundoNumero;
// las operaciones para las condiciones


if(primerNumero > segundoNumero){ //si la condicion es verdadera
    Console.WriteLine($"la suma de {primerNumero} y {segundoNumero} es {totalSuma}");
    Console.WriteLine($"la resta de {primerNumero} y {segundoNumero} es {totalResta}");

} else if(primerNumero == segundoNumero){ // condicion alternativa: si los numeros son iguales
    Console.WriteLine("los numeros son iguales");
} else{ //si la condicion es falsa
    Console.WriteLine($"la multilicacion de {primerNumero} y {segundoNumero} es {totalMulti}");
    Console.WriteLine($"la division de {primerNumero} y {segundoNumero} es {totalDiv}");}
