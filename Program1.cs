using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question 1
namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate();
            undergraduate.Name = "Bibiana Nongtnger";
            undergraduate.StudentId = 92345;
            undergraduate.Grade = 85.0;
            Console.WriteLine("Undergraduate isPassed: " + undergraduate.IsPassed(undergraduate.Grade));

            Graduate graduate = new Graduate();
            graduate.Name = "Elizabeth ";
            graduate.StudentId = 98900;
            graduate.Grade = 78.0;
            Console.WriteLine("Graduate isPassed: " + graduate.IsPassed(graduate.Grade));

        }
        public abstract class Student
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public double Grade { get; set; }

            public abstract bool IsPassed(double grade);
        }

        public class Undergraduate : Student
        {
            public override bool IsPassed(double grade)
            {
                if (grade > 70.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Graduate : Student
        {
            public override bool IsPassed(double grade)
            {
                if (grade > 80.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }

}

