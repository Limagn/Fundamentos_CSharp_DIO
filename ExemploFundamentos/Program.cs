using ExemploFundamentos.Common.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");



Console.WriteLine("Percorrendo o Array com o FOR");
for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição Nº {i} - {listaString[i]}");
}


Console.WriteLine("Percorrendo o Array com o FOREACH");
int j = 0;
foreach(string estado in listaString)
{
    Console.WriteLine($"Posição Nº {j} - {estado}");
    j++;
}








































//int[] arrayInteiros = new int[4];

//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;
//arrayInteiros[3] = 1;


//// O Array nasce e termina com o mesmo tamanho, portanto o resize por baixo dos panos, copia o array de referencia e aumenta o tamanho.
////Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


//// Copiando o array, assim como o resize faz
//int[] arrayInteirosDobrados = new int [arrayInteiros.Length * 2];
//Array.Copy(arrayInteirosDobrados, arrayInteiros, arrayInteiros.Length);


//Console.WriteLine("Percorrendo o Array com o FOR");
//for (int i = 0; i < arrayInteiros.Length; i++)
//{
//    Console.WriteLine($"Posição Nº {i} - {arrayInteiros[i]}");
//}




























// Foreach possui menos código, porém não é possível utilizar contador, sem ter declarado anteriormente.
//int contador = 0;
//Console.WriteLine("Percorrendo o Array com o FOREACH");
//foreach (int num in arrayInteiros)
//{
//    Console.WriteLine($"Posição Nº {contador} - {num}");
//    contador++;
//}







































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
