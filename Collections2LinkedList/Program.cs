using System;

namespace Collections2SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vamos criar um dicionario de alunos
            //VT, Vanessa, 34672
            //AL, Ana, 56178
            //RN, Rafael, 17645
            //WM, Wanderson, 11287
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 56178));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            //Imprimindo
            foreach (var aluno in alunos) 
            {
                Console.WriteLine(aluno);
            }

            //Vamos remover: AL
            alunos.Remove("AL");
            //vamos adicionar: MO
            alunos.Add("MO", new Aluno("Marcelo", 12345));

            //Imprimindo
            Console.WriteLine();
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            //Apresentando uma nova coleção... SortedList
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