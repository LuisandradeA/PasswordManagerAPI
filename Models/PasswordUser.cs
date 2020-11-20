using System;
using System.Collections.Generic;

namespace PasswordManagerAPI.Models
{
    public class PasswordUser
    {
        public int IdPasswordUser {get;set;}
        public int IdUser {get;set;}
        public string SystemName {get;set;}
        public string Password {get;set;}
        public bool ReceiveNotification {get;set;}
        public DateTime ExpirationDate {get;set;}
        public DateTime UpdateDate {get;set;}
        public DateTime CreationDate {get;set;}
    }
}