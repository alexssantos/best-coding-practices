using System;
using System.Collections.Generic;

namespace Domain.Cliente.Aggregate.Entity
{
	public class Cliente
	{
		public int Id { get; set; }

		public string Nome { get; set; }
		public string CPF { get; set; }
		public DateTime DataNascimento { get; set; }
		public int Idade { get; set; }
		public string NomeMae { get; set; }
		public string NomePai { get; set; }

		public IList<Endereco> Enderecos { get; set; }
		public IList<Telefone> Telefones { get; set; }
	}
}
