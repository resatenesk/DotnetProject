﻿using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class UserForRegisterDto : Idto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
