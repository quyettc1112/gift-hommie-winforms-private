using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAll() => UserDAO.Instance.GetAll();
        public int GetUsersQuantityByRole(string role) => GetUsersByRole(role).Where(u => u.Enabled == true).Count(); 
        public List<User> GetUsersByRole(string role) => GetAll().Where(u => u.Role.Equals(role)).ToList();
        public User Get(string usernameOrEmailOrPhone) => UserDAO.Instance.Get(usernameOrEmailOrPhone);

        public bool Exist(string usernameOrEmail) => UserDAO.Instance.Exist(usernameOrEmail);

        public void Create(User entity) => UserDAO.Instance.Create(entity);

        public void Update(User entity) => UserDAO.Instance.Update(entity);

        public void Save(User entity) => UserDAO.Instance.Save(entity);

        public void Delete(string usernameOrEmail) => UserDAO.Instance.Delete(usernameOrEmail);

        public User Authenticate(string usernameOrEmail, string password)
        {
            User user = Get(usernameOrEmail);
            if (user == null || user.Password.Equals(password) == false)
                return null;

            if (user.Enabled == false)
                throw new Exception("YOUR ACCOUNT WAS BANNED");
            
            return user;
        }
    }
}
