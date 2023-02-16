/*
Escribir un programa que pregunte al usuario su nombre, y luego lo salude.
*/

Console.WriteLine("hola, ingrese su nombre");
var nom = Console.ReadLine();

Console.WriteLine($"hola, bienvenido {nom}");


//Calcular el perímetro y área (son dos cálculos diferentes) de un rectángulo, recibiendo por parte del usuario
//la base y la altura.


Console.WriteLine("ingrese el valor del perimetro: ");
var per =Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"el permitero es: {per}");

Console.WriteLine("ingrese el valor del area: ");
 var area = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine($"el area es: {area}");

Console.WriteLine($"el perimetro del triangulo es {per}, y el area del triangulo es {area}");


/*
Dados dos números ingresados por el usuario, mostrar la suma, resta, división y multiplicación de ambos.
*/

Console.WriteLine("ingrese un numero: ");
var numero1 = Console.ReadLine();

Console.WriteLine("ingrese otro numero");
var numero2 = Console.ReadLine();

//suma 

var totalSuma = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);

Console.WriteLine($"la suma de {numero1} y {numero2} es: ");
Console.WriteLine(totalSuma);

//resta
var totalResta = Convert.ToInt32(numero1)  - Convert.ToInt32(numero2);

Console.WriteLine($"la resta de {numero1} y {numero2} es: ");
Console.WriteLine(totalResta);

//multiplicacion

var totalMult = Convert.ToInt32(numero1) * Convert.ToInt32(numero2);

Console.WriteLine($"la multiplicacion de {numero1} y {numero2} es: ");
Console.WriteLine(totalMult);

//division
var totalDiv = Convert.ToDouble(numero1) / Convert.ToInt32(numero2);

Console.WriteLine($"la division de {numero1} y {numero2} es: ");
Console.WriteLine(totalDiv);


/*
Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.
 El valor lo debe introducir el usuario.
*/

Console.WriteLine("cual es la temperatura?: ");

var grado = Console.ReadLine();

var convertCelcius = Convert.ToDouble(grado);

var c = convertCelcius;

var converToCel = c -32;

var celConverted = Convert.ToDouble(converToCel);

Console.WriteLine($"la temperatura F° es {c}, y convertida a C° " );

Console.WriteLine(celConverted/1.8);


/*
Calcular la media (promedio) de tres números pedidos por teclado
*/

Console.WriteLine($"dame 3 numeros  {nom}");
var num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("el 2do?");
var num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("el ultimo");
var num3 = Convert.ToDouble(Console.ReadLine());

var totalNumSuma = num1 + num2 + num3;

Console.WriteLine("la media es " + totalNumSuma/8);



/*
Realiza un programa que reciba una cantidad de minutos y muestre por pantalla
 a cuantas horas y minutos corresponde. ejemplo: 1000 minutos, 16h y 40min
 */

Console.WriteLine("ingrese la cantidad de minutos: ");
var minutos  = Convert.ToInt32(Console.ReadLine());

int convertTime = minutos / 60;

int changeTime =  convertTime *60;
int changeHour = minutos - changeTime;

Console.WriteLine($"el resultado de {minutos} es {convertTime} horas y {changeHour} minutos");


/*
Un vendedor recibe un sueldo base mas un 10% extra por comisión de sus ventas. 
El desea saber cuanto recibirá a fin de mes por concepto de comisión y por concepto de salario total.
 Debe ingresar el salario del vendedor, monto vendido, realizar el calculo y mostrar los resultados.

*/
Console.WriteLine("cual es el sueldo de " + nom);
var sueldoBase = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"cuanto vendio {nom} este mes? ");
var montoVenta = Convert.ToDouble(Console.ReadLine());

var extra = Convert.ToDouble(10*sueldoBase);
var montoExtra = extra/100;
var cobroExtra = Convert.ToDouble(montoExtra + sueldoBase);

Console.WriteLine($"el monto vendido es de {montoVenta} y {nom} cobrara este mes {cobroExtra}");


/*
Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber
 cuanto deberá pagar finalmente por su compra. Ingresar el monto de la compra y mostrar los resultados.
*/
Console.WriteLine("total de la compra: ");

var totalCompra = Convert.ToInt32(Console.ReadLine());

var descuento = Convert.ToDouble(totalCompra*10);
var descuentoTotal = Convert.ToDouble(descuento/100);

var totalPagar = Convert.ToDouble(totalCompra - descuentoTotal);

Console.WriteLine($"el cliente debera pagar {totalPagar} con el descuento del 10% aplicado");


/*
Pide al usuario dos números y muestra la “distancia” entre ellos 
(el valor absoluto de su diferencia, de modo que el resultado sea siempre positivo).
*/


Console.WriteLine("ingrese un numero:");
var dato1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el 2do numero");
var dato2 = Convert.ToInt32(Console.ReadLine());




Console.WriteLine("el camino es");
for(var i = dato1; i <= dato2; i++){
    Console.WriteLine(i);

 
} 






/*
Programa que lea un número y que muestre su raíz cuadrada y su raíz cúbica. 
*/


Console.WriteLine("ingrese el numero para buscar raiz");
var numero = Convert.ToDouble(Console.ReadLine());

var raices = Math.Pow(numero,1.0/3.0);
var raizCuadrada = Math.Sqrt(numero);
Console.WriteLine($"valor de raiz cubica es {raices} y la raiz cuadrada es {raizCuadrada}");


/*
Dado un número de dos cifras, diseñe un algoritmo que permita obtener el número invertido.
 Ejemplo, si se introduce 23 que muestre 32.
*/
Console.WriteLine("invierte este numero");
int numeroIngresar;
int numeroInverso;
numeroIngresar = Convert.ToInt32(Console.ReadLine());



do{
    numeroInverso = numeroIngresar % 10;
    Console.Write(numeroInverso);
    numeroIngresar = numeroIngresar / 10;
} while(numeroIngresar > 0);

Console.WriteLine();



/*
Dadas dos variables numéricas A y B, que el usuario debe teclear,
 intercambie los valores de ambas variables y muestre cuanto valen al final las dos variables.
*/


Console.WriteLine("este programa cambia los valores de las variables de lugar, cae un valor en el otro");

var a = Console.ReadLine();
var b = Console.ReadLine();

var aux = a;
a = b;
b = aux;

Console.WriteLine($"el valor del primer dato es {a}");
Console.WriteLine($"el valor del segundo dato es {b}");


/*
Pedir el nombre y los dos apellidos de una persona y mostrar las iniciales.
*/

Console.WriteLine("ingresar tu nombre: ");
var nombre = Console.ReadLine();
Console.WriteLine("ingresar tu apellido");
var apellido = Console.ReadLine();

var iniciales = nombre?.Substring(0,1) +" "  + apellido?.Substring(0,1);

Console.WriteLine($"las iniciales del nombre y apellido son ({iniciales})");

