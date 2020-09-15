using Domain.Cliente.Aggregate.Enum;
using Domain.Cliente.Aggregate.ValueObject;

namespace Domain.Cliente.Aggregate.Entity
{
	public class Endereco
	{
		public int Id { get; set; }
		public string Logradouro { get; set; }
		public string Bairro { get; set; }
		public string Complemento { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public CEP CEP { get; set; }
		public Tipo Tipo { get; set; }
	}
}
