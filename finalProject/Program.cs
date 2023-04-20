using System;
namespace projectoFinal {
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Bienvenido a nuestro programa \n");
            Console.WriteLine("Presione la tecla 'a' para continuar . . .");
            char brand = Console.ReadKey().KeyChar;
            Console.Clear(); // aqui borra la consola y manda el menu o mensaje de error
            if(brand == 'a'){
                //Console.Clear();
                menu();
            } else{
                while(brand != 'a'){
                    Console.WriteLine("Error!\n");
                    Console.WriteLine("Presione la tecla 'a' para continuar . . .");
                    brand = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if(brand == 'a'){
                       // Console.Clear();
                        menu();
                    }
                }
            }
        }
        static void menu(){ // menu que se lanza
            Console.Clear();
            Console.WriteLine("\x1B[0;32m***********MENU***********\x1B[0;37m\n");
            Console.WriteLine("Que deseas hacer: \n");
            Console.WriteLine("1) [Contactos]");
            Console.WriteLine("2) [Eventos]");
            Console.WriteLine("3) [Utiliarios]");
            Console.WriteLine("4) [Salir]\n\n");
            Console.WriteLine("[elige una opcion]\n");
            Console.WriteLine("\x1B[0;32m***********MENU***********\x1B[0;37m\n");
            int elegir = Convert.ToInt32(Console.ReadLine());
            // if(elegir == 1){
            //     contacto(elegir);
            // }
            switch(elegir){ // casos para acceder al menu de arriba
                case 1:
                    contacto(elegir);
                    break;
                case 2:
                    evento(elegir);
                    break;
            }
        }
        static void contacto(int elegir){
            Console.Clear();
            Console.WriteLine("Estas en contacto: \n");
            Console.WriteLine("que deseas hacer: \n");
            Console.WriteLine("1) [Crear contacto]");
            Console.WriteLine("2) [Editar contacto]");
            Console.WriteLine("3) [Borrar contacto]");
            Console.WriteLine("4) [Buscar contacto]");
            Console.WriteLine("4) [Mostrar contactos]");
            Console.WriteLine("5) [Volver al menu principal]");
            Console.WriteLine("5) [Salir]");
            int menuContacto = Convert.ToInt32(Console.ReadLine());
            switch(menuContacto){
                case 1:
                    crearContacto(menuContacto);
                    break;
                case 2:
                    editarContacto(menuContacto);
                    break;
                case 3:
                    borrarContacto(menuContacto);
                    break;
                case 4:
                    mostrarContacto(menuContacto);
                    break;
                case 5:
                    menu();
                    break;
                case 6:
                    salir();
                    break;
            }
        }
        static void crearContacto(int menuContacto){
            Console.Clear();
            Console.Write("Crear contacto: \n");
            Console.Write("Nombre: ");
            string? nom = Console.ReadLine();
            Console.Write("Apellido: ");
            string? last = Console.ReadLine();
            Console.Write("Telefono: ");
            string? tel = Console.ReadLine();
            Console.Write("Direccion: ");
            string? adress = Console.ReadLine();
            Console.Write("Email: ");
            string? mail = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 's' para guardar");
            char save = Console.ReadKey().KeyChar;
            if(save == 's'){
                Console.WriteLine("Contacto guardado correctamente! \n");
                Console.WriteLine("Presiona cualquier tecla para continuar . . .");
                Console.ReadKey();
                Console.Clear();
                menu();
            } else {
                while(save != 's'){
                Console.WriteLine("No se ha podido guardar el contacto \n");
                Console.WriteLine("Presiona cualquier tecla para continuar . . .");
                Console.ReadKey();
                Console.Clear();
                menu();
                }
            }
        }
        static void editarContacto(int menuContacto){
            Console.Clear();
            Console.WriteLine("Editar: \n");
            Console.WriteLine("Que desea editar? \n");
            Console.WriteLine("1) [Nombre]");
            Console.WriteLine("2) [Apellido]");
            Console.WriteLine("3) [Telefono]");
            Console.WriteLine("4) [Direccion]");
            Console.WriteLine("5) [Email]");
            Console.WriteLine("6) [Volver]");
            int menuEditar = Convert.ToInt32(Console.ReadLine());
        }
        static void borrarContacto(int menuContacto){
            Console.Clear();
            Console.WriteLine("Borrar contacto: \n");
            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
            Console.WriteLine("");
            mostrarContacto(menuContacto);
        }
        static void mostrarContacto(int menuContacto){}
        static void evento(int elegir){
            Console.WriteLine("Estas en eventos: \n");
            Console.WriteLine("que deseas hacer: \n");
            Console.WriteLine("1) [Crear evento]");
            Console.WriteLine("2) [Editar evento]");
            Console.WriteLine("3) [Borrar evento]");
            Console.WriteLine("4) [Buscar evento]");
            Console.WriteLine("5) [Mostrar eventos]");
            Console.WriteLine("6) [Volver al menu principal]");
            Console.WriteLine("7) [Salir]");
            int menuEvento = Convert.ToInt32(Console.ReadLine());
            switch(menuEvento){
                case 1:
                    crearEvento(menuEvento, elegir);
                    break;
                case 2:
                    editarEvento(menuEvento);
                    break;
                case 3: 
                    borrarEvento(menuEvento);
                    break;
                case 4:
                    buscarEvento(menuEvento);
                    break;
                case 5:
                    mostrarEvento(menuEvento);
                    break;
                case 6:
                    menu();
                    break;
                case 7:
                    salir();
                    break;  
            }
        }
        static void crearEvento(int menuEvento, int elegir){
            Console.Clear();
            Console.WriteLine("Crear evento: \n");
            Console.Write("Nombre de evento: ");
            string? nomEvent = Console.ReadLine();
            Console.Write("Fecha de evento: ");
            string? dateTime = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 's' para guardar . . .");
            char save = Console.ReadKey().KeyChar;
            if(save == 's'){
                Console.Clear();
                Console.WriteLine("EVENTO GUARDADO CORRECTAMENTE!\n");
                Console.WriteLine("Presione cualquier tecla para volver atras . . .");
                Console.Clear();
                evento(elegir);
            } else {
                while(save != 's'){
                Console.WriteLine("No se ha podido guardar el evento \n");
                Console.WriteLine("Presiona cualquier tecla para continuar . . .");
                Console.ReadKey();
                Console.Clear();
                evento(elegir);
                }
            }

        }
        static void editarEvento(int menuEvento){
            Console.WriteLine("Que evento vas a editar? \n");
            buscarEvento(menuEvento);
        }
        static void borrarEvento(int menuEvento){
            mostrarEvento(menuEvento);
        }
        static void buscarEvento(int menuEvento){}
        static void mostrarEvento(int menuEvento){}
        static void salir(){ //falta animacion de salida
            Console.WriteLine("ADIOS . . .");
            Environment.Exit(0);
        }

    }
}
