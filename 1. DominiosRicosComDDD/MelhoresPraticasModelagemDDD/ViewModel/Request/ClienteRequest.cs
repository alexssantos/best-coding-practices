using System;
using System.ComponentModel.DataAnnotations;

namespace MelhoresPraticasModelagemDDD.ViewModel.Request
{
	public class ClienteRequest
	{
		[Required(ErrorMessage = "Campo Nome é Obrigatório")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Campo CPF é Obrigatório")]
		public string CPF { get; set; }

		[Required(ErrorMessage = "Campo DataNascimento é Obrigatório")]
		public DateTime DataNascimento { get; set; }
	}
}
