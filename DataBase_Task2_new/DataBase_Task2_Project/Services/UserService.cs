using DataBase_Task2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Task2.Services
{
    internal class UserService
    {
        public void AddUser(string nickname, string password, string mail="-", char gender='-') 
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                if (context.Users.Any(u => u.Nickname == nickname))
                { Console.WriteLine($"Пользователь с никнеймом {nickname} уже существует"); }
                else 
                {
                    var user = new User
                    {
                        Nickname = nickname,
                        Mail = mail,
                        Registration_date = DateOnly.FromDateTime(DateTime.Now),
                        Password = password,
                        Gender = gender
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                    
            }
        }
        public User GetUserByNickname(string nickname)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                if (!context.Users.Any(u => u.Nickname == nickname))
                { return null; }
                else 
                {
                    var user = context.Users.FirstOrDefault(u => u.Nickname == nickname);
                    return user;
                }
                    
            }
        }
        public void UpdateUser(string oldNickname, string newNickname, string password, string mail, char gender)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                if (!context.Users.Any(u => u.Nickname == oldNickname))
                { Console.WriteLine($"Пользователя '{oldNickname}' не существует"); }
                else
                {
                    var user = context.Users.FirstOrDefault(u => u.Nickname == oldNickname);
                    user.Nickname = newNickname;
                    user.Password = password;
                    user.Mail = mail;
                    user.Gender = gender;
                    context.Users.Update(user);
                    context.SaveChanges();
                }

                
            }
        }
        public void DeleteUser(string nickname)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Nickname == nickname);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Пользователя '{nickname}' не существует");
                }
            }
        }
    }
}
