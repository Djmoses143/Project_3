using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> Studentlist = new List<Student>();
            try
            {
                string path = "C:\\Mosesfiles\\Rainbow School Data.txt";
                string[] Studata = File.ReadAllLines(path);
                foreach (string line in Studata)
                {
                    string[] data = line.Split(',');
                    if (data.Length >= 1)
                    {
                        Student student = new Student();
                        student.Stuname = data[0];
                        student.Stuclass = data[1];
                        Studentlist.Add(student);

                    }
                }
                Studentlist.Sort();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Displaystu(Studentlist);
                Searchstu(Studentlist);
            }
            Console.ReadLine();
    }
        public static void Searchstu(List<Student> list)
        { 
            Console.WriteLine("Enter a Name to search :");
            string name=Console.ReadLine();
            List<Student> found = list.FindAll(data => data.Stuname == name);
            if(found != null)
            {
                foreach(Student student in found)
                {
                    Console.WriteLine(student.Stuname+" found in class-"+student.Stuclass);
                }
            }
            else { Console.WriteLine("No student found with {0}",name); }
        }
        public static void Displaystu(List<Student> list)
        {
            Console.WriteLine("<=== Sorted data ===>");
            Console.WriteLine();
            foreach (var student in list)
            {
                Console.WriteLine(student.Stuname+" "+student.Stuclass);
            }
            Console.WriteLine();
        }
    }
}