// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o volume de uma esfera. Mostrar como declarar variáveis, utilizar o console 
 * e o método pow.
 **/

// declaração das variáveis do tipo double e int
double raio, pi, volume;
int exp;

// declara o valor de pi e salva na variavel
pi = Math.PI;

// imprime a mensagem na tela sem quebra de linha e lê o valor digitado pelo usuario, em seguida salva esse valor na variavel
Console.Write("Digite o valor do raio da esfera (em cm): ");
raio = double.Parse(Console.ReadLine());

// declara o valor do expoente
exp = 3;

// efetua o cálculo do volume
volume = (4 * pi * Math.Pow(raio, exp)) / 3;

// imprime na tela o resultado do volume da esfera
Console.WriteLine("O valor do volume da esfera de raio {0:F2} cm é: {1:F2} cm³", raio, volume);