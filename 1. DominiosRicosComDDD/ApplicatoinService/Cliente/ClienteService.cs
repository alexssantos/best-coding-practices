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

			var cliente = ClienteFactory.Criar(nome, CPF, dtNascimento);

			this.Repository.Save(cliente);
		}
	}
}
