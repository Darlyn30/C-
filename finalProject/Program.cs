using System;
namespace finalProject {
    class Program{
        static void Main(string[] args){
            Console.WriteLine("BIENVENIDO A NUESTRO PROGRAMA\n");
            Console.WriteLine("Presiona 's' para mostrar el menu");
           char mostrar =  Console.ReadKey().KeyChar;
           Console.Clear();
            if(mostrar == 's'){
                menu();
            } else {
                while(mostrar != 's'){
                    Console.WriteLine("Opcion no encontrada");
                    Console.WriteLine("Presiona 's para mostrar el menu'");
                    mostrar = Console.ReadKey().KeyChar;
                    Console.Clear();
                    menu();
                }
            }
        }
        static void menu(){
            Console.WriteLine("Donde desea acceder: \n");
            Console.WriteLine("1) [Contacto]");
            Console.WriteLine("2) [eventos]");
            Console.WriteLine("3) [utiliarios]\n\n\n\n");
            Console.WriteLine("Mostrar info de cada segmento [Presiona '1']");
            int opt = Convert.ToInt32(Console.ReadLine());
            if(opt == 1){
                info(opt);
            }
        }
        static void info(int opt){
            switch(opt){
                case 1:
                    Console.Clear();
                    Console.WriteLine("contacto: aqui podras a?adir, editar, leer, y borrar contacto");
                    Console.WriteLine("Eventos: ........................................... eventos");
                    Console.WriteLine("Utiliarios : aqui podras usar: calculadora, conversor de grados, conversor de monedas");
                    break;
                default :
                    while(opt != 1){
                        menu();
                    }
                    break;
                
            }
        }
    }
}
