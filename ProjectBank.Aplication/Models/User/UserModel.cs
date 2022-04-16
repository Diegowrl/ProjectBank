using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectBank.Aplication.Models.User
{
    public class UserModel
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}
