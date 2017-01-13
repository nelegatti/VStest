using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            using (var ctx = new School235Entities1())
            {
                var student = (from s in ctx.Students
                               where s.StudentName == "Jesus"
                               select s).FirstOrDefault<Student>();
                Console.WriteLine(student.StudentName);
                Student p = new Student();
                p.StudentName = student.StudentName;
                
            }
            
            using (var ctx = new School235Entities1())
            {
                var standard = (from a in ctx.Standards
                                where a.StandardName == "Standard01"
                                select a).FirstOrDefault<Standard>();
                Console.WriteLine("Standard Name: " + standard.StandardName);
            }
            using (var ctx = new School235Entities1())
            {
                var student = (from s in ctx.Students
                               where s.StudentId == 1
                               select s).SingleOrDefault<Student>();
                Console.WriteLine(student.StudentId);
            }

            using (var context = new School235Entities1())
            {
                var listStudent = (from stud in context.Students
                                   where stud.StandardId == 1
                                   select stud).ToList<Student>();
                foreach(Student s in listStudent)
                {
                    Console.WriteLine("Student Name: " + s.StudentName);
                }
            }

            using (var ctx = new School235Entities1())
            {
                var students = from s in ctx.Students
                        group s by s.StandardId into studentsByStandard
                        select studentsByStandard;
                Console.WriteLine(students);

                foreach(var gr in students)
                {

                    if (gr.Key == 1)
                    {
                        foreach(Student s in gr.Select(x => x))
                        {
                            Console.WriteLine(s.StudentName);
                        }
                    }
                    else
                        Console.WriteLine("NO CORRESPONDE A STANDARD01");
                }
            }

            using (var ctx = new School235Entities1())
            {
                var student = from s in ctx.Students
                        orderby s.StudentName ascending
                        select s;
                foreach(Student s in student)
                {
                    Console.WriteLine("Nombre Ascendente: " + s.StudentName);
                }
            }
            
            using(var ctx = new School235Entities1())
            {
                var anonimus = from s in ctx.Students
                               where s.StudentName == "Jesus"
                               select new
                               {
                                   s.StudentName,
                                   s.Standard.StandardName,
                                   
                               };
                try
                {
                    Console.WriteLine(anonimus);//FIXME NO LOGRO ACCEDER !!!!!¡¡¡¡!!!
                }catch(Exception ex)
                {
                    Console.WriteLine("No se puede ");
                }
                
            } 



        }

    }
}
