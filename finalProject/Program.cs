using System;
namespace final {
    class Program {
        static void Main(string [] args){
            // your code here!!
            Console.WriteLine("BIENVENIDO A NUESTRO PROGRAMA\n");
            Console.WriteLine("presione cualquier tecla para continuar . . .");
            Console.ReadKey();
            Console.Clear();
            menu();
            int opt = Convert.ToInt32(Console.ReadLine());
            while(opt > 3 || opt < 1){
                Console.WriteLine("Opcion no disponible");
                Console.WriteLine("Elija nuevamente");
                opt = Convert.ToInt32(Console.ReadLine());
            }
            menuContactos(opt);
        }
        static void menu(){
            Console.WriteLine("\x1B[0;32m********MENU********\x1B[0;37m\n");
            Console.WriteLine("Donde desea acceder\n");
            Console.WriteLine("1) [Contactos]");
            Console.WriteLine("2) [Eventos]");
            Console.WriteLine("3) [Utiliarios]\n");
            Console.WriteLine("\x1B[0;32m********MENU********\x1B[0;37m\n");
        }
        static void menuContactos(int opt){
            switch(opt){
                case 1:
                Console.Clear();
                    Console.WriteLine("\x1B[0;32m********MENU DE CONTACTOS********\x1B[0;37m\n");
                    Console.WriteLine("Que desea hacer: \n");
                    Console.WriteLine("1) [Agregar contacto]");
                    Console.WriteLine("2) [actualizar contacto]");
                    Console.WriteLine("3) [Borrar contacto]");
                    Console.WriteLine("4) [Mostrar todos los contactos]");
                    Console.WriteLine("5) [Buscar contacto]");
                    Console.WriteLine("6) [Salir]\n");
                    Console.WriteLine("\x1B[0;32m********MENU DE CONTACTOS********\x1B[0;37m\n");
                    int opt1 = Convert.ToInt32(Console.ReadLine());
                    agregarContactos(opt1, opt);
                    break;
            }
        }
        static void menuEventos(int opt){
            switch(opt){
                case 2:
                    Console.Clear();
                    Console.WriteLine("[0;32m********MENU DE EVENTOS********\x1B[0;37m\n");
                    Console.WriteLine("Que deseas hacer: \n");
                    Console.WriteLine("1) [Agregar eventos]");
                    Console.WriteLine("2 [Editar eventos]");
                    Console.WriteLine("3 [Borrar evento]");
                    Console.WriteLine("4 [Mostrar todos los eventos a?adidos]");
                    Console.WriteLine("5 [Buscar eventos]");
                    Console.WriteLine("6 [Salir]\n");

                    Console.WriteLine("[0;32m********MENU DE EVENTOS********\x1B[0;37m\n");
                    break;
            }
        }
        static void agregarContactos(int opt1, int opt){
            // while(opt1 < 1 || opt1 > 6){
            //     Console.WriteLine("Opcion no disponible");
            //     Console.WriteLine("Presione cualquier tecla para continuar . . .");
            //     Console.Clear();
            //     Console.ReadKey();
            //     menuContactos(opt);
           // }
            switch(opt1){
                case 1:
                    Console.WriteLine("\x1B[0;32m********AGREGAR CONTACTOS********\x1B[0;37m\n");
                    Console.WriteLine("Nombre: ");
                    string? nom = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    string? lastName = Console.ReadLine();
                    Console.WriteLine("Numero de telefono: ");
                    int tel = Convert.ToInt32(Console.ReadLine());
                    while(tel < 1 || tel > 999999999){
                        Console.WriteLine("Ingrese un numero de telefono real");
                        Console.WriteLine("El numero excede el limite de digitos que son 9");
                        tel = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Email: ");
                    string? email = Console.ReadLine();
                    Console.WriteLine("Direccion: ");
                    string? adress = Console.ReadLine();
                    Console.WriteLine("\nPresione 'e' para guardar contacto\n");
                    char guardar = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if(guardar == 'e'){
                        Console.WriteLine("Contacto guardado exitosamente!\n");
                    }
                    Console.WriteLine("Presiona 'c' para volver al menu de contacto\n");
                    Console.WriteLine("Presiona 'g' para volver al menu principal");
                    char volver = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if(volver == 'c'){
                        menuContactos(opt);
                    } else if(volver == 'g'){
                        Console.Clear();
                        menu();
                    } else {
                        while(volver != 'g' || volver != 'c'){
                            Console.WriteLine("No se ha encontrado la opcion elegida");
                            Console.WriteLine("Presione 'c'  o 'g' para volver atras");
                            volver = Console.ReadKey().KeyChar;
                            if(volver == 'c'){
                                menuContactos(opt);
                                
                            } else if(volver == 'g'){
                                menu();
                               // menuContactos(opt);
                                // agregarContactos(opt, opt1);
                                // editarContacto(opt, opt1, nom, lastName, tel, adress, email, volver);

                            }
                        }
                    }
                    break;
            }
        }
        static void editarContacto(int opt, int opt1, string? nom, string? lastName, int tel, string? adress, string? email, char volver){
            switch(opt1){
                case 2:
                    Console.WriteLine("\x1B[0;32m********EDITAR CONTACTOS********\x1B[0;37m\n");
                    Console.WriteLine("Que desea editar: \n");
                    Console.WriteLine("1) Nombre: ");
                    Console.WriteLine("2) Apellido: ");
                    Console.WriteLine("3) Numero de telefono: ");
                    Console.WriteLine("4) Email: ");
                    Console.WriteLine("5) Direccion: ");
                    int editar = Convert.ToInt32(Console.ReadLine());
                    switch(editar){
                        case 1:
                            Console.WriteLine("Nombre");
                            Console.WriteLine("ingrese nuevo nombre");
                            nom = Console.ReadLine();
                            Console.WriteLine("Presiona 'e' para guardar");
                            char guardar = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(guardar == 'e'){
                                Console.WriteLine("Contacto actualizado con exito!");
                            }
                            Console.WriteLine("Presiona 'c' para volver al menu de contacto");
                            Console.WriteLine("Presiona 'g' para volver al menu principal");
                            Console.WriteLine("Presiona 'w' para seguir editando un contacto");
                            volver = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(volver == 'c'){
                                menuContactos(opt);
                            } else if(volver == 'g'){
                                menu();
                            } else if(volver == 'w'){
                                seguirEditando(opt, opt1, nom, lastName, tel, adress, email, volver);
                            }
                            break;
                            case 2:
                            Console.WriteLine("Apellido");
                            Console.WriteLine("ingrese nuevo apellido");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Presiona 'e' para guardar");
                            guardar = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(guardar == 'e'){
                                Console.WriteLine("Contacto actualizado con exito!");
                            }
                            Console.WriteLine("Presiona 'c' para volver al menu de contacto");
                            Console.WriteLine("Presiona 'g' para volver al menu principal");
                            Console.WriteLine("Presiona 'w' para seguir editando un contacto");
                            volver = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(volver == 'c'){
                                menuContactos(opt);
                            } else if(volver == 'g'){
                                menu();
                            } else if(volver == 'w'){
                                seguirEditando(opt, opt1, nom, lastName, tel, adress, email, volver);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Telefono");
                            Console.WriteLine("ingrese nuevo telefono");
                            tel = Convert.ToInt32(Console.ReadLine());
                            while(tel < 1 || tel > 999999999){
                                Console.WriteLine("Ingrese un numero de telefono real");
                                Console.WriteLine("El numero excede el limite de digitos que son 9");
                                tel = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Presiona 'e' para guardar");
                            guardar = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(guardar == 'e'){
                                Console.WriteLine("Contacto actualizado con exito!");
                            }
                            Console.WriteLine("Presiona 'c' para volver al menu de contacto");
                            Console.WriteLine("Presiona 'g' para salir del programa");
                            Console.WriteLine("Presiona 'w' para seguir editando un contacto");
                            volver = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(volver == 'c'){
                                menuContactos(opt);
                            } else if(volver == 'g'){
                                salir();
                            } else if(volver == 'w'){
                                seguirEditando(opt, opt1, nom, lastName, tel, adress, email, volver);
                            }
                            break;
                        case 4:
                            Console.WriteLine("email");
                            Console.WriteLine("ingrese nuevo nombre");
                            email = Console.ReadLine();
                            Console.WriteLine("Presiona 'e' para guardar");
                            guardar = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(guardar == 'e'){
                                Console.WriteLine("Contacto actualizado con exito!");
                            }
                            Console.WriteLine("Presiona 'c' para volver al menu de contacto");
                            Console.WriteLine("Presiona 'g' para volver al menu principal");
                            Console.WriteLine("Presiona 'w' para seguir editando un contacto");
                            volver = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(volver == 'c'){
                                menuContactos(opt);
                            } else if(volver == 'g'){
                                menu();
                            } else if(volver == 'w'){
                                seguirEditando(opt, opt1, nom, lastName, tel, adress, email, volver);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Direccion");
                            Console.WriteLine("ingrese nuevo nombre");
                            adress = Console.ReadLine();
                            Console.WriteLine("Presiona 'e' para guardar");
                            guardar = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(guardar == 'e'){
                                Console.WriteLine("Contacto actualizado con exito!");
                            }
                            Console.WriteLine("Presiona 'c' para volver al menu de contacto\n");
                            Console.WriteLine("Presiona 'g' para volver al menu principal\n");
                            Console.WriteLine("Presiona 'w' para seguir editando un contacto\n");
                            volver = Console.ReadKey().KeyChar;
                            Console.Clear();
                            if(volver == 'c'){
                                menuContactos(opt);
                            } else if(volver == 'g'){
                                menu();
                            } else if(volver == 'w'){
                                seguirEditando(opt, opt1, nom, lastName, tel, adress, email, volver);
                            }
                            break;
                    }
                    break;
            }
        }
        static void seguirEditando(int opt, int opt1, string? nom, string? lastName, int tel, string? adress, string? email, char volver){
            editarContacto(opt, opt1, nom, lastName, tel, adress, email, volver);
        }
        static void salir(){
            Console.WriteLine("ADIOS . . .");
            Environment.Exit(0);
        }
    }    
}