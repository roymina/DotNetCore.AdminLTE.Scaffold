using System.ComponentModel.DataAnnotations;

namespace DotNetCore.AdminLTE.Scaffold.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User name cannot be empty")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
