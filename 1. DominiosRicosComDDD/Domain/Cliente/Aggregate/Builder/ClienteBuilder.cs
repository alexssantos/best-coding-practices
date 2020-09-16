using Domain.Cliente.Aggregate.Entity;
using System;

namespace Domain.Cliente.Aggregate.Builder
{

	public class ClienteBuilder
	{
		private Entity.Cliente cliente { get; set; }

		public ClienteBuilder Criar(string nome, string cpf, DateTime dtNascimento)
		{
			this.cliente = new Entity.Cliente(nome, new ValueObject.CPF(cpf), new ValueObject.DataNascimento(dtNascimento));
			return this;
		}

		public ClienteBuilder AdicionarTelefone(Telefone telefone)
		{
			this.cliente.Adicionartelefone(telefone);
			return this;
		}

		public ClienteBuilder AdicionarEndereco(Endereco endereco)
		{
			this.cliente.AdicionarEndereco(endereco);
			return this;
		}

		public ClienteBuilder AdicionarPassword(string password)
		{
			this.cliente.AdicionarPassword(password);
			return this;
		}

		public Entity.Cliente Build()
		{
			return this.cliente;
		}
	}
}
