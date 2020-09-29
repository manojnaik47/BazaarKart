using BazaarDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BKart.Domain.User
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastLoginAttempt { get; set; }
        public bool IsDeleted { get; set; }
        public int FailedLoginAttempts { get; set; }

    }
}
