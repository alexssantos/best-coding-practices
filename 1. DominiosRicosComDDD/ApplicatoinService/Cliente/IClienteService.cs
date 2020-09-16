using System;

namespace ApplicationService.Cliente
{
	public interface IClienteService
	{
		void Create(string mome, string CPF, DateTime dtNascimento);
	}
}
