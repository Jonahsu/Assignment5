using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public interface IStudent
        {
            int StudentId { get; set; }
            string Name { get; set; }
            void ShowDetails();
        }

        public class Dayscholar : IStudent
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public float Fees { get; set; } = 50000;

            public void ShowDetails()
            {
                Console.WriteLine($"Student ID: {StudentId}\nName: {Name}\nFees: {Fees}");
            }
        }

        public class Resident : IStudent
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public float Fees { get; set; } = 100000;

            public void ShowDetails()
            {
                Console.WriteLine($"Student ID: {StudentId}\nName: {Name}\nFees: {Fees}");
                Console.ReadLine();
            }
        }
    }    

}

