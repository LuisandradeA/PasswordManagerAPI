using System;
using System.Collections.Generic;

namespace PasswordManagerAPI.Models
{
    public class SystemUser
    {
        public int IdUser {get;set;}
        public string Username {get;set;}
        public string Name {get;set;}
        public string email {get;set;}
        public string Password {get;set;}
        public DateTime CreationDate {get;set;}
    }
}