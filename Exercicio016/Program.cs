// See https://aka.ms/new-console-template for more information

/* 
 * Fazer uma aplicação que receba 10 valores em um VETOR e os exiba na ordem escolhido pelo usuário, crescente ou decrescente.
 **/

// declaração das variaveis
bool sair;
int opcUsuario;
double[] numVet = new double[10];

// atribuição do valor falso a variavel 'sair' que será usada no looping 'while'
sair = false;

// repetição para adicionar valor a matriz de 10 números
for (int i = 0; i < numVet.Length; i++)
{

    Console.WriteLine("==================================================\n" +
                      "        Digite o valor do {0}º número:            \n" +
                      "==================================================", i+1);
    numVet[i] = double.Parse(Console.ReadLine());
    Console.Clear();

}

// looping de repetição para o usuário escolher a ordem que a matriz será exibida 
while (sair != true)
{
    Console.WriteLine("==================================================\n" +
                      "                        MENU                      \n" +
                      "==================================================\n" +
                      "[1] - Mostrar valores decrescentes.\n" +
                      "[2] - Mostrar valores acendentes.\n" +
                      "[3] - Sair.\n" +
                      "==================================================");
    opcUsuario = int.Parse(Console.ReadLine());

    // seleção e execução da escolha digitada pelo usuário 
    switch (opcUsuario)
    {
        // mostra os valores na ordem decrescente
        case 1:

            Console.WriteLine("==================================================\n" +
                              "                        MENU                      \n" +
                              "==================================================\n" +
                              "[1] - Mostrar valores decrescentes.\n" +
                              "[2] - Mostrar valores acendentes.\n" +
                              "[3] - Sair.\n" +
                              "==================================================");
            Array.Sort(numVet);
            Array.Reverse(numVet);
            foreach (double i in numVet)
            {
                Console.WriteLine("{0:F2}", i);
            }
            
            break;
        
        // mostra os valores na ordem crescente
        case 2:
  
            Console.WriteLine("==================================================\n" +
                              "                        MENU                      \n" +
                              "==================================================\n" +
                              "[1] - Mostrar valores decrescentes.\n" +
                              "[2] - Mostrar valores acendentes.\n" +
                              "[3] - Sair.\n" +
                              "==================================================");
            Array.Sort(numVet);
            foreach (double i in numVet)
            {
                Console.WriteLine("{0:F2}", i);
            }
            break;
        
        // executa a saida do looping 'while'
        case 3:
            sair = true;
            break;

        // mensagem para caso seja digitado outros valores que não os especificados acima
        default:
            Console.WriteLine("Opção inválida!");
            break;

    }

}

// limpa a tela do console e emite a mensagem de saída
Console.Clear();
Console.WriteLine("==================================================\n" +
                  "                      SAINDO                      \n" +
                  "==================================================");
