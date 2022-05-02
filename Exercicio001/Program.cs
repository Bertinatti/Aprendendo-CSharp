// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o volume de uma caixa retangular, mostrar de forma simples a declaração de 
 * variáveis e a manipulação de dados de entrada e saída via console.
 * */

double volume, altura, largura, comprimento; /* variáveis do tipo double para receber a altura, a largura e o comprimento para realizar o cálculo do volume **/

Console.Write("Digite a altura da caixa (em m): "); /* linha para a impressão do texto na tela **/
altura = double.Parse(Console.ReadLine()); /* linha para o recebimento do valor na variável altura **/
Console.Write("Digite a largura da caixa (em m): "); /* linha para a impressão do texto na tela **/
largura = double.Parse(Console.ReadLine()); /* linha para o recebimento do valor na variável largura **/
Console.Write("Digite o comprimento da caixa (em m): "); /* linha para a impressão do texto na tela **/
comprimento = double.Parse(Console.ReadLine()); /* linha para o recebimento do valor na variável comprimento **/

volume = altura * largura * comprimento; /* linha de cálculo do volume da caixa **/

Console.WriteLine($"O volume da caixa é: {volume:F4} m³"); /* linha a impressão do resultado do cálculo do volume com o uso de interpolação de uma cadeia de caracteres  **/