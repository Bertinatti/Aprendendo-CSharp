// See https://aka.ms/new-console-template for more information

/* 
 * Ler dois números reais e realizar a operação matemática escolhida pelo usuário.
 **/

// declaração das variaveis
double n1, n2, res;
int opcUser;
bool sair;

sair = false;

// imprime na tela a mensagem e lê o valor digitado para salvar na variavel
Console.Write("Digite o valor do primeiro número: ");
n1 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do segundo número: ");
n2 = double.Parse(Console.ReadLine());

// limpa a tela do terminal
Console.Clear();

// exibicação de um pequeno menu para escolha da operação após digitar os dois números
while (sair!=true)
{

    Console.WriteLine("=====================================================\n" +
                      "                      CALCULADORA                    \n" +
                      "=====================================================\n" +
                      "[1] - Adição.\n" +
                      "[2] - Subtração.\n" +
                      "[3] - Multiplicação.\n" +
                      "[4] - Divisão.\n" +
                      "[5] - Sair.\n" +
                      "=====================================================\n");
    opcUser = int.Parse(Console.ReadLine());

    switch (opcUser)
    {
        // operando a adição
        case 1:
            res = n1 + n2;
            Console.WriteLine("O resultado da soma: {0:F2} + {1:F2} = {2:F2}", n1, n2, res);
            break;

        // operando a subtração
        case 2:
            res = n1 - n2;
            Console.WriteLine("O resultado da subtração: {0:F2} - {1:F2} = {2:F2}", n1, n2, res);
            break;

        // operando a multiplicação
        case 3:
            res = n1 * n2;
            Console.WriteLine("O resultado da subtração: {0:F2} * {1:F2} = {2:F2}", n1, n2, res);
            break;

        // operando a divisão
        case 4:
            res = n1 / n2;
            Console.WriteLine("O resultado da subtração: {0:F2} / {1:F2} = {2:F2}", n1, n2, res);
            break;

        // operando a subtracao
        case 5:
            sair = true;
            break;

        default:
            Console.WriteLine("Insira outra opção, opção inválida!");
            break;
            Console.Clear();
    }
}

