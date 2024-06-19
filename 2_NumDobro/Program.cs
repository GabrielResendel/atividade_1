using System;

namespace NumDobro
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Olá, digite um numero: ");
            int num = Int32.Parse(Console.ReadLine());
            string res = num.ToString();

             Console.WriteLine($"O dobro de {num} é: {num * 2}");
        }
    }
}

