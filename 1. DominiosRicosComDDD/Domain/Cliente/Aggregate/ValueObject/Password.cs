using System;
using System.Text.RegularExpressions;

namespace Domain.Cliente.Aggregate.ValueObject
{
	public class Password
	{
		public string Valor { get; set; }

		public Password(string valor)
		{
			ValidarPassword(valor);

			this.Valor = valor;
		}


		private void ValidarPassword(string valor)
		{
			var isValid = Regex.IsMatch(valor, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!% *#?&])[A-Za-z\d@$!%*#?&]{8,}$");

			if (!isValid)
			{
				throw new Exception("A Senha deve ter no mínimo 8 caracteres, uma letra, um caracter especial e um número!");
			}
		}

		public static Password GerarPassword(int len = 8)
		{
			string pass = "";
			Random rnd = new Random();

			while (pass.Length < len) pass += (new Func<Random, string>((r) =>
			{
				char c = (char)((r.Next(123) * DateTime.Now.Millisecond % 123));
				return (Char.IsLetterOrDigit(c)) ? c.ToString() : "";
			}))(rnd);

			return new Password(pass);
		}
	}
}
