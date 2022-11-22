using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp
{
    internal class UserModel
    {
        private static List<UserModel> users = new List<UserModel>();

        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public static bool AddUser(string name, string password, string surname)
        {
            try
            {
                users.Add(new UserModel
                {
                    ID = users.Count + 1,
                    Surname = surname,
                    Name = name,
                    Password = password
                });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void RemoveUser(int ID)
        {
            users.Remove(users.Where(p => p.ID == ID).FirstOrDefault());
        }

        public static UserModel GetUser(string name, string password)
        {
            UserModel user = null;
            foreach (var item in users)
            {
                if (item.Name == name && item.Password == password)
                {
                    user = item;
                    break;
                }
            }
            return user;
        }
    }
}
