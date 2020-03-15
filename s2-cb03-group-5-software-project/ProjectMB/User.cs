using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    class User
    {
        public User(int id, string username, string firstName, string lastName, string email, PersonPosition position, double salary, ShiftType shiftType, bool[] workingDays, string department)
        {
            this.id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Position = position;
            Salary = salary;
            ShiftTypeU = shiftType;
            WorkingDays = workingDays;
            Department = department;
        }
        private int id;
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public PersonPosition Position { get; set; }
        public double Salary { get; set; }
        public ShiftType ShiftTypeU { get; set; }
        public bool[] WorkingDays { get; set; }
        public string Department { get; set; }


        private static Random random = new Random();
        protected static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string GeneratePassword()
        {            
          return RandomString(12);           
        }
    }



}
