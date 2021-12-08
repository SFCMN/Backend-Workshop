using System.Collections.Generic;
using System.Linq;

namespace BasicCSharp.Advance1
{
    public class Score
    {
        public List<Course> CourseList { get; }

        public Score(List<Course> courses)
        {
            this.CourseList = courses;
        }

        public int GetTotalScore()
        {
            return this.CourseList.Sum(course => course.Score);
        }
    }
}
