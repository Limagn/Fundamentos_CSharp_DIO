using ExemploFundamentos.Common.Models;


int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

Console.WriteLine("Percorrendo o Array com o FOR");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição Nº {i} - {arrayInteiros[i]}");
}

// Foreach possui menos código, porém não é possível utilizar contador, sem ter declarado anteriormente.
int contador = 0;
Console.WriteLine("Percorrendo o Array com o FOREACH");
foreach (int num in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contador} - {num}");
    contador++;
}







































//class Program
//{
//    static void Main(string[] args)
//    {
//        int? opcao;
//        do
//        {
//            Calculadora calc = new Calculadora();

//            Console.WriteLine("Digite o primeiro número inteiro:");
//            int primeiroNumero = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Digite o segundo número inteiro:");
//            int segundoNumero = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Digite o número da opção desejada:");
//            Console.WriteLine("1 - Soma");
//            Console.WriteLine("2 - Subtração");
//            Console.WriteLine("3 - Multiplicação");
//            Console.WriteLine("4 - Divisão");
//            Console.WriteLine("0 - Sair");

//            string validacao = Console.ReadLine();
//            while (validacao == null)
//            {
//                Console.WriteLine("Digite um número válido.");
//                validacao = Console.ReadLine();
//            }

//            opcao = Convert.ToInt32(validacao);

//            switch (opcao)
//            {
//                case 1:
//                    Console.WriteLine($"A soma entre {primeiroNumero} e {segundoNumero} é: " + calc.Soma(primeiroNumero, segundoNumero));
//                    break;
//                case 2:
//                    Console.WriteLine($"A subtração entre {primeiroNumero} e {segundoNumero} é: " + calc.Subtracao(primeiroNumero, segundoNumero));
//                    break;
//                case 3:
//                    Console.WriteLine($"A multiplicação entre {primeiroNumero} e {segundoNumero} é: " + calc.Multiplicacao(primeiroNumero, segundoNumero));
//                    break;
//                case 4:
//                    Console.WriteLine($"A divisão entre {primeiroNumero} e {segundoNumero} é: " + calc.Divisao(primeiroNumero, segundoNumero));
//                    break;
//                case 0:
//                    Console.WriteLine("Saindo do programa.");
//                    break;
//                default:
//                    Console.WriteLine("Opção inexistente.");
//                    break;
//            }
//        } while (opcao != 0);
//    }
//}
