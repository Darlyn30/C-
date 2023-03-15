/*
PROGRAMA QUE LE PIDA AL USUARIO 5 NÚMEROS Y LOS ALMACENE EN UN ARREGLO. CUANDO EL USUARIO TERMINE DE INGRESARLOS  DEBE MOSTRAR LA SUMATORIA DE ESOS NÚMERO
*/

using System;
namespace arrays{
    class Program {
        static void Main(string[] args){
            //creacion del array(arreglo)
            int[] numeros = new int[5];
            
            // ciclo para ingresar los numeros
            for(int i = 0; i<numeros.Length; i++ ){
                Console.WriteLine("ingrese un numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());  
            }       
            for(int i = 0; i<numeros.Length; i++){
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("\n");
            // la suma de todos los numeros ingresados
             int sumaTodo = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4];
             Console.WriteLine("la suma de todos los numeros es: ");
             Console.WriteLine(sumaTodo);
        }
    }
}
