using System.ComponentModel.DataAnnotations;

namespace Pi_CSharp.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite um nome valido!")]
        public string Nome { get; set; }
        [Required (ErrorMessage = "Digite um Endereço valido!" )]
        public string Endereco { get; set; }
        [Required (ErrorMessage = "Digite um CPF valido!" )]
        public string Cpf { get; set; }
        [Required (ErrorMessage = "Digite um Telefone valido!" )]
        [Phone (ErrorMessage = "O Telfone não é valido!" )]
        public string Telefone { get; set; }
        [Required (ErrorMessage = "Digite um E-Mail valido!" )]
        [EmailAddress (ErrorMessage = "O E-mail não é valido!" )]
        public string Email { get; set; }

    }
}
