//faça um programa que leia um numero inicial e um numero final
//mostrando, entre eles, quais sao os valores pares e impares

int inicio, fim, aux;

Console.WriteLine("Informe um numero inicial");
inicio = int.Parse(Console.ReadLine());
inicio++; // add +1 pra ser entre

Console.WriteLine("Informe um numero final");
fim = int.Parse(Console.ReadLine());

while (inicio < fim)
{
    aux = inicio;
    Console.Write("O numero: "+aux);
    if (aux % 2 == 0)
    {
        if(aux == 0)
        {
            Console.WriteLine(" eh neutro!");
        } else
        {
            Console.WriteLine(" Eh eh par!");
        }
    } else
    {
        Console.WriteLine(" Eh impar!");
    }
    inicio++;
}

Console.ReadKey();