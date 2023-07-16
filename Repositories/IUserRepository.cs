using BusinessObjects;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        public int GetUsersQuantityByRole(string role);
        public List<User> GetUsersByRole(string role);
        User Get(string usernameOrEmail);
        bool Exist(string usernameOrEmail);
        void Create(User entity);
        void Update(User entity);
        void Save(User entity);
        void Delete(string usernameOrEmail);
        User Authenticate(string usernameOrEmail, string password);
    }
}
