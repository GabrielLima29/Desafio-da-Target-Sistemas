using System;

namespace 2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classeFib classefib = new classeFib();
         Console.Write("Informe um número: ");
         int numeroInformado = Convert.ToInt32(Console.ReadLine());

         bool pertenceSequencia = PertenceSequenciaFibonacci(numeroInformado);

            if (pertenceSequencia)
             {
               Console.WriteLine($"O número {numeroInformado} pertence à sequência de Fibonacci.");
             }
            else
            {
             Console.WriteLine($"O número {numeroInformado} não pertence à sequência de Fibonacci.");
            }
        }
    }
}