using System;

namespace CollectionsSortedDicitionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 56178));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));
            Console.WriteLine();
            foreach (var aluno in sorted)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}

