using Domain.Cliente.Aggregate.Enum;
using Domain.Cliente.Aggregate.ValueObject;

namespace Domain.Cliente.Aggregate.Entity
{
	public class Telefone
	{
		public int Id { get; set; }
		public NumeroTelefone Numero { get; set; }
		public Tipo Tipo { get; set; }
	}
}
