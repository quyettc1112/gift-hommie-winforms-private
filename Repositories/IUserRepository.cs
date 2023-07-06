using BusinessObjects;
using System;
using System.Collections.Generic;

namespace BussinessObjects
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Get(string usernameOrEmail);
        bool Exist(string usernameOrEmail);
        void Create(User entity);
        void Update(User entity);
        void Save(User entity);
        void Delete(string usernameOrEmail);
        User Authenticate(string usernameOrEmail, string password);
    }
}
