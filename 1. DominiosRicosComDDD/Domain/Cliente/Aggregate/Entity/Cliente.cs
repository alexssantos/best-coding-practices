using Domain.Cliente.Aggregate.Enum;
using Domain.Cliente.Aggregate.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Cliente.Aggregate.Entity
{
	public class Cliente
	{
		public int Id { get; set; }

		public string Nome { get; set; }
		public CPF CPF { get; set; }
		public DataNascimento DataNascimento { get; set; }
		public Filiacao Mae { get; set; }
		public Filiacao Pai { get; set; }
		public Password Password { get; set; }

		//encapsulando endereço e obrigando a passar pela regra ao adicionar.
		private IList<Endereco> Enderecos { get; set; }
		public IList<Telefone> Telefones { get; set; }


		public Telefone ObterTelefone(Tipo tipo)
		{
			return this.Telefones.FirstOrDefault(x => x.Tipo == tipo);
		}

		public Endereco ObterEndereco(Tipo tipo)
		{
			return this.Enderecos.FirstOrDefault(x => x.Tipo == tipo);
		}

		public List<Endereco> ObterEnderecos()
		{
			return this.Enderecos.ToList();
		}

		public List<Telefone> ObterTelefones()
		{
			return this.Telefones.ToList();
		}

		//Adicionando algumas regras de negócio à entidade.		
		public void Adicionartelefone(Telefone telefone)
		{
			if (this.ObterEndereco(telefone.Tipo) != null)
			{
				throw new Exception("Não é permitido inserir o mesmo tipo de telefone!");
			}

			this.Telefones.Add(telefone);
		}

		//Adicionando algumas regras de negócio à entidade.		
		public void AdicionarEndereco(Endereco endereco)
		{
			if (this.ObterEndereco(endereco.Tipo) != null)
			{
				throw new Exception("Não é permitido inserir o mesmo tipo de endereco!");
			}

			this.Enderecos.Add(endereco);
		}

		public void GerarPassword()
		{
			this.Password = Password.GerarPassword();
		}

		public void AdicionarPassword(string password)
		{
			this.Password = new Password(password);
		}
	}
}
