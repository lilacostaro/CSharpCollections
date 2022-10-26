using System;

namespace Collections_Arrays

{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Console.WriteLine(aulas);
            imprimir(aulas);
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulaIntro = "Trabalhando com Arrays";
            imprimir(aulas);

            aulas[0] = aulaIntro;
            imprimir(aulas);

            Console.WriteLine($"Aula modelando está no índice {Array.IndexOf(aulas, aulaModelando)}");
            Console.WriteLine($"O último índice de Aula modelando é {Array.IndexOf(aulas, aulaModelando)}");

            Array.Reverse(aulas);
            imprimir(aulas);

            Array.Reverse(aulas);
            imprimir(aulas);

            Array.Resize(ref aulas, 2);
            imprimir(aulas);

            Array.Resize(ref aulas, 3);
            imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            imprimir(aulas);

            Array.Sort(aulas);
            imprimir(aulas);

            string[] copia  = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            imprimir(copia);

            string[] clone = aulas.Clone() as string[];
            imprimir(clone);

            Array.Clear(clone, 1, 2);
            imprimir(clone);
        }

        private static void imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}

