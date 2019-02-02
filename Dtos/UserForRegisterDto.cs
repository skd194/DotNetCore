using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Min password length is 6")]
        public string Password { get; set; }     
    }
}