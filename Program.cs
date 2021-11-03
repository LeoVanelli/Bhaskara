using System;

namespace Bhaskara
{
    class Delta{
        public double _a = default;
        public double _b = default;

        public double _c = default;

        public double _resultadoDelta = default;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delta _delta = new Delta(); 
            Console.WriteLine("--- Equação do segundo grau ---");

            Console.Write("(A): ");
            double.TryParse(Console
            .ReadLine()
            .ToString(), out _delta._a);
            Console.Write("(B): ");
            double.TryParse(Console
            .ReadLine()
            .ToString(), out _delta._b);
            Console.Write("(C): ");
            double.TryParse(Console
            .ReadLine()
            .ToString(), out _delta._c);
            
            if(_delta._a == 0){
                Console.WriteLine("\nNão é uma equação de segundo grau!");
            }
            else{
                _delta._resultadoDelta = Math.Pow(_delta._b,2)-4*_delta._a*_delta._c;
                if(_delta._resultadoDelta < 0 ){
                    Console.WriteLine($"\nComo delta é = {_delta._resultadoDelta}, a equação não possui raízes reais!");
                }
                else{
                    double _raiz1 = ((_delta._b * -1) + Math.Sqrt(_delta._resultadoDelta))/ 2 * _delta._a;
                    double _raiz2 = ((_delta._b * -1) - Math.Sqrt(_delta._resultadoDelta))/ 2 * _delta._a;

                    Console.Write($"\nResultado: (+)X¹ = {Math.Round(_raiz1,2)} / (-)X² = {Math.Round(_raiz2,2)}");
                }
            }
        }
    }
}
