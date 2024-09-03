using System;

namespace 2
{
    public class classeFib
    {
        static bool PertenceSequenciaFibonacci(int numero){

        int a = 0;
        int b = 1;

        while (b < numero)
        {
             int temp = a;
             a = b;
             b = temp + b;
        }
            return b == numero;
        }
    }
}