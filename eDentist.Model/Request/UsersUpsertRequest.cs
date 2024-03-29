﻿using System;
using System.Collections.Generic;

namespace eDentist.Model.Request
{
    public class UsersUpsertRequest
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public int? CityId { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public byte[] Image { get; set; }

        public List<int> Roles { get; set; } = new List<int>();
        public List<int> RolesToDelete { get; set; } = new List<int>();
    }
}
