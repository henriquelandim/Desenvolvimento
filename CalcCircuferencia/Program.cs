/*Objetivo criar uma calculadora que calcula a area, a circunferencia e o diametro de um circulo
tendo como informação o raio, para o diametro */


using System; 

namespace CalcCircuferencia
{
    class Program
    {
        static void Main(string[] args)
        {   double pi = 3.14/*15926535897932384626433832795028841971*/; Console.WriteLine ("Especifique o raio do circulo:");
			double raio = double.Parse (Console.ReadLine ());
            Console.WriteLine ("Diâmetro = " +(raio+raio));
			Console.WriteLine ("Circunferência = "+(2 * pi * raio)); //.ToString());
			Console.WriteLine ("Área = "+(pi * (raio * raio)).ToString());
        }
    }
}
