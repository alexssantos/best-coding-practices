using System;

namespace Domain.Cliente.Aggregate.ValueObject
{
	public class CEP
	{
		public string Valor { get; set; }
		public string ValorFormatado => FormataValor(this.Valor);



		public CEP(string valor)
		{
			this.Valor = valor?.Replace("-", "") ?? throw new ArgumentException(nameof(CEP));
		}


		public string FormataValor(string valor) => Convert.ToInt64(valor).ToString(@"00000\-000");
	}
}
