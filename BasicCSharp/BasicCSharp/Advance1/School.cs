using System.Collections.Generic;

namespace BasicCSharp.Advance1
{
    public class School
    {
        private readonly StudentInfo sanZhang = new StudentInfo(1L, "San Zhang", 1, "Male", 13);
        private readonly StudentInfo siLi = new StudentInfo(2L, "Si Li", 1, "Male", 14);
        private readonly StudentInfo wuWang = new StudentInfo(3L, "Wu Wang", 2, "Male", 13);
        private readonly StudentInfo liuZhao = new StudentInfo(4L, "Liu Zhao", 2, "Male", 14);
        private static readonly List<Course> coursesOfSanZhang = new List<Course>
        {
            new Course("Yu Wen", 90),
            new Course("Shu Xue", 80)
        };
        private static readonly List<Course> coursesOfSiLi = new List<Course>
        {
            new Course("Yu Wen", 78),
            new Course("Shu Xue", 56)
        };
        private static readonly List<Course> coursesOfWuWang = new List<Course>
        {
            new Course("Yu Wen", 89),
            new Course("Shu Xue", 67)
        };
        private static readonly List<Course> coursesOfLiuZhao = new List<Course>
        {
            new Course("Yu Wen", 66),
            new Course("Shu Xue", 87)
        };
        private readonly Score scoreOfSanZhang = new Score(coursesOfSanZhang);
        private readonly Score scoreOfSiLi = new Score(coursesOfSiLi);
        private readonly Score scoreOfWuWang = new Score(coursesOfWuWang);
        private readonly Score scoreOfLiuZhao = new Score(coursesOfLiuZhao);

        public List<StudentInfo> GetStudentInfoList()
        {
            return new List<StudentInfo>
            {
                sanZhang,
                siLi
            };
        }

        public Dictionary<long, Score> GetDictionaryOfStudentAndScore()
        {
            return new Dictionary<long, Score>
            {
                {sanZhang.Id, scoreOfSanZhang},
                {siLi.Id, scoreOfSiLi},
            };
        }

        public HashSet<double> GetHashSetOfTotalScore1()
        {
            var hashSetOfTotalScore = new HashSet<double>();
            var class1 = new Dictionary<long, Score>
            {
                {sanZhang.Id, scoreOfSanZhang},
                {siLi.Id, scoreOfSiLi},
            };
            foreach (var score in class1.Values)
            {
                hashSetOfTotalScore.Add(score.GetTotalScore());
            }
            return hashSetOfTotalScore;
        }
        public HashSet<double> GetHashSetOfTotalScore2()
        {
            var hashSetOfTotalScore = new HashSet<double>();
            var class2 = new Dictionary<long, Score>
            {
                {wuWang.Id, scoreOfWuWang},
                {liuZhao.Id, scoreOfLiuZhao},
            };
            foreach (var score in class2.Values)
            {
                hashSetOfTotalScore.Add(score.GetTotalScore());
            }
            return hashSetOfTotalScore;
        }
    }
}
