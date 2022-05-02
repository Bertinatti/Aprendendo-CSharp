// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o quadrado da diferença entre dois números quaisquer. Demonstrar de 
 * forma simples o uso de consoles, entrada e saída de dados e o método pow:
 **/

// declaração das variaveis para: número 1 e 2, expoente, diferença dos números 1 e 2 e resultado do quadrado dessa diferença
double n1, n2, exp, dif, res;

// efetua a impressão da mensagem no terminal e salva na variavel o valor digitado no terminal
Console.Write("Digite o valor do número 1:");
n1 = double.Parse(Console.ReadLine());

// efetua a impressão da mensagem no terminal e salva na variavel o valor digitado no terminal
Console.Write("Digite o valor do número 2:");
n2 = double.Parse(Console.ReadLine());

// efetua o cálculo da diferença dos dois números digitados, na ordem de digitação
dif = n1 - n2;

// salva o valor do expoente para uso futuro
exp = 2;

// salva na variavel res o valor da potenciação ao quadrado da diferença (produtos notáveis) dos dois números digitados
res = Math.Pow(dif, exp);

// imprime na tela o resultado da conta de potenciação
Console.WriteLine("O resultado do quadrado da diferença dos números {0:F2} e {1:F2} é igual a: {2:F2}", n1, n2, res);
