// See https://aka.ms/new-console-template for more information

/* 
 * Utilizar a propriedade distributiva entre 4 números nos quais devem ser somados e 
 * multiplicados entre si. Simples utilização de entrada, saída e declaração de 
 * variáveis:
 **/

// declaração das variaveis: número 1 a 4 e o resultado
double nA, nB, nC, nD, res, somaAB, somaAC, somaAD, somaBC, somaBD, somaCD, multAB, multAC, multAD, multBC, multBD, multCD;

// imprime a mensagem na tela e em seguida adiciona o valor digitado a variavel
Console.Write("Digite o valor do número 1: ");
nA = double.Parse(Console.ReadLine());

// imprime a mensagem na tela e em seguida adiciona o valor digitado a variavel
Console.Write("Digite o valor do número 2: ");
nB = double.Parse(Console.ReadLine());

// imprime a mensagem na tela e em seguida adiciona o valor digitado a variavel
Console.Write("Digite o valor do número 3: ");
nC = double.Parse(Console.ReadLine());

// imprime a mensagem na tela e em seguida adiciona o valor digitado a variavel
Console.Write("Digite o valor do número 4: ");
nD = double.Parse(Console.ReadLine());

// efetua a propriedade distributiva da soma
somaAB = nA + nB;
somaAC = nA + nC;
somaAD = nA + nD;
somaBC = nB + nC;
somaBD = nB + nD;
somaCD = nC + nD;

// efetua a propriedade distributiva da multiplicação
multAB = nA * nB;
multAC = nA * nC;
multAD = nA * nD;
multBC = nB * nC;
multBD = nB * nD;
multCD = nC * nD;

// imprime na tela o resultado da propriedade distributiva da soma
Console.WriteLine("O valor da soma: {0} + {1} = {2}", nA, nB, somaAB);
Console.WriteLine("O valor da soma: {0} + {1} = {2}", nA, nC, somaAC);
Console.WriteLine("O valor da soma: {0} + {1} = {2}", nA, nD, somaAD);
Console.WriteLine("O valor da soma: {0} + {1} = {2}", nB, nC, somaBC);
Console.WriteLine("O valor da soma: {0} + {1} = {2}", nB, nD, somaBD);
Console.WriteLine("O valor da soma: {0} + {1} = {2}", nC, nD, somaCD);

// imprime na tela o resultado da propriedade distributiva da multiplicação
Console.WriteLine("O valor da multiplicação: {0} x {1} = {2}", nA, nB, multAB);
Console.WriteLine("O valor da multiplicação: {0} x {1} = {2}", nA, nC, multAC);
Console.WriteLine("O valor da multiplicação: {0} x {1} = {2}", nA, nD, multAD);
Console.WriteLine("O valor da multiplicação: {0} x {1} = {2}", nB, nC, multBC);
Console.WriteLine("O valor da multiplicação: {0} x {1} = {2}", nB, nD, multBD);
Console.WriteLine("O valor da multiplicação: {0} x {1} = {2}", nC, nD, multCD);

/*
 * a primeira lógica pensada foi a seguinte:
 * 
 * efetua o calculo na formula n1( n2 + n2 + n03)
 * res = (n1*n2)+(n1*n3)+(n1*n4);
 * 
 * a conta também pode ser feita da seguinte forma:
 * res = n1 * (n2 + n3 + n4);
 * 
 * imprime na tela o resultado da conta e mostra como se deu a propriedade distributiva
 * Console.WriteLine("O resultado final da propriedade distributiva {0}({1}+{2}+{3}) é igual a: {4}", n1, n2, n3, n4, res);
 * 
 * */
