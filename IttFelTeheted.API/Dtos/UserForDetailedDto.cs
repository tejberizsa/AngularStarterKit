using System;

namespace IttFelTeheted.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Introduction { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastActive { get; set; }
    }
}