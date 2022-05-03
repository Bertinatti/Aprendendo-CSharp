// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o produto e a adição de duas frações.
 **/

// declaração das variaveis
double num1, num2, den1, den2, fracao1, fracao2, somaFracao, multFracao;

// impressão da mensagem na tela e leitura do valor digitado que será salvo na variavel
Console.Write("Digite o valor do primeiro numerador: ");
num1 = double.Parse(Console.ReadLine());

// impressão da mensagem na tela e leitura do valor digitado que será salvo na variavel
Console.Write("Digite o valor do primeiro denominador: ");
den1 = double.Parse(Console.ReadLine());

// impressão da mensagem na tela e leitura do valor digitado que será salvo na variavel
Console.Write("Digite o valor do segundo numerador: ");
num2 = double.Parse(Console.ReadLine());

// impressão da mensagem na tela e leitura do valor digitado que será salvo na variavel
Console.Write("Digite o valor do segundo denominador: ");
den2 = double.Parse(Console.ReadLine());

// efetuando o calculo das frações
fracao1 = (double) num1 / den1;
fracao2 = (double) num2 / den2;

// efetuando o calculo da soma e da multiplicação das frações
somaFracao = (double) fracao1 + fracao2;
multFracao = (double) fracao1 * fracao2;

// imprimindo na tela o resultado da soma e do produto das frações
Console.WriteLine("A soma da fração {0}/{1} + {2}/{3} = {4:F2}", num1, den1, num2, den2, somaFracao);
Console.WriteLine("O produto da fração {0}/{1} + {2}/{3} = {4:F2}", num1, den1, num2, den2, multFracao);
