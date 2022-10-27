using System;

namespace CollectionsQueue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            //entrou: van
            Enfileirar("van");
            //entrou: kombi
            Enfileirar("kombi");
            //entrou: guincho
            Enfileirar("guincho");
            //entrou: pickup
            Enfileirar("pickup");
            //carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                var veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();

                if (pedagio.Any())
                {
                    var proximo = pedagio.Peek();
                    Console.WriteLine($"Veiculo: {proximo} está fazendo o pagamento");
                }
                    
            }
            
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA: ");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }

    }
}
