using Domain.Cliente.Aggregate.Enum;

namespace Domain.Cliente.Aggregate.Entity
{
	public class Telefone
	{
		public int Id { get; set; }
		public string Numero { get; set; }
		public Tipo Tipo { get; set; }
	}
}
