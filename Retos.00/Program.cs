//Reto #0: EL FAMOSO "FIZZ BUZZ"

/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */

using Retos2023._00;

var buzzFizz = new BuzzFizz();

for (var i = 1; i <= 100; i++)
{
    var result = buzzFizz.GetLabel(i);
    Console.WriteLine($"{i} - {result}");
}