using System;
using System.Globalization;

namespace Domain.Cliente.Aggregate.ValueObject
{
	public class Filiacao
	{
		public string Nome { get; set; }
		public string NomeFormatado => ValorFormatado(this.Nome);

		public Filiacao()
		{

		}

		public Filiacao(string nome)
		{
			this.Nome = nome ?? throw new ArgumentNullException(nameof(Filiacao));
		}


		private string ValorFormatado(string nome)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
		}
	}
}
