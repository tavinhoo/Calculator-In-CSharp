using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro numero: ");
            string firstNum = Console.ReadLine();
            Console.WriteLine("Digite o operador aritmético: ");
            string op = Console.ReadLine();
            Console.WriteLine("Digite o segundo numero: ");
            string secondNum = Console.ReadLine();

            Console.WriteLine(Calculadora(firstNum, secondNum, op));
        }
        public static double Calculadora(string x, string y, string n)
        {
            double resultado = 0;
            double num1 = Convert.ToDouble(x);
            char op = Convert.ToChar(n);
            double num2 = Convert.ToDouble(y);
            switch (op)
            {
                case '+':
                    return resultado = num1 + num2;
                case '-':
                    return resultado = num1 - num2;
                case '*':
                    return resultado = num1 * num2;
                case '/':
                    return resultado = num1 / num2;
            }
            return resultado;
        }
    }
}
