using System;

namespace Calculo_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, peso;
            char sexo;

            Console.WriteLine("Informe sua altura em metros , exemplo  1,80 , 1,50 :");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo sendo Masculino - M e Feminino - F  :");
            sexo = Convert.ToChar(Console.ReadLine());


          

            if((sexo == 'M') || (sexo == 'm'))
            {
                peso = altura * 72.2 - 58;
                Console.WriteLine("Seu peso ideal eh : {0}", peso);
            }
            else if((sexo == 'F') || (sexo == 'f'))
                {
                    peso = altura * 62.1 - 44.7;
                    Console.WriteLine("Seu peso ideal eh : {0}", peso);
                }
                else
                {
                    Console.WriteLine("Ops!! ?Informe  M ou F na hora de informar o sexo.");
                
            }

        }
    }
}
