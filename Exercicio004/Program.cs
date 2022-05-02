// See https://aka.ms/new-console-template for more information

/* 
 * Calcular o custo da criação de coelhos. Mostrar de forma simples e objetiva como
 * manipular os dados via console, declarar as variáveis e realizar operações algébricas.
 * 
 * A formula do custo da criação é: 
 * 
 * custo = (núm. coelho * 0,70) / 28
 * 
 * Retorna o resultado em reais.
 * */

int numCoelhos; /* declaração da variavel para receber a quantia de coelhos, que por se tratar de um 'animal' só há como existir quantidades inteiras, não fracionadas **/
double custo; /* declaração da variavel para realização da operação algébrica **/

Console.Write("Digite o número de coelhos: "); /* imprime na tela a mensagem sem a quebra de linha **/
numCoelhos = int.Parse(Console.ReadLine()); /* recebe o valor digitado no console e salva na variavel **/

custo = (numCoelhos * 0.70) / 28; /* realização da operação algébrica que será salva na variável custo **/

Console.WriteLine("O custo total para a criação de {0} coelhos é de: R$ {1:F2}", numCoelhos, custo); /* imprime na tela a mensagem com o resultado do custo da criação dos coelhos **/

