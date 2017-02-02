using System;

namespace OOP_Task2
{
    class Student
    {
        public Student(string secondName, string group, string adress, long phone)
        {
            SecondName = secondName;
            Group = group;
            Adress = adress;
            Phone = phone;
        }

        public string SecondName { get; set; }
        public string Group { get; set; }
        public string Adress { get; set; }
        public Int64 Phone { get; set; }

    }
}