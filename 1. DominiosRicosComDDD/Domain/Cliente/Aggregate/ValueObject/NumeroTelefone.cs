﻿using System;

namespace Domain.Cliente.Aggregate.ValueObject
{
	public class NumeroTelefone
	{
		public string Valor { get; set; }

		public string ValorFormatado => FormataValor(this.Valor);

		public NumeroTelefone()
		{

		}
		public NumeroTelefone(string numero)
		{
			this.Valor = numero;
		}

		private string FormataValor(string valor) => Convert.ToInt64(valor).ToString(@"(00) 00000-0000");

	}
}
