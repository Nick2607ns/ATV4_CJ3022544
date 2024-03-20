// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

float n1, n2, operador, resul;

Console.WriteLine(" digite 1 para +, digite 2 para -, digite 3 para *, digite 4 para / ");
operador = float.Parse(Console.ReadLine());

switch (operador) {
    case 1:
        Console.WriteLine("de o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        resul = (n1 + n2);
        Console.WriteLine("o resultado é", resul);
        break;

    case 2:
        Console.WriteLine("de o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        resul = (n1 - n2);
        Console.WriteLine("o resultado é", resul);
        break;

    case 3:
        Console.WriteLine("de o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        resul = (n1 * n2);
        Console.WriteLine("o resultado é", resul);
        break;

    case 4:
        Console.WriteLine("de o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        resul = (n1 / n2);
        Console.WriteLine("o resultado é", resul);
        break;





}



