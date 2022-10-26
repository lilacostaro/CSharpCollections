using System;
using System.Collections.Immutable;

namespace CollectionsListasSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(csharpColecoes.Aulas);

            // adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

            // imprimir
            Imprimir(csharpColecoes.Aulas);

            // ordenar a lista de aulas
            //csharpColecoes.Aulas.Sort();
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            // Ordenar a copia
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            // Totalizar o tempo do curso
            Console.WriteLine($"Tempo total do curso em minutos: {csharpColecoes.TempoTotal}");

            Console.WriteLine(csharpColecoes);

        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
