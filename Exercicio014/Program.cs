// See https://aka.ms/new-console-template for more information

/* 
 * Calcular a Média Ponderada de duas provas realizadas por um aluno.
 **/

// declaração para os valores das notas, dos pesos das notas e pro calculo da média
double n1, n2, p1, p2, mediaPond;

// imprime na tela a mensagem e salva na variavel o valor digitado pelo usuario
Console.Write("Digite o valor da primeira nota: ");
n1 = double.Parse(Console.ReadLine());

// imprime na tela a mensagem e salva na variavel o valor digitado pelo usuario
Console.Write("Digite o valor da segunda nota: ");
n2 = double.Parse(Console.ReadLine());

// imprime na tela a mensagem e salva na variavel o valor digitado pelo usuario
Console.Write("Digite o valor do peso da primeira nota: ");
p1 = double.Parse(Console.ReadLine());

// imprime na tela a mensagem e salva na variavel o valor digitado pelo usuario
Console.Write("Digite o valor do peso da segunda nota: ");
p2 = double.Parse(Console.ReadLine());

// efetuando o calculo da media ponderada
mediaPond = ((n1 * p1) + (n2 * p2)) / (p1 + p2);

// imprimindo a mensagem final com o valor da media ponderada
Console.WriteLine("O valor da média ponderada das notas {0:F2} e {1:F2}, com peso respectivo de {2:F2} e {3:F2}, é: {4:F2}", n1, n2, p1, p2, mediaPond);
