using System;
using System.Collections.Generic;
using System.Text;
using BKart.Domain.Promotion;
using BKart.Domain.User;

namespace BKart.Services.User
{
    public interface IUserService
    {
       void AddUser(BKart.Domain.User.User user); 
    }
}
