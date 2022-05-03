// See https://aka.ms/new-console-template for more information

/* 
 * Calcular a média harmônica das notas de um aluno.
 * */

// declaração das variaveis para a nota e média
double n1, n2, n3, n4, mediaHarm;

// imprime a mensagem na tela e lê o valor digitado para salvar na variavel
Console.Write("Digite o valor da primeira nota: ");
n1 = double.Parse(Console.ReadLine());

// imprime a mensagem na tela e lê o valor digitado para salvar na variavel
Console.Write("Digite o valor da segunda nota: ");
n2 = double.Parse(Console.ReadLine());

// imprime a mensagem na tela e lê o valor digitado para salvar na variavel
Console.Write("Digite o valor da terceira nota: ");
n3 = double.Parse(Console.ReadLine());

// imprime a mensagem na tela e lê o valor digitado para salvar na variavel
Console.Write("Digite o valor da quarta nota: ");
n4 = double.Parse(Console.ReadLine());

// efetua o calculo e salva na variavel mediaHarm
mediaHarm = (4.0f) / ((1 / n1) + (1 / n2) + (1 / n3) + (1 / n4));

// imprime a mensagem na tela com o retorno do calculo da media harmonica
Console.WriteLine("O resultado da média harmônica com as quatros notas é: {0:F2}", mediaHarm);

