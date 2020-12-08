﻿using System;

namespace GameWebSiteProject.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Avatar { get; set; }
        public string About { get; set; }
        
    }
}