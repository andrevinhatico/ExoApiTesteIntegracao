using System.ComponentModel.DataAnnotations;

namespace ExoApiFST2.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail do Usuário")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do Usuário")]
        public string Senha { get; set; }
    }
}
