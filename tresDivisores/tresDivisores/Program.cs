
/*Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos. Caso contrário, retorne false. 
O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m.*/ 

int count = 0;

Console.WriteLine("Informe um número sem casas decimais: ");
int n = Convert.ToInt32(Console.ReadLine());


for (int contador = 1; contador <= n; contador++)
{
    if (n % contador == 0)
    {
        count++;
    }

    if (count > n)
    {
        Console.WriteLine(false);
    }
}
Console.WriteLine(count == 3);
