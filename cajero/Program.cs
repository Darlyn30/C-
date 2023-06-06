/*
cajero automatico
*/

using System;
namespace cajero {
    class Program {
        
        static void Main(string[] args){
            // code here!!

            // tu cuenta
            Console.Clear();
            int balance = Convert.ToInt32(3500);
            List<int> cuenta = new List<int> {
                // numero de cuenta

            };
            int opt = 0;

            cajeroCuenta(cuenta, opt, balance);
        }
        static void cajeroCuenta(List<int> cuenta, int opt, int balance){
            Console.Write("Ingrese su numero de cuenta: ");

            int numeroCuenta = Convert.ToInt32(Console.ReadLine()); 
            cuenta.Add(numeroCuenta);

            //Console.Write("Quieres ver las cuentas que estan dentro de la lista?S/n: ");
            
            // char opt = Console.ReadKey().KeyChar;

            // if(opt == 's'){
            //     Console.Clear();
            //     Console.WriteLine(cuenta[0]);
            // }

            /*
            ese trozo de codigo solo era para comprobar que se estaba guardando el "numero de cuenta"
            */
            cajeroMenu(cuenta, opt, balance);
        }
        static void cajeroMenu(List<int> cuenta, int opt, int balance){
            Console.Clear();
            Console.WriteLine($"hola {cuenta[0]}\n");
            Console.WriteLine("[1] Depositar a tu cuenta");
            Console.WriteLine("[2] Retirar de tu cuenta");
            Console.WriteLine("[3] Depositar a otra cuenta");
            Console.WriteLine("[4] ver balance");
            choose(opt, cuenta, balance);

        }
        static void choose(int opt, List<int> cuenta, int balance){
            opt = Convert.ToInt32(Console.ReadLine());
            switch(opt){
                case 1:
                    // function
                    depositarTuCuenta(cuenta, balance, opt);
                    break;
                case 2:
                    // function
                    retirarTuCuenta(cuenta, opt, balance);
                    break;
                case 3:
                    // function
                    depositarOtraCuenta(cuenta, opt,balance);
                    break;
                case 4:
                    // function
                    verBalance(balance, cuenta, opt);
                    break;
                default:
                    // back to menu
                    while(opt > 4 || opt < 1){
                        Console.Clear();
                        Console.WriteLine("no encontre esta opcion");
                        cajeroMenu(cuenta, opt, balance);
                    }
                    break;
            }
        }
        static void depositarTuCuenta(List<int> cuenta, int balance, int opt){
            e:
            Console.Clear();
            Console.Write($"hola {cuenta[0]} por favor ingresa el monto que vas a depositar: ");
            int monto = Convert.ToInt32(Console.ReadLine());

            while(monto > 3500){
                Console.WriteLine("no tienes saldo suficiente suficiente");
                Console.WriteLine("Presione cualquier tecla para continuar . . .");
                Console.ReadKey();
                goto e;
            }

            Console.WriteLine($"Estas seguro que desea depositar {monto}? S/n");
            char confirm = Console.ReadKey().KeyChar;

            // if(confirm == 's'){
            //     Console.Write("ingrese el numero de cuenta al que le sera enviado el monto seleccionado");
            //     int account = Convert.ToInt32(Console.ReadLine());
            // } else {
            //     Console.WriteLine("No se envio el dinero");
            //     Console.WriteLine("Entonces no va a querer enviar el dinero? S/n");
                
            //     confirm = Console.ReadKey().KeyChar;
            //     if(confirm != 's'){
            //         salir();
            //     }


            // }

            if(confirm == 's'){
                Console.Clear();
                Console.WriteLine("El deposito se ha realizado con exito!\n");
                Console.WriteLine("Presione cualquier tecla para continuar . . .");
                Console.ReadKey();
                cajeroMenu(cuenta, opt, balance);
            } else {
                Console.WriteLine("No se pudo depositar el dinero");
                Console.WriteLine("Presiona cualquier tecla para continuar . . .");
                Console.Clear();
                cajeroMenu(cuenta, opt, balance);

            }
            
            
            
        }
        static void retirarTuCuenta(List<int> cuenta, int opt, int balance){
            i:
            Console.Write("Ingresa el monto que deseas retirar: ");
            int monto = Convert.ToInt32(Console.ReadLine());

            while(monto > balance){
                Console.WriteLine("no tienes balance suficiente para retirar esta cantidad");
                Console.WriteLine("presione cualquier tecla para continuar . . .");
                Console.ReadKey();
                goto i;
            }

            if(monto > 0){
                Console.WriteLine($"Confirmar retiro de {monto} pesos S/n\n");
                char confirm = Console.ReadKey().KeyChar;
                    

                        if(confirm == 's'){
                            Console.Clear();
                            Console.Write("Introduzca su clave: ");

                            List<int> clave = new List<int> {
                                // claves
                            };
                            int key = Convert.ToInt32(Console.ReadLine());
                            clave.Add(key);


                            if(key == clave[0]){
                                Console.WriteLine("Retiro realizado con exito!");
                                Console.WriteLine("Presione cualquier tecla para continuar . . .");
                                Console.ReadKey();
                            }
                            
                            int final;
                            final = balance - monto;
                            cajeroMenu(cuenta, opt, balance);
                        }
                    }
            if(monto == 0){
                Console.WriteLine($"Enserio? retiraras {monto} pesos? jajajajaja: S/n ");
                char opte = Console.ReadKey().KeyChar;

                if(opte == 's'){
                    int final;
                    final = balance;
                } else {
                    Console.WriteLine("Presione cualquier tecla para volver . . .");
                    Console.ReadKey();
                    cajeroMenu(cuenta, opt, balance);
                }


            }
        }
        static void depositarOtraCuenta(List<int> cuenta, int opt, int balance){
            Console.WriteLine("Depositar a alguien\n");
            Console.Write("Ingrese el numero de cuenta que realizara el deposito: ");
            int cuenta2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Cuanto desea depositar?: ");
            int deposito = Convert.ToInt32(Console.ReadLine());
            


            while(deposito > balance){
                Console.WriteLine("No tienes dinero suficiente para enviar esta cantidad");
                Console.WriteLine("Presione cualquier tecla para volver atras . . .");
                Console.ReadKey();
                cajeroMenu(cuenta, opt, balance);
            }

            if(deposito <= balance){
                Console.WriteLine($"Estas seguro que deseas enviar {deposito}");
            }
        }
         static void verBalance(int balance, List<int> cuenta, int opt){
            int saldo = balance;
            Console.WriteLine(saldo + "\n");
            Console.WriteLine("Presiona cualquier tecla para volver . . .");
            Console.ReadKey();
            cajeroMenu(cuenta, opt, balance);
        }

        static void salir(){
            Console.WriteLine("Esta bien, que tenga un excelente dia");
            Console.WriteLine("Le desea el Banco (BTW)");
            Environment.Exit(0);
        }

    }
}