using System.Collections.Generic;

namespace OOP_Task2
{
    class Students
    {
        public List<Student> Members { get; set; }

        public Students()
        {
            Members = new List<Student>
            {
                new Student("ivanov", "126", "lenina 10", 7988100118),
                new Student("ivanov", "125", "lenina 10", 7988100123),
                new Student("ivanov", "125", "lenina 10", 7988100115),
                new Student("ivanov", "126", "lenina 11", 7988100102),
                new Student("ivanov", "126", "lenina 10", 7988100105),

            };
        }
    }
}