// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o volume de uma lata de óleo.
 * Considerar a lata como um cilindro.
 * Vcilindro = pi * raio² * altura
 * */

// declaração das variaveis
double pi, raio, altura, volume;

// imprimindo a mensagem na tela e recebendo os valores das variaveis
Console.Write("Digite o valor do raio (em m): ");
raio = double.Parse(Console.ReadLine());
Console.Write("Digite o valor da altura (em m): ");
altura = double.Parse(Console.ReadLine());

// colocando o valor de pi na variavel
pi = Math.PI;

// efetuando o calculo do volume do cilindro
volume = pi * Math.Pow(raio, 2) * altura;

// imprimindo o resultado do volume na tela
Console.WriteLine("O volume da lata de óleo de raio {0:F2} m é {1:F4} m³", raio, volume);

