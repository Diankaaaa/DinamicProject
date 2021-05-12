using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicProject
{
    class Student
    {
        string Surname { get; set; }
        float AverageScore { get; set; }

        public Student(string surname, float averageScore)
        {
            Surname = surname;
            AverageScore = averageScore;
        }
    }
}
