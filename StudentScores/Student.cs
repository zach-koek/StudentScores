using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores
{
    public class Student
    {
        public string StudentName { get; set; }

        public List<int> Scores { get; set; }

        public Student()
        {
            Scores = new List<int>();
        } 


        public override string ToString()
        {
            string output = "";

            output += StudentName;

            foreach (var score in Scores) 
            {
                output += "  " + " | " + score;
            }
            return output;

        }
    }
}
