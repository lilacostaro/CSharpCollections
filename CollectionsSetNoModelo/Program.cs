using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsSetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos declarar o curso
            Curso csharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");
            //... e adicionar3 aulas a esse curso
            //Trabalhando com listas - 21 minutos
            //Criando uma aula - 20 minutos
            //Modelando com Coleções - 24 minutos

            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            //um aluno tambem tem matricula
            //Vamos criar a classe Aluno com Nome e NumeroMatricula

            //Instanciando 3 alunos com suas matriculas
            //Harry Potter - 56178
            //Hermione Granger - 34672
            //Rony Wesley - 17645

            Aluno a1 = new Aluno("Harry Potter", 56178);
            Aluno a2 = new Aluno("Hermione Granger", 34672);
            Aluno a3 = new Aluno("Rony Wesley", 17645);

            //Precisamos matricular os alunos no Curso, criando um metodo
            csharpColecoes.Matricular(a1);
            csharpColecoes.Matricular(a2);
            csharpColecoes.Matricular(a3);

            //Imprimindo os alunos matriculados
            //no formato "[Nome: , Matrícula: ]"
            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach(var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            //Imprimir: O alino a1 está matriculado?
            Console.WriteLine($"O aluno a1 {a1.Nome} está matrículado?");

            //Criar um método EstaMatriculado
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            Aluno harry = new Aluno("Harry Potter", 56178);
            Console.WriteLine($"Potter está matriculado? {csharpColecoes.EstaMatriculado(harry)}");

            //Mas a1 == a harry?
            Console.WriteLine($"a1 == a harry? {a1 == harry}");

            //o que ocorreu? a1 é equals a harry?
            Console.WriteLine($"a1 é equals a harry? {a1.Equals(harry)}");

            //São diferentes precisamos implementar Equals()

            //limpando o console
            Console.Clear();
            //Já temos o método para saber se o aluno está matriculado.
            //Mas agora precisamos buscar pelo numero de matricula
            //pergunta: "Quemé o aluno com matricula 56178?"
            Console.WriteLine("Quemé o aluno com matricula 17645?");
            //implementando Curso.BuscandoMatriculado
            Aluno aluno17645 = csharpColecoes.BuscandoMatriculado(17645);
            //Imprimindo o aluno encontrado
            Console.WriteLine($"Aluno17645: {aluno17645}");

            //Funciona! Mas essa busca é eficinte?
            //Introduzindo uma nova coleção: dicionário
            //Um dicionario permite associar uma chave (no caso, matricula) a um valor (o aluno)
            //Vamos implementar um dicionario da aluos em Curso

            //pergunta: "Quemé o aluno com matricula 56178?"
            Console.WriteLine("Quemé o aluno com matricula 56178?");
            //implementando Curso.BuscandoMatriculado
            Aluno aluno5618 = csharpColecoes.BuscandoMatriculado(5618);
            Console.WriteLine($"Aluno5618: {aluno5618}");

            //e se tentarmos adicionar outro aluno com a mesma chave?
            Aluno fred = new Aluno("Fred Wesley", 17645);
            //csharpColecoes.Matricular(fred);
            //e se quisermos trocar o aluno que tem a mesma chave?
            csharpColecoes.SubstituiAluno(fred);
            //pergunta: "Quem é o aluno 17645 agora?"
            Console.WriteLine("Quem é o aluno 17645 agora?");
            aluno17645 = csharpColecoes.BuscandoMatriculado(17645);
            Console.WriteLine($"Aluno17645: {aluno17645}");
        }
    }
}
