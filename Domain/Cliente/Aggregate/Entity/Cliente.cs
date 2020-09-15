using Domain.Cliente.Aggregate.ValueObject;
using System;
using System.Collections.Generic;

namespace Domain.Cliente.Aggregate.Entity
{
	public class Cliente
	{
		public int Id { get; set; }

		public string Nome { get; set; }
		public CPF CPF { get; set; }
		public DateTime DataNascimento { get; set; }
		public int Idade { get; set; }
		public Filiacao Mae { get; set; }
		public Filiacao Pai { get; set; }

		public IList<Endereco> Enderecos { get; set; }
		public IList<Telefone> Telefones { get; set; }
	}
}
