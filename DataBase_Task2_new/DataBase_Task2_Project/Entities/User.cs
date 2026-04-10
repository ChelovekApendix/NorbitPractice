using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataBase_Task2.Entities
{
    public class User
    {
        [Key]
        public Guid Guid { get; set; }
        public string Nickname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateOnly Registration_date { get; set; }
        public char Gender { get; set; }

        public User (string nickname, string mail, string password, char gender)
        {
            Nickname = nickname;
            Mail = mail;
            Password = password;
            Gender = gender;
        }
        public User() { }

    }
}
