using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsListasSomenteLeitura
{
    class Curso
    {
		private IList<Aula> aulas;

		public IList<Aula> Aulas

		{
			get { return new ReadOnlyCollection<Aula>(aulas); }
		}

		private string nome;
        private string instrutor;

		public Curso(string nome, string instrutor)
		{
			this.nome = nome;
			this.instrutor = instrutor;
			this.aulas = new List<Aula>();
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		
		public string Instrutor
		{
			get { return instrutor; }
			set { instrutor = value; }
		}

		internal void Adiciona(Aula aula)
		{
			this.aulas.Add(aula);
		}

		public int TempoTotal
		{
			get
			{
				//int total = 0;
				//foreach (Aula aula in aulas)
				//{
				//	total += aula.Tempo;
				//}
				//return total;

				// LINQ = Consulta Integrada á Linguagem (Language Integrated Query)
				return aulas.Sum(aula => aula.Tempo);
			}
		}

		public override string ToString()
		{
			return $"Curso: {nome}, Instrutor: {instrutor}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
		}
	}
}
