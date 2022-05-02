// See https://aka.ms/new-console-template for more information

/* 
 * Converter a temperatura de graus Fahrenheit para graus Celsius. Usar o console para a 
 * entrada e saída de dados.
 **/

double fahr, celsius; /* declaração das variáveis para receber a temperatura e converte-lá, do tipo double **/

Console.Write("Digite a temperatura em Fahrenheit: "); /* imprime a mensagem 'Digite a temperatuara em Fahrenheit:' na tela do console **/
fahr = double.Parse(Console.ReadLine()); /* adiciona o valor digitado a variável fahr **/

celsius = (fahr - 32) * 5 / 9; /* realiza o cálculo de conversão para graus celsius **/

Console.WriteLine("A conversão de {0:F2} ºF para Celsius é igual a: {1:F2} ºC", fahr, celsius); /** imprime na tela a mensagem e mostra com as variáveis formatadas com duas casas decimais na ordem: {0} fahr e {1} celsius  **/

