using System;

namespace Domain.Cliente.Aggregate.ValueObject
{
	public class CPF
	{

		public CPF()
		{

		}

		public CPF(string valor)
		{
			//Restringindo criação de CPF fora do padrão.
			//REGRA
			this.Valor = valor?.Replace(".", "").Replace("-", "") ?? throw new ArgumentException(nameof(CPF));
		}

		public string Valor { get; set; }
		public string Formatado => ValorFormatado(this.Valor);


		private string ValorFormatado(string valor) => Convert.ToInt64(valor).ToString(@"000\.000\.000\-00");

	}
}
