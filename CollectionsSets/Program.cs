using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsSets
{
    class Program
    {
        static void Main(string[] args)
        {
            // SETS = CONJUNTOS

            //Duas propriedades do Set
            //1. Não permite duplicidade
            //2. Os elementos não são mantidos em ordem especifica

            // Declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            //Adicionando alunos: Camila, Harry, Brisa
            alunos.Add("Camila");
            alunos.Add("Harry");
            alunos.Add("Brisa");

            //imprimindo
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            //Qual a diferença de set para uma lista??
            //Adicionando: Tom, Hemp e Izzy
            alunos.Add("Hemp");
            alunos.Add("Tom");
            alunos.Add("Izzy");
            Console.WriteLine(string.Join(", ", alunos));

            //Removendo Camila e Adicionando Isacc
            alunos.Remove("Camila");
            alunos.Add("Isacc");
            //Imprimindo de novo
            Console.WriteLine(string.Join(", ", alunos));

            //Adicionando alguns alunos de novo
            alunos.Add("Hemp");
            alunos.Add("Tom");
            alunos.Add("Izzy");
            Console.WriteLine(string.Join(", ", alunos));

            //Qual a vantagem do set sobre a lista? look-up!
            //desempenho HashSet x List: escalabilidade x memória
            /// mudar iset para icollectio para deixar mais flexivel
            //ordenando; Sort
            //alunos.Sort();
            ///copiando: alunosEmLista
            List<string> alunosEmLista = new List<string>(alunos);
            ///ordenando copia
            alunosEmLista.Sort();
            ///imprimindo copia
            Console.WriteLine(string.Join(", ", alunosEmLista));
        }
    }
}
