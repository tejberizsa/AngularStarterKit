using System;
using System.ComponentModel.DataAnnotations;

namespace IttFelTeheted.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Felhasználó üres")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Jelszó üres")]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "Jelszó hossza 4 és 8 karakter között kell legyen")]
        public string Password { get; set; }

        [Required(ErrorMessage = "E-mail üres")]
        public string EMail { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "Életkort nem adtál meg")]
        [Range(16, 99, ErrorMessage = "16 éves kor alatt nem regisztrálhatsz")]
        public int Age { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastActive { get; set; }
        public UserForRegisterDto()
        {
            RegistrationDate = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}