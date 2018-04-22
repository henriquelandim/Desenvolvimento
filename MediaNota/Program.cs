/*Programa desenvolvido para calculo de quanto o aluno precisara tirar p passar no 4° bimestre  */

using System;
using System.IO;

namespace MediaNota
{
    class Program
    {
        static void Main(string[] args)
            {   Console.Clear();

                Console.WriteLine("Digite seu nome completo");
                string NomeAluno = Console.ReadLine();

                Console.WriteLine("Especifique a disciplina.");
                string materia = Console.ReadLine();
                
                Console.WriteLine("qual é a media? (adicione um 0, EX: se for '6' coloque '60').");
                double media = double.Parse (Console.ReadLine());

                Console.WriteLine ("Digite as notas do 1° bimestre");
			    double nota1 = double.Parse (Console.ReadLine());

			    Console.WriteLine("Digite a nota do 2° bimeste");
                double nota2 = double.Parse (Console.ReadLine());

			    Console.WriteLine("Digite a nota do 3° bimeste");
                double nota3 = double.Parse (Console.ReadLine());
                
			    double nota4 = (media-((nota1*2)+(nota2*2)+(nota3*3)))/ 3;
                
                StreamWriter arquivo = new StreamWriter("TicketAluno.txt");
                arquivo.WriteLine("Aluno: "+NomeAluno);
                arquivo.WriteLine("Disciplina: "+materia);
                arquivo.WriteLine("nota 1° bimestre: "+nota1);
                arquivo.WriteLine("nota 2° bimestre: "+nota2);
                arquivo.WriteLine("nota 3° bimestre: "+nota3);
                arquivo.WriteLine ("Nota mínima 4° bimestre = " + (nota4.ToString("n2")));
                arquivo.Close();

			Console.WriteLine("Aluno: "+NomeAluno);
            Console.WriteLine("Disciplina: "+materia);
            Console.WriteLine("nota 1° bimestre: "+nota1);
            Console.WriteLine("nota 2° bimestre: "+nota2);
            Console.WriteLine("nota 3° bimestre: "+nota3);
            Console.WriteLine ("Nota mínima 4° bimestre = " + (nota4.ToString("n2")));

            
        }
    }
}
