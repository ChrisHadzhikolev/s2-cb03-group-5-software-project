using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    public class User
    {
        public User(string username, string firstName, string lastName, string email, PersonPosition position, double salary, ShiftType shiftType, bool[] workingDays, string department, int id)
                 {
                     this._id = id;
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
        public User(string firstName, string lastName, string email, PersonPosition position, double salary, ShiftType shiftType, bool[] workingDays, string department)
        {
            Username = GenerateUsername();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Position = position;
            Salary = salary;
            ShiftTypeU = shiftType;
            WorkingDays = workingDays;
            Department = department;
        }
        private int _id;
        private static int _idSeed= 10000;

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public PersonPosition Position { get; set; }
        public double Salary { get; set; }
        public ShiftType ShiftTypeU { get; set; }
        public bool[] WorkingDays { get; set; }
        public string Department { get; set; }


        private static Random _random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
        public string GeneratePassword()
        {            
          return RandomString(12);           
        }
        public string GenerateUsername()
        {
            return "mbemp" + _idSeed.ToString();
            _idSeed++;
        }

        public override string ToString()
        {
            return $"{_id.ToString()}\t{FirstName}\t{LastName}\t{Email}\t{Salary.ToString("C2", CultureInfo.CurrentCulture)}";
        }
    }



}
