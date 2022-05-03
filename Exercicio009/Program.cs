// See https://aka.ms/new-console-template for more information

/*
 * Efetuar a conversão de temperatura da escala Celsius para a escala Fahrenheit. 
 **/

// declaração das variaveis do tipo double para o recebimento dos valores e calculos
double celsius, fahr;

// imprime a mensagem na tela e lê o valor digitado pelo usuario
Console.Write("Digite o valor da temperatura em ºC: ");
celsius = double.Parse(Console.ReadLine());

// calcula a conversão de celsius para fahrenheit
fahr = 1.80 * celsius + 32;


// também pode ser calculado assim
// fahr = celsius * ((double)9 / 5) + 32;

// imprime na tela o resultado da conversão com uma frase
Console.WriteLine("A temperatura de {0:F2}ºC se torna {1:F2}ºF", celsius, fahr);
