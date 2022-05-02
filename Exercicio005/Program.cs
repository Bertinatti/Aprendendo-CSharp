// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o consumo de combustível por Km. Mostrar de forma simples os conceitos de 
 * entrada/saída de dados e declaração de variáveis:
 * */

double kmInicio, kmFinal, combustivel, consumo, kmDist, precoComb, gastoTot; /* declaração das variaveis utilizadas no exercício **/

Console.Write("Digite a Kilometragem inicial: "); // imprime na tela a frase
kmInicio = double.Parse(Console.ReadLine()); // salva na variável o valor digitado no terminal
Console.Write("Digite a Kilometragem final: "); // imprime na tela a frase
kmFinal = double.Parse(Console.ReadLine()); // salva na variável o valor digitado no terminal

// efetua o cálculo da kilometragem do percurso 
kmDist = kmFinal - kmInicio;

// efetua a impressão na tela e em seguida salva na variavel
Console.Write("Digite quantos litros de combustível foram gasto nesta viagem: "); 
combustivel = double.Parse(Console.ReadLine()); 

// efetua a impressão na tela e em seguida salva na variavel
Console.Write("Digite o preço do combustível: R$ "); 
precoComb = double.Parse(Console.ReadLine());

// efetua o cálculo para saber o rendimento em Km/l
consumo = kmDist / combustivel;

// efetua o cálculo para definir o gasto total da viagem, devido ao consumo de combustível
gastoTot = combustivel * precoComb;

// imprime na tela o resultado dos cálculos
Console.WriteLine("O total gasto com o combustível é de: R$ {0:F2}", gastoTot);
Console.WriteLine("O rendimento do carro é de {0} Km/l", consumo);

