using System;

namespace Domain.Cliente.Aggregate.ValueObject
{
	public class DataNascimento
	{
		public DateTime Data { get; set; }
		public int Idade => Valor(Data);

		private int Valor(DateTime data)
		{
			return new DateTime((DateTime.Now.Date - data).Ticks).Year;
		}
	}
}
