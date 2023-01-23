

// hacer un programa que solicite username y password, si son correctas envie un mensaje de satisfactorio y si no solicitar de nuevo los datos

Console.WriteLine("enter your username ");
var username = Console.ReadLine();

Console.WriteLine("enter your password");
var password = Console.ReadLine();

while(username + password != "darlyn" + "darlyn123"){

    Console.WriteLine("are wrong, retry again");

    Console.WriteLine("enter your username ");
    Console.WriteLine(username = Console.ReadLine());
    Console.WriteLine("enter your password");
    Console.WriteLine(password = Console.ReadLine());
}

//int suma;

if(username + password == "darlyn" + "darlyn123"){
    Console.WriteLine("welcome Mr Darlyn!");
    Console.WriteLine("we hope your time in that page it should be great");
} else{}

//Console.WriteLine(suma=Convert.ToInt32(Console.ReadLine()));
  //  suma = suma + 17;