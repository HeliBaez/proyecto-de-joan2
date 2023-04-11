// See https://aka.ms/new-console-template for more information

Console.WriteLine("*********************************************");
Console.WriteLine();
Console.WriteLine("   Bienvenido a la calculadora cientidica");
Console.WriteLine();
Console.WriteLine("*********************************************");
Console.WriteLine();

while (true) { 
    Console.WriteLine("Ingrese el primer numero: ");
    double num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

<<<<<<< HEAD
    Console.WriteLine("Escribe el nombre del operador quieres usar: ");
    Console.WriteLine();
    Console.WriteLine("SUMA");
    Console.WriteLine("RESTA");
    Console.WriteLine("MULTIPLICACION");
    Console.WriteLine("DIVICION");
    Console.WriteLine("SENO");
    Console.WriteLine("COSENO");
    Console.WriteLine("TANGENTE");
    Console.WriteLine("EXPONENCIAL");
    Console.WriteLine("LOGARITMO");
    Console.WriteLine("RAIZ CUADRADA");
    Console.WriteLine();
    string operador = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Ingrese el segundo numero: ");
    double num2 = Convert.ToInt32(Console.ReadLine());
=======
Console.WriteLine("Ingrese dos números:");
double num1 = Convert.ToInt32(Console.ReadLine());
double num2 = Convert.ToInt32(Console.ReadLine());
>>>>>>> 41abe2098913176a01924cb1eb095ca16fa81140
//primer comentario

//double opcion = Convert.ToInt32(Console.ReadLine());

    double resultado = 0;
    switch (operador)
    {
        case "SUMA":
            Console.WriteLine($"El resultado de la suma de  {num1} y {num2} es: " + (num1 + num2));
            break;
        case "RESTA":
            Console.WriteLine($"El resultado de la resta de {num1} y {num2} es: " + (num1 - num2));
            break;
        case "MULTIPLICACION":
            Console.WriteLine($"El resultado de la multiplicacion de  {num1} y {num2} es: " + (num1 * num2));
            break;
        case "DIVICION":
            Console.WriteLine($"El resultado de la divicion de {num1} y {num2} es: " + (num1 / num2));
            break;
        case "SENO":
            Console.WriteLine($"El resultado del seno de  {num1} es: " + (Math.Sin(num1))); 
            break;
        case "COSENO":
            Console.WriteLine($"El resultado del coseno de  {num1} es: " + (Math.Cos(num1)));
            break;
        case "TANGENTE":
            Console.WriteLine($"El resultado la tangente de  {num1} es: " + (Math.Tan(num1)));
            break;
        case "EXPONENCIAL":
            Console.WriteLine($"El resultado el exponencial de  {num1} es: " + (Math.Exp(num1)));
            break;
        case "LOGARITMO":
            Console.WriteLine($"El resultado del logaritmo de {num1} y {num2} es: " + (Math.Log(num1,num2)));
            break;
        default:
            Console.WriteLine("Ingresaste un valor invalido, regresa al menu.")

    }
}

//Console.WriteLine("El resultado es: " + resultado);



