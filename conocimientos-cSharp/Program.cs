using System;
namespace conocimientos {
    class Program {
        static void Main(string[] args){
            // aqui voy a estar poniendo en practica mis conocimientos de cSharp en 4 meses
            // estare haciendo un programa "complicado"
            // el programa debe tener, ciclos, variables, funciones, metodos de entrada, metodos de salida
            // sera un mini juego de consola
            // jugar();
            // aqui estare colocando mas de lo que hay en aprender.cs en el main del repo

            /*
            hacer un array y que introduzca 10 numeros e identifique si son negativos o positivos
            */
            int [] num = new int[10];
            for(int i = 0; i <= num.Length; i++){
                Console.WriteLine("ingrese un numero");
                int numero  = Convert.ToInt32(Console.ReadLine());
                if(num[i] > 1){
                    Console.WriteLine("el numero introducido es positivo");
                } else if(num[i] < 0){
                    Console.WriteLine("el numero introducido es negativo");
                } else {
                    Console.WriteLine("el numero es neutro");
                }
            }
            for(int i = 0; i <= num.Length; i++){
                if(num[i] > 1){
                    Console.WriteLine($"{num[i]} positivo");
                } else if(num[i] < 0){
                    Console.WriteLine($"{num[i]} negativo");
                } else if(num[i] == 0){
                    Console.WriteLine($"{num[i]} neutro");
                }
                // Console.WriteLine(num.Contains(i));
            }
        }
    }
}