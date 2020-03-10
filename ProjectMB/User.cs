using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    class User
    {
        public User(int id, string username, string firstName, string lastName, string email, PersonPosition position, double salary, ShiftType shiftType, WeekDay[] workingDays, string department)
        {
            this.id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Position = position;
            Salary = salary;
            ShiftType = shiftType;
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
        public ShiftType ShiftType { get; set; }
        public WeekDay[] WorkingDays { get; set; }
        public string Department { get; set; }
    }



}
