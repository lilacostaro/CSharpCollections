using System;

namespace CollectionsSortedSets
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Conjunto de alunos
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            //Adicionar: Rafael Rollo
            alunos.Add("Rafael Rollo");
            //Adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            //Adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            //Adicionar: FABIO GUSHIKEN
            alunos.Add("FABIO GUSHIKEN");

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjunto = new HashSet<string>();
            //Este conjunto é subconjunto do outro? IsSubsetOf
            alunos.IsSubsetOf(outroConjunto);

            //Este conjunto é superconjunto do outro? IsSupersetOf
            alunos.IsSupersetOf(outroConjunto);

            //Os conjuntos contem os mesmos elementos? SetEquals
            alunos.SetEquals(outroConjunto);

            //Subtrai os elementos da outra coleção que também estão no conjunto
            alunos.ExceptWith(outroConjunto);

            //Intersecção dos conjuntos - IntersecWith
            alunos.UnionWith(outroConjunto);

            //Somente em um ou outro conjuntos - SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            //união de conjuntos - UnionWith
            alunos.UnionWith(outroConjunto);

        }
    }
}