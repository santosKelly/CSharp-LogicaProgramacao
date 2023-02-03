using System;


int numero1, numero2;

Console.WriteLine("Informe um valor sem casas decimais: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe um segundo valor sem casas decimais: ");
numero2 = Convert.ToInt32(Console.ReadLine());

string a = Convert.ToString(numero1 % 10);
string b = Convert.ToString(numero2 % 10);


if (b.Length != a.Length)
    Console.WriteLine("não encaixa");
else if (a.EndsWith(b))
    Console.WriteLine("encaixa");
else
    Console.WriteLine("não encaixa");
