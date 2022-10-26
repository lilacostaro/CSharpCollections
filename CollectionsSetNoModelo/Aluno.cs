using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsSetNoModelo
{
    class Aluno
    {
		private string nome;
        private int numeroMatricula;

        public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public Aluno(string nome, int numeroMatricula)
		{
			this.nome = nome;
			this.numeroMatricula = numeroMatricula;
		}

		public int NumeroMatricula
		{
			get { return numeroMatricula; }
			set { numeroMatricula = value; }
		}

		public override string ToString()
		{
			return $"[Nome: {Nome}, Matrícula: {NumeroMatricula}]";
		}

		public override bool Equals(object? obj)
		{
			Aluno other = obj as Aluno;
			if (other == null)
			{
				return false;
			}
			return (this.Nome.Equals(other.nome) && this.NumeroMatricula.Equals(other.NumeroMatricula));
		}

		public override int GetHashCode()
		{
			return this.nome.GetHashCode();
		}

		//IMPORTANTE !!
		//Dois objetos que são iguais possuem o mesmo hash code.
		//PORÉM, o contrario não é verdadeiro:
		//Dois objetos com o mesmo hash code não são necessariamente iguais.
	}
}
