using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2.Models
{
    public class Diver : User
    {
        private int IdDiver;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int TelNumber { get; set; }
        public int DeviceNumber { get; set; }
        public Diver(string name, string surname, int age, string email, int telnumber, int devicenumber, string login, string password) : base(login, password, 1)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            TelNumber = telnumber;
            DeviceNumber = devicenumber;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.Name}| Surname: {this.Surname}| Age {this.Age}");
        }
    }
}
