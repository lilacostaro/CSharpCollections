using System;

namespace CollectionsLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imagine uma lista de frutas
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };
            //Vamos imprimir essa lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            //Adicionar um elemento ao final de uma lista é rápido
            //Porém inserir no meio da lista exige mais esforço computacional
            //Porque os elementos têm que ser deslocados para darem espaço ao novo elemento
            //E se tivermos que remover esse elemento, os elementos seguintes precisam ser deslocados de novo!
            //Quanto maior a lista, mais ineficiente é a inserção e remoção de elementos no meio dela!
            //Qual coleção é apropriada para inserção/remoção rápida?

            //Apresentando LISTA LIGADA (LINKED LIST):
            //- Elementos não precisametar em sequência em mémoria
            //- Cada elemento sabe quem é o anterior e o próximo
            //- Cada elemento é um "nó" que contém um valor
            //Como a ordem é mantida? Usando ponteiros

            //Instanciando uma nova lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();
            //Adicionando um dia qualquer: "quarta"
            var d4 = dias.AddFirst("quarta");
            //"quarta é o primeiro elemento da lista ligada
            //cada elemento é um nó: LinkedListNode<T>

            //Mas e o valor "quarta"? Está na propriedade d4.Value
            Console.WriteLine($"d4.Value: {d4.Value}");
            //E para adicionar mais itens? LinkedList não possui Add!
            //Podemos adicionar de 4 formas
            //1. Como primeiro nó
            //2. Como ultimo nó
            //3. Antes de um nó conhecido
            //4. Depois de um nó conhecido

            // Vamos adicionar segunda, antes de quarta:
            var d2 = dias.AddBefore(d4, "segunda");

            //Agora d4 e d2 estão ligados!
            //- d2.Next é igual a d4
            //- d4.Previous é igual a d2
            //continuando com nossa lista ligada, vamos adicionar terça depois de segunda
            var d3 = dias.AddAfter(d2, "terça");

            //Perceba que os ponteiros ou referencias de d2 e d4 foram redirecionados para d3!!
            //Vamos adicionar sexta depois de quarta
            var d6 = dias.AddAfter(d4, "sexta");

            //Sabado depois da sexta
            var d7 = dias.AddAfter(d6, "sabado");

            //quinta antes da sexta
            var d5 = dias.AddBefore(d6, "quinta");

            //domingo antes da segunda
            var d1 = dias.AddBefore(d2, "domingo");

            //Agora vamos imprimir a lista ligada
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
            //LinkedList NÃO DÁ suporte ao acesso de índice: dias[0]
            //por isso podemos fazer um laço foreach mas não um for!
            var quarta = dias.Find("quarta");
            Console.WriteLine(quarta.Value);

            //Para remover um elemento, podemos tanto remover tanto pelo valor quanto pela referencia no LinkedListNode
            //dias.remove("quarta"); ou dias.Remove(d4);

            dias.Remove(quarta);
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

        }
    }
}