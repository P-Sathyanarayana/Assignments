using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Person1
    {
       /// <summary>
       /// A person has several attributes that include name, date of birth, address and marital status (single, married, divorced or widowed). 
       /// Create a four parameter constructor to initialise the fields Add properties for the fields 
       ///   Write a method GetAge() to return the age of the person 
       ///   Write a method CanMarry() to return true or false if a person can get married
       ///  (people can get married over the age of 18 if they are not already maried) 
       ///  Override the ToString() method to display the persons details to the screen
       /// (format = Fred lives at 21 Lancaster road, born on 12/12/1980, single, 20 years old and can marry)
       ///  Write a simple driver program to test the class
       /// </summary>
        public string name;
        DateTime dob;
        string Address;
        string marstatus;
        int age;
        string marry;
        public Person1()
        {
            name = "abc";
            dob = DateTime.Today;
            Address = "Null";
            marstatus = "Unknown";
        }
        public Person1(string nam, DateTime d, string add, string maristatus)
        {
            this.name = nam;
            this.dob = d;
            this.Address = add;
            this.marstatus = maristatus;
        }
        public string Getage()
        {
            DateTime today = DateTime.Today;
            this.age = today.Subtract(this.dob).Days;
            this.age = this.age / 365;
            return $"The age is {age} years ";
        }
        public bool CanMarry()
        {
            if(this.age>18 && this.marstatus is "Single")
            {
                this.marry = "can marry";
                    return true;

            }
            else
            {
                this.marry = "cannot marry";
                return false;

            }
            //    Console.WriteLine("1. If marital status is Single 2. For others");
            //    int ch = int.Parse(Console.ReadLine());
            //    switch (ch)
            //    {
            //        case 1:
            //            if (this.age > 18)
            //            {
            //                this.marry = "can marry";
            //                return true;
            //            }
            //            else
            //            {
            //                this.marry = "cannot marry";
            //                return false;
            //            }
            //        case 2:
            //            this.marry = "cannot marry";
            //            return false;
            //    }
            //    return false;
        }

        public override string ToString()
        {
            var date = dob.ToShortDateString();
            return $"{this.name} lives at {this.Address}, born on {date},{this.marstatus},{this.age} years old and {this.marry}";
        }




    }
    class person1test
    {
        public static void Main()
        {
            Person1 p = new Person1();
            Console.WriteLine(p.name);

            Person1 p1 = new Person1("Fred", new DateTime(2000,12, 12), "21 Lancestar road", "Single");
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.Getage());
            if (p1.CanMarry())
                Console.WriteLine($"Eligible to marry ");

            else Console.WriteLine("Not eligible to marry");
            Console.WriteLine(p1.ToString());

        }
    }
}
