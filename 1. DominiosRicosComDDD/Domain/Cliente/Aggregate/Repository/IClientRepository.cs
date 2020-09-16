using System.Collections.Generic;

namespace Domain.Cliente.Aggregate.Repository
{
	public interface IClientRepository
	{
		public Entity.Cliente Get(int id);
		public List<Entity.Cliente> GetAll();
		public void Save(Entity.Cliente cliente);
		public Entity.Cliente GetByCPF(string CPF);
	}
}
