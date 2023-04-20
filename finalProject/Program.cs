using System;
namespace projectoFinal {
    class Program {
        static void Main(string[] args){
            List<string> nombres = new List<string> ();
            List<string> apellidos = new List<string> ();
            List<int> tels = new List<int> ();
            List<string> direcciones = new List<string> ();
            List<string> correos = new List<string> ();
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
        List<string>nombres = new List<string> {};
        List<string> apellidos = new List<string> ();
            List<int> tels = new List<int> ();
            List<string> direcciones = new List<string> ();
            List<string> correos = new List<string> ();
            List<string> eventos  = new List<string> ();
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
            double rd = 0;
            double eur = 0;
            double dolar = 0;
            // if(elegir == 1){
            //     contacto(elegir);
            // }
            switch(elegir){ // casos para acceder al menu de arriba
                case 1:
                    contacto(elegir, nombres, apellidos, tels, direcciones, correos);
                    break;
                case 2:
                    evento(elegir, eventos);
                    break;
                case 3:
                    utiliarios(elegir, rd, eur, dolar);
                    break;
                case 4:
                    salir();
                    break;
            }
        }
        static void contacto(int elegir, List<string> nombres, List<string> apellidos, List<int> tels, List<string> direcciones, List<string> correos){
            Console.Clear();
            Console.WriteLine("Estas en contacto: \n");
            Console.WriteLine("que deseas hacer: \n");
            Console.WriteLine("1) [Crear contacto]");
            Console.WriteLine("2) [Editar contacto]");
            Console.WriteLine("3) [Borrar contacto]");
            Console.WriteLine("4) [Mostrar contacto]");
            Console.WriteLine("5) [Buscar contactos]");
            Console.WriteLine("6) [Volver al menu principal]");
            Console.WriteLine("7) [Salir]");
            int menuContacto = Convert.ToInt32(Console.ReadLine());
            switch(menuContacto){
                case 1:
                    crearContacto(menuContacto);
                    break;
                case 2:
                    editarContacto(menuContacto, elegir, nombres, apellidos, tels, direcciones, correos);
                    break;
                case 3:
                    borrarContacto(menuContacto, nombres, apellidos, tels, direcciones, correos);
                    break;
                case 4:
                    mostrarContacto(menuContacto,nombres , apellidos, tels, direcciones, correos);
                    break;
                case 5:
                    buscarContacto(menuContacto, nombres);
                    break;
                case 6:
                    menu();
                    break;
                case 7:
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
            int tel = Convert.ToInt32(Console.ReadLine());
            //listaTelefonos(tel);
            Console.Write("Direccion: ");
            string? adress = Console.ReadLine();
            
            Console.Write("Email: ");
            string? mail = Console.ReadLine();
            
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 's' para guardar");
            char save = Console.ReadKey().KeyChar;
            if(save == 's'){
                Console.Clear();
                Console.WriteLine("Contacto guardado correctamente! \n");
                listanombre(nom!);
                listaApellido(last!);
                listaTelefonos(tel);
                listaDireccion(adress!);
                listaMail(mail!);
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
        static void listanombre(string nom){
            List<string>nombres = new List<string> {};
            nombres.Add(nom);
            // Console.WriteLine(nom);
        }
        static void  listaApellido(string last){
            List<string>apellidos = new List<string> {};
            apellidos.Add(last);
        }
        static void listaTelefonos( int tel){
            List<int>tels = new List<int> {};
            tels.Add(tel);
        }
        static void listaDireccion(string adress){
            List<string>direcciones = new List<string> {};
            direcciones.Add(adress);
        }
        static void listaMail(string mail){
            List<string>correos = new List<string> {};
            correos.Add(mail);
        }
        static void editarContacto(int menuContacto, int elegir, List<string> nombres, List<string> apellidos, List<int> tels, List<string> direcciones, List<string> correos){
            Console.Clear();
            Console.WriteLine("Editar: \n");
            Console.WriteLine("Que desea editar? \n");
            Console.WriteLine("1) [Nombre]");
            Console.WriteLine("2) [Apellido]");
            Console.WriteLine("3) [Telefono]");
            Console.WriteLine("4) [Direccion]");
            Console.WriteLine("5) [Email]");
            Console.WriteLine("6) [Volver]");
            Console.WriteLine("7) [Salir]");
            int menuEditar = Convert.ToInt32(Console.ReadLine());
            switch(menuEditar){
                case 1:
                    Console.WriteLine("Nuevo nombre: ");
                    string? nom = Console.ReadLine();
                    listanombre(nom!);
                    Console.WriteLine("Presione 's' para guardar");
                    char save = Console.ReadKey().KeyChar;
                    if(save == 's'){
                        Console.WriteLine("El nombre de {...} ha sido actualizado exitosamente!");
                        editarContacto(menuContacto, elegir, nombres, apellidos, tels, direcciones, correos);
                    }
                    break;
                case 2:
                    Console.WriteLine("Nuevo apellido");
                    string? last = Console.ReadLine();
                    listaApellido(last!);
                    break;
                case 3: 
                    Console.WriteLine("Nuevo telefono");
                    int tel = Convert.ToInt32(Console.ReadLine());
                    listaTelefonos(tel!);
                    break;
                case 4: 
                    Console.WriteLine("Nueva direccion");
                    string? adress = Console.ReadLine();
                    listaDireccion(adress!);
                    break;
                case 5: 
                    Console.WriteLine("Nuevo correo");
                    string? mail = Console.ReadLine();
                    listaMail(mail!);
                    break;
                case 6:
                    contacto(elegir, nombres, apellidos, tels, direcciones, correos);
                    break;
                case 7:
                    salir();
                    break;
                
            }
        }
        static void borrarContacto(int menuContacto, List<string> nombres, List<string> apellidos, List<int> tels, List<string> direcciones, List<string> correos){
            Console.Clear();
            Console.WriteLine("Borrar contacto: \n");
            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
            Console.WriteLine("");
            mostrarContacto(menuContacto, nombres, apellidos, tels, direcciones, correos);
            string? nombre = Console.ReadLine();
            nombres.Remove(nombre!);
           // if(nombre == ){}
        }
        static void mostrarContacto(int menuContacto, List<string> nombres, List<string> apellidos, List<int> tels, List<string> direcciones, List<string> correos){
            foreach(string nombre in nombres){
                Console.WriteLine(nombre);
            }
            // foreach(string apellido in apellidos){
            //     Console.WriteLine(apellido);
            // }
            // foreach(int tel in tels){
            //     Console.WriteLine(tels);
            // }
            // foreach(string direccion in direcciones){
            //     Console.WriteLine(direccion);
            // }
            // foreach(string mail in correos){
            //     Console.WriteLine(mail);
            // }

        }
        static void buscarContacto(int menuContacto, List<string> nombres){
            Console.WriteLine("Buscar contacto\n");
            
            
        }
        static void evento(int elegir, List<string> eventos){
            Console.Clear();
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
                    crearEvento(menuEvento, elegir, eventos);
                    break;
                case 2:
                    editarEvento(menuEvento, eventos);
                    break;
                case 3: 
                    borrarEvento(menuEvento);
                    break;
                case 4:
                    buscarEvento(menuEvento, eventos);
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
        static void crearEvento(int menuEvento, int elegir, List<string> eventos){
            Console.Clear();
            Console.WriteLine("Crear evento: \n");
            Console.Write("Nombre de evento: ");
            string? nomEvent = Console.ReadLine();
            Console.Write("Fecha de evento: ");
            string? dateTime = Console.ReadLine();
            Console.WriteLine("Lugar: ");
            string? place = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 's' para guardar . . .");
            char save = Console.ReadKey().KeyChar;
            if(save == 's'){
                Console.Clear();
                Console.WriteLine("EVENTO GUARDADO CORRECTAMENTE!\n");
                Console.WriteLine("Presione cualquier tecla para volver atras . . .");
                Console.ReadKey();
                Console.Clear();
                evento(elegir, eventos);
            } else {
                while(save != 's'){
                Console.WriteLine("No se ha podido guardar el evento \n");
                Console.WriteLine("Presiona cualquier tecla para continuar . . .");
                Console.ReadKey();
                Console.Clear();
                evento(elegir, eventos);
                }
            }

        }
        static void editarEvento(int menuEvento, List<string> eventos){
            Console.WriteLine("Que evento vas a editar? \n");
            buscarEvento(menuEvento, eventos);
        }
        static void borrarEvento(int menuEvento){
            mostrarEvento(menuEvento);
        }
        static void buscarEvento(int menuEvento, List<string> eventos){
            foreach(string evento in eventos){
                Console.WriteLine(evento);
            }
        }
        static void mostrarEvento(int menuEvento){}

        // UTILITARIOS
        static void utiliarios(int elegir, double rd, double eur, double dolar){ 
            Console.Clear();
            Console.WriteLine("1) [Conversor de monedas]");
            Console.WriteLine("1) [Conversor de temperatura]");
            Console.WriteLine("3) [Calculadora]");
            Console.WriteLine("4) [Volver]");
            Console.WriteLine("5) [Salir]");
            elegir = Convert.ToInt32(Console.ReadLine());
            switch(elegir){
                case 1:
                    moneda(elegir, rd, eur, dolar);
                    break;
                case 2:
                    break;
                case 3:
                    calculadora(elegir);
                    break;
                case 4: 
                    menu();
                    break;
                case 5:
                    salir();
                    break;
                default:
                    while(elegir < 1 || elegir > 5){
                        Console.Clear();
                        Console.WriteLine("Opcion no disponible");
                        utiliarios(elegir, rd, eur, dolar);
                    }
                    break;
            }
        }
        static void moneda(int elegir, double rd, double eur, double dolar){
            Console.Clear();
            Console.WriteLine("convertir a: \n");
            e:
            Console.WriteLine("1) [USD A RD$]");
            Console.WriteLine("2) [USD A EUR]");
            Console.WriteLine("3) [EUR A RD$]");
            Console.WriteLine("4) [EUR A USD]");
            Console.WriteLine("5) [RD$ A USD]");
            Console.WriteLine("6) [RD A EUR]");
            Console.WriteLine("7) [Volver al menu principal]");
            Console.WriteLine("8) [Volver al menu de utilitarios]");
            Console.WriteLine("9) [Salir]");
            elegir = Convert.ToInt32(Console.ReadLine());
            switch(elegir){
                case 1:
                    dolarRD(elegir, rd, dolar, eur);
                    break;
                case 2:
                    dolarEur(elegir, eur, dolar, rd);
                    break;
                case 3: 
                    eurRD(elegir, rd, eur, dolar);
                    break;
                case 4:
                    eurDolar(elegir, dolar, eur, rd);
                    break;
                case 5:
                    rdDolar(elegir, dolar, eur, rd);
                    break;
                case 6:
                    rdEur(elegir, eur, rd, dolar);
                    break;
                case 7:
                    menu();
                    break;
                case 8:
                    utiliarios(elegir, rd, eur, dolar);
                    break;
                case 9:
                    salir();
                    break;
                default:
                Console.Clear();
                Console.WriteLine("No existe la moneda");
                    goto e;
            }
        }
        static void temperatura(double f, double c, double k, int elegir, double eur, double dolar, double rd){
            o:
            Console.Clear();
            Console.WriteLine("Convertidor de temperaturas\n");
            Console.WriteLine("1) [Fahrenheit a Celsius]");
            Console.WriteLine("2) [Farenheit a Kelvin]");
            Console.WriteLine("3) [Celcius a Fahrenheit]");
            Console.WriteLine("4) [Celsius a Kelvin]");
            Console.WriteLine("5) [Kelvin a Fahrenheit]");
            Console.WriteLine("6) [Kelvin a Celsius]");
            Console.WriteLine("7) [Volver al menu de utilitarios]");
            Console.WriteLine("8) [Volver al menu principal]");
            Console.WriteLine("8) [Salir]");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch(opt){
                case 1:
                    fC(f, c, k);
                    break;
                case 2:
                    fK(f, c, k);
                    break;
                case 3: 
                    cF(f, c, k);
                    break;
                case 4: 
                    cK(f, c, k);
                    break;
                case 5:
                    kF(f, c, k);
                    break;
                case 6:
                    kC(f, c, k);
                    break;
                case 7:
                    utiliarios(elegir, rd, eur ,dolar);
                    break;
                case 8: 
                    menu();
                    break;
                case 9:
                    salir();
                    break;
                default:
                    Console.WriteLine("Con nintendo no se jode boludito");
                    Console.WriteLine("Presiona cualquier tecla para continuar . . .");
                    Console.ReadKey();
                    goto o;
            }
        }
        // TEMPERATURAS
        static void fK(double f, double c, double k){
            Console.Clear();
            Console.WriteLine("Ingresa el valor en grados Kelvin");
            k = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble((k - 273.15) * 9 / 5 + 32);
            Console.WriteLine($"{k} grados Kelvin es igual a {conver} grados Fahrenheit");
        }
        static void fC(double f, double c, double k){
            Console.Clear();
            Console.WriteLine("Ingrese el valor en grados Fahrinheit: ");
            f = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble((f - 32) * 5 / 9);
            Console.WriteLine($"{f} grados Fahrenheit es igual a {conver} grados Celsius");
        }
        static void cF(double f, double c, double k){
            Console.Clear();
            Console.WriteLine("Ingresa el valor en grados Celsius");
            c = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble((c * 9 / 5) + 32);
            Console.WriteLine($"{c} grados Celcius es igual a {conver} grados Fahrenheit");
        }
        static void cK(double f, double c, double k){
            Console.Clear();
            Console.WriteLine("Ingresa el valor en grados Celsius");
            c = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble((c * 9 / 5) + 32);
            Console.WriteLine($"{c} grados Celsius es igual a {conver} grados Kelvin");
        }
        static void kF(double f, double c, double k){
            Console.Clear();
            Console.WriteLine("Ingresa el valor en grados Kelvin");
            k = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble((k - 273.15) * 9 / 5 + 32);
            Console.WriteLine($"{k} grados Kelvin es igual a {conver} grados Fahrenheit");
        }
        static void kC(double f, double c, double k){
            Console.Clear();
            Console.WriteLine("Ingresa el valor en grados Kelvin");
            k = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble(k - 273.15);
            Console.WriteLine($"{k} grados Kelvin es igual a {conver} grados Fahrenheit");
        }
        static void dolarRD(int elegir, double rd, double dolar, double eur){
            Console.WriteLine("Ingrese moneda dominicana");
            rd = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble(rd / 55.16);
            Console.WriteLine($"{rd} pesos son {conver} dolares");
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 'a' para volver al menu de utilitarios");
            Console.WriteLine("Presiona 'w' para volver al menu principal");
            char back = Console.ReadKey().KeyChar;
            if(back == 'a'){
                utiliarios(elegir, rd, eur, dolar);
            } else if(back == 'w'){
                menu();
            } else {
                while(back != 'a' || back != 'w'){
                    Console.WriteLine("Opcion no encontrada");
                    Console.WriteLine("Por favor introducir una opcion valida");
                    back = Console.ReadKey().KeyChar;
                    if(back == 'a'){
                    utiliarios(elegir, rd, eur, dolar);
                    } else if(back == 'w'){
                        menu();
                    }
                }
            }
        }
        static void dolarEur(int elegir, double eur, double dolar, double rd){
            Console.WriteLine("Ingresa moneda EUR");
            eur = Convert.ToDouble(Console.ReadLine());
            
            double conver = Convert.ToDouble(eur / 0.98);
            Console.WriteLine($"{eur} euros son {conver}");
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 'a' para volver al menu de utilitarios");
            Console.WriteLine("Presiona 'w' para volver al menu principal");
            char back = Console.ReadKey().KeyChar;
            if(back == 'a'){
                utiliarios(elegir, rd, eur, dolar);
            } else if(back == 'w'){
                menu();
            } else {
                while(back != 'a' || back != 'w'){
                    Console.Clear();
                    Console.WriteLine("Opcion no encontrada");
                    Console.WriteLine("Por favor introducir una opcion valida");
                    back = Console.ReadKey().KeyChar;
                    if(back == 'a'){
                    utiliarios(elegir, rd, eur, dolar);
                    } else if(back == 'w'){
                        menu();
                    }
                }
            }

        }
        static void eurRD(int elegir, double rd, double eur, double dolar){
            Console.WriteLine("Ingresa moneda dominicana");
            rd = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble(rd / 60.33);
            Console.WriteLine($"{rd} pesos son {conver} euros");
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 'a' para volver al menu de utilitarios");
            Console.WriteLine("Presiona 'w' para volver al menu principal");
            char back = Console.ReadKey().KeyChar;
            if(back == 'a'){
                utiliarios(elegir, rd, eur, dolar);
            } else if(back == 'w'){
                menu();
            } else {
                while(back != 'a' || back != 'w'){
                    Console.Clear();
                    Console.WriteLine("Opcion no encontrada");
                    Console.WriteLine("Por favor introducir una opcion valida");
                    back = Console.ReadKey().KeyChar;
                    if(back == 'a'){
                    utiliarios(elegir, rd, eur, dolar);
                    } else if(back == 'w'){
                        menu();
                    }
                }
            }
        }
        static void eurDolar(int elegir, double dolar, double rd, double eur){
            Console.WriteLine("Ingresa moneda dolar");
            dolar = Convert.ToDouble(Console.ReadLine());
            double  conver = Convert.ToDouble(dolar / 1.09);
            Console.WriteLine($"{dolar} dolares son {conver} euros");
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 'a' para volver al menu de utilitarios");
            Console.WriteLine("Presiona 'w' para volver al menu principal");
            char back = Console.ReadKey().KeyChar;
            if(back == 'a'){
                utiliarios(elegir, rd, eur, dolar);
            } else if(back == 'w'){
                menu();
            } else {
                while(back != 'a' || back != 'w'){
                    Console.WriteLine("Opcion no encontrada");
                    Console.WriteLine("Por favor introducir una opcion valida");
                    back = Console.ReadKey().KeyChar;
                    if(back == 'a'){
                    utiliarios(elegir, rd, eur, dolar);
                    } else if(back == 'w'){
                        menu();
                    }
                }
            }
        }
        static void rdDolar(int elegir, double dolar, double eur, double rd){
            Console.WriteLine("Ingresa moneda dolar");
            dolar = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble(dolar / 0.018);
            Console.WriteLine($"{dolar} dolares son {conver} pesos dominicanos");
            Console.WriteLine("\n");
            Console.WriteLine("Presiona 'a' para volver al menu de utilitarios");
            Console.WriteLine("Presiona 'w' para volver al menu principal");
            char back = Console.ReadKey().KeyChar;
            if(back == 'a'){
                utiliarios(elegir, rd, eur, dolar);
            } else if(back == 'w'){
                menu();
            } else {
                while(back != 'a' || back != 'w'){
                    Console.WriteLine("Opcion no encontrada");
                    Console.WriteLine("Por favor introducir una opcion valida");
                    back = Console.ReadKey().KeyChar;
                    if(back == 'a'){
                    utiliarios(elegir, rd, eur, dolar);
                    } else if(back == 'w'){
                        menu();
                    }
                }
            }

        }
        static void rdEur(int elegir, double eur, double rd, double dolar){
            Console.WriteLine("Ingresa moneda EUR");
            eur = Convert.ToDouble(Console.ReadLine());
            double conver = Convert.ToDouble(eur / 0.017);
            Console.WriteLine($"{eur} euros son {conver} pesos dominicanos");
                        Console.WriteLine("\n");
            Console.WriteLine("Presiona 'a' para volver al menu de utilitarios");
            Console.WriteLine("Presiona 'w' para volver al menu principal");
            char back = Console.ReadKey().KeyChar;
            if(back == 'a'){
                utiliarios(elegir, rd, eur, dolar);
            } else if(back == 'w'){
                menu();
            } else {
                while(back != 'a' || back != 'w'){
                    Console.WriteLine("Opcion no encontrada");
                    Console.WriteLine("Por favor introducir una opcion valida");
                    back = Console.ReadKey().KeyChar;
                    if(back == 'a'){
                    utiliarios(elegir, rd, eur, dolar);
                    } else if(back == 'w'){
                        menu();
                    }
                }
            }
        }
        static void calculadora(int elegir){
            // animacion();
            Console.Clear();
            Console.Write("Ingresa el primer dato: ");
            double n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/ \n");
            Console.Write("Ingresa el operador: ");
            string? operacion = Console.ReadLine();
            // if(operacion != "+" || operacion != "-" || operacion != "*" || operacion != "/"){
            //     while(operacion != "+" || operacion != "-" || operacion != "*" || operacion != "/"){
            //         Console.WriteLine("El operador al que intentaste acceder no existe");
            //         Console.WriteLine("Por favor intente hacer el calculo de nuevo");
            //         calculadora(elegir);
            //     }
           // }
            Console.WriteLine("Ingresa el segundo dato");
            double n2 = Convert.ToInt32(Console.ReadLine());
            switch(operacion){
                case "+":
                    suma(n1, n2);
                    break;
                case "-":
                    resta(n1, n2);
                    break;
                case "*":
                    multi(n1, n2);
                    break;
                case "/":
                    div(n1, n2);
                    break;
                // default:
                //     // while(operacion != '+' || operacion != '-' || operacion != '*' || operacion != '/'){

                //     break;
                  // goto i;
                }
            Console.WriteLine("Presiona Cualquier tecla para continuar . . .");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Deseas hacer un nuevo calculo?\n");
            Console.WriteLine("S/n\n");
            Console.WriteLine("O presione 'b' para volver al menu principal");
            char backCal = Console.ReadKey().KeyChar;
            if(backCal == 's'){
                calculadora(elegir);
            } else if(backCal == 'b'){
                menu();
            } else if(backCal == 'n'){
                salir();
            } else {
                while(backCal != 's' || backCal != 'b' || backCal != 'n'){
                    Console.WriteLine("Deseas hacer un nuevo calculo?\n");
                    Console.WriteLine("S/n\n");
                    Console.WriteLine("O presione 'b' para volver al menu principal");
                    backCal = Console.ReadKey().KeyChar;
                }
            }
        }
        static void suma(double n1, double n2){
            Console.WriteLine($"{n1} + {n2} = {n1+n2}");
        }
        static void resta(double n1, double n2){
            Console.WriteLine($"{n1} - {n2} = {n1-n2}");
        }
        static void multi(double n1, double n2){
            Console.WriteLine($"{n1} * {n2} = {n1*n2}");
        }
        static void div(double n1, double n2){
            Console.WriteLine($"{n1} / {n2} = {n1/n2}");
        }
        static void salir(){ //falta animacion de salida
        Console.Clear();
            Console.WriteLine("ADIOS . . .");
            Environment.Exit(0);
        }
    }
}
