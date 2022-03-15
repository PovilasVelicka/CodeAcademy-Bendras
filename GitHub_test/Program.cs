using System;
using Academy_NamuDarbai;
namespace GitHub_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userAnswers;
            string[] Questions = new string[]
            {
                "Įvesk skaičių A: ",
                "Įvesk skaičių B: "
            };
            ConsoleReader.ReadInt(Questions, out userAnswers);
            Console.WriteLine($"Atsakymas: {userAnswers[0]} + {userAnswers[1]} = {userAnswers[0]+ userAnswers[1]}");
        }
    }
}
