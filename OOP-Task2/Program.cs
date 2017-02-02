using System;
using System.Linq;

/*
Сведения о студенте: фамилия (строка), шифр группы (строка), адрес (строка), номер телефона (целое

число). По сведениям о некотором количестве (не более N) студентов получить список студентов

данной группы, отсортированных по возрастанию номеров телефонов. Если студентов данной группы

нет, выдать соответствующее сообщение. 
*/

namespace OOP_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = "126";
            var students=new Students();

            var findedStudents = students.Members.FindAll(x => x.Group == group).OrderBy(x=>x.Phone);
            if (findedStudents.Any())
            {
                foreach (var findedStudent in findedStudents)
                {
                    Console.WriteLine("SecondName = "+ findedStudent.SecondName+": Group = "+ findedStudent.Group +": Adress = "+ findedStudent.Adress+ ": Phone = "+findedStudent.Phone);
                }
               
            }
            else
            {
                Console.WriteLine("Nothing here");
            }
           
            Console.ReadKey();
        }
    }
}
