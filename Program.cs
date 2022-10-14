// See https://aka.ms/new-console-template for more information
// First exercise

// Online C# Editor for free
/*
Utilizando o array [7, 5, 3, 9, 6, 4, 1], faça o código para percorrer a lista, localizar e substituir o valor 9 por 5, remover o valor 4 da lista. Ao final você deve apresentar na tela a lista original, a nova lista e a soma dos valores da nova lista.
*/

using System;

public class Filtering
{
    public static void Main(string[] args)
    {
        int[] myNumbersOne = {7, 5, 3, 9, 6, 4, 1};
        int[] myNumbers = {7, 5, 3, 9, 6, 4, 1};
        
        
    for (int i = 0; i < myNumbers.Length; i++) 
        {
            if (myNumbers[i] == 9) 
            {
                myNumbers[i] = 5;
            } 
        }
        
        myNumbers = Array.FindAll(myNumbers, i => i != 4);
        
        Console.WriteLine("Lista original:");
        for (int i = 0; i < myNumbersOne.Length; i++) 
        {
            Console.Write(myNumbersOne[i]);
        }
        
        Console.WriteLine("");
        Console.WriteLine("Nova lista:");
        for (int i = 0; i < myNumbers.Length; i++) 
        {
            Console.Write(myNumbers[i]);
        }
        
        Console.WriteLine("");
        Console.WriteLine("Soma dos valores da nova lista:");
        int sum = 0;
        for (int i = 0; i < myNumbers.Length; i++) 
        {
            sum += myNumbers[i];
        }
        Console.WriteLine(sum);
    }
}

/*
Tarefa 2

Analise o cenário a seguir:
SQL 1	SQL 2
SELECT COUNT(Codigo) as Total 
FROM Pedido


Total = 100	SELECT COUNT(Codigo) as Total123 
FROM Pedido 
WHERE CodigoComprador = 123

Total123 = 15

Dado o resulado acima, qual será o resultado do SQL abaixo?
SELECT COUNT(Codigo) as TotalFinal FROM Pedido WHERE CodigoComprador <> 123

85, pois se o total de COUNT(Codigo) as Total FROM Pedido é 100, 
e se o total de COUNT(Codigo) as Total123 FROM Pedido WHERE CodigoComprador = 123 é 15, 
então SELECT COUNT(Codigo) as TotalFinal FROM Pedido WHERE CodigoComprador <> 123 será 85, 
pois é todos os “Codigo” onde CodigoComprado É DIFERENTE de 123. 

*/

/*

Tarefa 3

Desenvolva um algoritmo que, dado um conjunto de números inteiros, retorne o índice da posição da soma de dois números desse conjunto. Você pode assumir que cada conjunto de números tem apenas uma solução, e você não pode usar o mesmo número duas vezes.

Exemplo


Entrada: [2, 7, 11, 15]
Possíveis resultados (você só precisa resolver um):

Resultado 1

Soma da entrada: 9
9 é a soma de 2 + 7
2 + 7 são os números encontrados no array de entrada 	Resultado 2

Soma da entrada: 22
22 é a soma de 7 + 15

*/

public class TwoIntsSum
{
    public static void Main(string[] args)
    {
        string []arr = new string[4];
        for(int i = 0;i<arr.Length;i++)
        {
            arr[i]= Console.ReadLine();
        }
		
        int[] myInts = Array.ConvertAll(arr, s => int.Parse(s));
        
        
        int sum;
        Console.WriteLine("Por favor digite a soma de entrada: ");
        sum = Int16.Parse(Console.ReadLine());
        
        for(int i = 0;i<myInts.Length;i++)
        {
            for(int j = 1;j<myInts.Length-1;j++)
            {
                if (myInts[i] + myInts[j] == sum)
                {
                    if (myInts[i] != myInts[j]) {
                    Console.WriteLine("Soma de entrada: " + sum);
                    Console.WriteLine(sum + " é a soma de " + myInts[i] + "+" + myInts[j]);
                    Console.WriteLine(myInts[i] + "+" + myInts[j] + " sao os numeros encontrados no array de entrada");
                    // break;
                    }
                }
                break;
            }
        }
    }
}