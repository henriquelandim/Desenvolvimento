using System;

namespace progJurosComposto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCliente, nomeinvestimento;
            decimal valorInv, valorIncre, valorReceber, rentabiMedia;
            int anoInv, increme;

            Console.WriteLine("##   Olá, sou o Jurinho! o algoritimo que te ajuda com seus investimentos");
            Console.WriteLine("##   Qual é o seu nome?");
            nomeCliente = Console.ReadLine();
            Console.WriteLine("##   " + nomeCliente + ", bora Calcular então");
            Console.WriteLine("##   No que cê vai investir?");
            nomeinvestimento = Console.ReadLine();
            Console.WriteLine("##   Hmmm, " + nomeinvestimento + " é bem interessante mesmo, mas vamos lá quanto pretende investir?");
            valorInv = decimal.Parse(Console.ReadLine());
            Console.WriteLine("##   " + valorInv + " é uma boa quantia, mas por quantos anos deseja aplicar?");
            anoInv = int.Parse(Console.ReadLine());
            Console.WriteLine("##   " + anoInv + " anos, uau que legal!! e a rentabilidade media anual quanto é? ");
            rentabiMedia = decimal.Parse(Console.ReadLine());
            Console.WriteLine("##   " + nomeCliente + ", deseja incrementar sobre esse investimento com uma quantia fixa mensalmente?");
            Console.WriteLine("##   se sim digite 1, se não digite 2");
            increme = int.Parse(Console.ReadLine());

           
            valorReceber=0;
            if (increme == 1)
            {
                Console.WriteLine("##   Qual será o valor incrementado mensalmente?");
                valorIncre = decimal.Parse(Console.ReadLine());
            }
            else if (increme == 2)
            {
                //aqui entra, o calculo
                // valorReceber = valorInvestimento+(1.valorPercentualRentavel)^peloNumeroDeAnos
                (valoInv+(1.rentabiMedia)^anoInv //agora como elevo a potencia?
                Console.WriteLine("##   " + nomeCliente + ", o resultado do seu investimento sera de: " + valorReceber);
            }
            else
            {
                Console.WriteLine("1 ou 2, não tem outra opção");
            }
           
        }
    }
}
