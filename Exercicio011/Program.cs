// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o salário total de um vendedor.
 * Será digitado o código do vendedor, o salário fixo, o total de vendas, o percentual ganho em cima das vendas e será calculado o salário final do vendedor.
 * */

// declaração das variáveis
int codVend; // o código do vendedor será um valor inteiro
double salVend, totVendas, percVend, comissao, salTot;

// imprime a mensagem na tela e lê o valor digitado para guardar na variavel especifica
Console.Write("Digite o código do vendedor: ");
codVend = int.Parse(Console.ReadLine());
Console.Write("Digite o salário fixo: ");
salVend = double.Parse(Console.ReadLine());
Console.Write("Digite o total de vendas: R$ ");
totVendas = double.Parse(Console.ReadLine());
Console.Write("Digite o percentual da comissão (0 a 100): ");
percVend = double.Parse(Console.ReadLine());

// efetuando o calculo da comissao
comissao = totVendas * ((double)percVend / 100);

// efetuando o calculo do salario total
salTot = salVend + comissao;

// imprimindo na tela o código do vendedor e quanto ele irá receber esse mês
Console.WriteLine("Vendedor {0}, esse mês seu salário será de {1:c}", codVend, salTot);
