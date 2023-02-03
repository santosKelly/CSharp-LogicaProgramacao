using System;


//Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.//

int digito, produto = 1, soma = 0;

Console.WriteLine("Olá, informe um número sem casas decimais: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 0)
{
    digito = n % 10;

    produto *= digito;
    soma += digito;
    n /= 10;
}
Console.WriteLine($"O resultado dessa operação é {produto - soma}");
