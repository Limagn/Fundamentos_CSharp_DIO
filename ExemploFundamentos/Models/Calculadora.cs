using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public int Soma(int x, int y)
        {
            int soma = x + y;
            return soma;
        }
        public int Subtracao(int x, int y)
        {
            int subtracao = x - y;
            return subtracao;
        }
        public int Multiplicacao(int x, int y)
        {
            int multiplicacao = x * y;
            return multiplicacao;
        }
        public int Divisao(int x, int y)
        {
            int divisao = x / y;
            return divisao;
        }
    }
}
