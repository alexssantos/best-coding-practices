using Domain.Cliente.Aggregate.Factory;
using Domain.Cliente.Aggregate.Repository;
using System;

namespace ApplicationService.Cliente
{
	public class ClienteService : IClienteService
	{
		private IClientRepository Repository { get; set; }

		public ClienteService(IClientRepository clienteRepository)
		{
			Repository = clienteRepository;
		}

		public void Create(string nome, string CPF, DateTime dtNascimento)
		{
			if (this.Repository.GetByCPF(CPF) != null)
				throw new Exception($"Cliente já existe na base com este cpf {CPF}");

			//FACTORY
			var cliente = ClienteFactory.Criar(nome, CPF, dtNascimento);

			//BUILDER
			//var cliente = new ClienteBuilder()
			//	.Criar(nome, CPF, dtNascimento)
			//	.AdicionarPassword("abdc#1234")
			//	.AdicionarEndereco(new Domain.Cliente.Aggregate.Entity.Endereco())
			//	.AdicionarTelefone(
			//		new Domain.Cliente.Aggregate.Entity.Telefone()
			//		{
			//			Numero = new Domain.Cliente.Aggregate.ValueObject.NumeroTelefone("99999-8888"),
			//			Tipo = Domain.Cliente.Aggregate.Enum.Tipo.Comercial
			//		})
			//	.Build();

			this.Repository.Save(cliente);
		}
	}
}
