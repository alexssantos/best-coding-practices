using Domain.Cliente.Aggregate.Repository;
using Domain.Cliente.Aggregate.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Cliente
{
	public class ClienteRepository : IClientRepository
	{
		private static IList<Domain.Cliente.Aggregate.Entity.Cliente> db = new List<Domain.Cliente.Aggregate.Entity.Cliente>();

		public Domain.Cliente.Aggregate.Entity.Cliente Get(int id)
		{
			return db.FirstOrDefault(x => x.Id == id);
		}

		public List<Domain.Cliente.Aggregate.Entity.Cliente> GetAll()
		{
			return db.ToList();
		}

		public Domain.Cliente.Aggregate.Entity.Cliente GetByCPF(CPF CPF)
		{
			return db.FirstOrDefault(x => x.CPF == CPF);
		}

		public Domain.Cliente.Aggregate.Entity.Cliente GetByCPF(string CPF)
		{
			return db.FirstOrDefault(x => x.CPF.Valor == CPF);
		}

		public void Save(Domain.Cliente.Aggregate.Entity.Cliente cliente)
		{
			db.Add(cliente);
		}

		public void Update(Domain.Cliente.Aggregate.Entity.Cliente cliente)
		{
			throw new NotImplementedException();
		}
	}
}
