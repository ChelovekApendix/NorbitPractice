using DataBase_Task2.Entities;
using DataBase_Task2.Services;
using Microsoft.Extensions.Configuration;

namespace DataBase_Task2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            ApplicationContext appContext = new ApplicationContext(connectionString);

            UserService userService = new UserService();

            int choice = 0;
            Console.WriteLine("Выберите действие:\n" +
                "1.Create\n2.Read\n3.Update\n4.Delete");
            try { choice = int.Parse(Console.ReadLine()); } catch (FormatException) { Console.WriteLine("Назовите число из списка"); return; }

            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите никнейм");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите почту");
                        string mail = Console.ReadLine();
                        Console.WriteLine("Введите пароль");
                        string password = Console.ReadLine();
                        Console.WriteLine("Выберите пол (М/Ж)");
                        char gender = ' ';
                        try { gender = Convert.ToChar(Console.ReadLine()); } catch { Console.WriteLine("Неверно ввели пол"); break; };
                        gender = gender == 'Ж' || gender == 'W' ? gender = 'W' : gender = 'M';
                        userService.AddUser(name, password, mail, gender);
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите никнейм пользователя, информацию о котором хотите узнать");
                        string name = Console.ReadLine();
                        User user = userService.GetUserByNickname(name);
                        if (user != null)
                        {
                            Console.WriteLine($"nickname = {user.Nickname}, email = {user.Mail} registration date = {user.Registration_date} gender = {user.Gender}");
                        }
                        else
                        {
                            Console.WriteLine("Такого пользователя нет в системе");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите никнейм пользователя, которого хотите изменить");
                        string oldName = Console.ReadLine();
                        Console.WriteLine("Введите новый никнейм");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Введите почту");
                        string mail = Console.ReadLine();
                        Console.WriteLine("Введите пароль");
                        string password = Console.ReadLine();
                        Console.WriteLine("Выберите пол (М/Ж)");
                        char gender = ' ';
                        try { gender = Convert.ToChar(Console.ReadLine()); } catch { }
                        ;
                        gender = gender == 'Ж' || gender == 'W' ? gender = 'W' : gender = 'M';
                        userService.UpdateUser(oldName, newName, password, mail, gender);
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите никнейм");
                        string name = Console.ReadLine();
                        userService.DeleteUser(name);
                    }
                    break;
                default:
                    Console.WriteLine("Назовите число из списка");
                    break;
            }
        }
    }
}
