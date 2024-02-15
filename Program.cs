/*   Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, 
 *   quantos valores digitados foram ímpares, 
 *   quantos valores digitados foram positivos 
 *   e quantos valores digitados foram negativos.
 *   
 *   Entrada
 *   O arquivo de entrada contém 5 valores inteiros quaisquer.
 *   
 *   Saída
 *   Imprima a mensagem conforme o exemplo fornecido, 
 *   uma mensagem por linha, não esquecendo o final de linha após cada uma.
*/


int numero, contPares, contImpares, contPositivo, contNegativo;

contPares = 0;
contImpares = 0;
contPositivo = 0;
contNegativo = 0;


for  (int i = 1; i <= 5; i++)
{
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        contPares++ ;
    }
    else
    {
        contImpares++;
    }
    if (numero > 0)
    {
        contPositivo++;
    }
    else if (numero < 0)
    {
        contNegativo++;
    }
}

Console.WriteLine(contPares + " valor(es) par(es)");
Console.WriteLine(contImpares + " valor(es) impar(es)");
Console.WriteLine(contPositivo + " valores) positivo(s)");
Console.WriteLine(contNegativo + " valor(es) negativo(s)");

Console.ReadKey();