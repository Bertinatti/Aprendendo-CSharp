// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o volume de um Cilindro. Mostrar de forma simples a declaração de 
 * variáveis e entrada e saída de dados
 * pi = 3.14159
 * */

double raio, altura, volume; /* declaração das variáveis do tipo double **/

Console.Write("Digite o valor do raio (em cm): "); /* imprime na tela do console o chamado para a variável raio **/
raio = double.Parse(Console.ReadLine()); /* atribui valor a variável raio **/
Console.Write("Digite o valor da altura (em cm): "); /* imprime na tela do console o chamado para a variável altura **/
altura = double.Parse(Console.ReadLine()); /* atribui valor a variável altura **/

volume = 3.14159 * (Math.Pow(raio, 2)) * altura; /* faz o calculo do volume do cilindro, utilizando a função Math.Pow(número, expoente)**/

Console.WriteLine("O valor do volume do cilíndro com raio {0} cm e altura {1} cm é: {2:F2} cm³", raio, altura, volume); /* imprime na tela a frase de resposta com volume do cilindro digitado **/
