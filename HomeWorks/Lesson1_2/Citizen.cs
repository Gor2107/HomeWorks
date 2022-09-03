using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_2
{
    abstract class Citizen
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Passport { get; set; }
        public string FullName => FirstName + ' ' + LastName;
        public Citizen(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var citizen = obj as Citizen; 
            return citizen.Passport.Equals(this.Passport);
        }
        public override int GetHashCode()
        {
            return this.Passport.GetHashCode();
        }
    }
    class Student : Citizen
    {
        public Student(string firstName, string lastName) : base(firstName, lastName) { }
        public int Class { get; set; }
    }
    class Worker : Citizen
    {
        public Worker(string firstName, string lastName) : base(firstName, lastName) { }
        public int Salary { get; set; }
    }
    class Pensioner : Citizen
    {
        public Pensioner(string firstName, string lastName) : base(firstName, lastName) { }
        public int Pension { get; set; }
    }
}
