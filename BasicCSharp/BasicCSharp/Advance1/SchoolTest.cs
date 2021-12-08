using System.Collections.Generic;
using Xunit;

namespace BasicCSharp.Advance1
{
    public class SchoolTest
    {
        [Fact]
        public void should_success_when_get_the_second_StudentInfo_from_the_studentInfoList()
        {
            var school = new School();
            var studentInfoList = school.GetStudentInfoList();
            Assert.Equal(2, studentInfoList.Count);
            Assert.Equal("Si Li", studentInfoList[1].Name);
        }
        [Fact]
        public void should_success_when_add_a_new_StudentInfo_to_the_studentInfoList()
        {
            var school = new School();
            var studentInfoList = school.GetStudentInfoList();
            Assert.Equal(2, studentInfoList.Count);
            studentInfoList.Add(new StudentInfo(5L, "Jack", 1, "Male", 15));
            Assert.Equal(3, studentInfoList.Count);
            Assert.Equal("Jack", studentInfoList[2].Name);
        }
        [Fact]
        public void should_success_when_remove_a_StudentInfo_from_the_studentInfoList()
        {
            var school = new School();
            var studentInfoList = school.GetStudentInfoList();
            Assert.Equal(2, studentInfoList.Count);
            studentInfoList.RemoveAt(1);
            Assert.Single(studentInfoList);
            Assert.Equal("San Zhang", studentInfoList[0].Name);
        }
        [Fact]
        public void should_success_when_update_the_second_StudentInfo_in_the_studentInfoList()
        {
            var school = new School();
            var studentInfoList = school.GetStudentInfoList();
            Assert.Equal(2, studentInfoList.Count);
            Assert.Equal("Si Li", studentInfoList[1].Name);
            studentInfoList[1] = new StudentInfo(5L, "Jack", 1, "Male", 15);
            Assert.Equal(2, studentInfoList.Count);
            Assert.Equal("Jack", studentInfoList[1].Name);
        }

        [Fact]
        public void should_success_when_get_the_Score_which_studentId_is_2_from_the_dictionaryOfStudentAndScore()
        {
            var school = new School();
            var dictionaryOfStudentAndScore = school.GetDictionaryOfStudentAndScore();
            var score = dictionaryOfStudentAndScore[2L];
            Assert.Equal("Yu Wen", score.CourseList[0].Name);
            Assert.Equal(78, score.CourseList[0].Score);
        }
        [Fact]
        public void should_success_when_add_a_new_Score_to_the_dictionaryOfStudentAndScore()
        {
            var school = new School();
            var dictionaryOfStudentAndScore = school.GetDictionaryOfStudentAndScore();
            Assert.Equal(2, dictionaryOfStudentAndScore.Count);
            dictionaryOfStudentAndScore.Add(5L, new Score(new List<Course>
            {
                new Course("Yu Wen", 23),
                new Course("Shu Xue", 99)
            }));
            Assert.Equal(3, dictionaryOfStudentAndScore.Count);
            Assert.Equal("Yu Wen", dictionaryOfStudentAndScore[5L].CourseList[0].Name);
            Assert.Equal(23, dictionaryOfStudentAndScore[5L].CourseList[0].Score);
        }
        [Fact]
        public void should_success_when_remove_the_Score_which_studentId_is_1_in_the_dictionaryOfStudentAndScore()
        {
            var school = new School();
            var dictionaryOfStudentAndScore = school.GetDictionaryOfStudentAndScore();
            Assert.Equal(2, dictionaryOfStudentAndScore.Count);
            dictionaryOfStudentAndScore.Remove(1L);
            Assert.Single(dictionaryOfStudentAndScore);
            Assert.Throws<KeyNotFoundException>(() => dictionaryOfStudentAndScore[1L]);
        }
        [Fact]
        public void should_success_when_update_the_Score_which_studentId_is_1_in_the_dictionaryOfStudentAndScore()
        {
            var school = new School();
            var dictionaryOfStudentAndScore = school.GetDictionaryOfStudentAndScore();
            Assert.Equal(2, dictionaryOfStudentAndScore.Count);
            Assert.Equal(2, dictionaryOfStudentAndScore[1L].CourseList.Count);
            dictionaryOfStudentAndScore[1L] = new Score(new List<Course>
            {
                new Course("Ying Yu", 78)
            });
            Assert.Equal(2, dictionaryOfStudentAndScore.Count);
            Assert.Single(dictionaryOfStudentAndScore[1L].CourseList);
        }

        [Fact]
        public void should_be_correct_value_of_hashSet()
        {
            var school = new School();
            var hashSetOfTotalScore1 = school.GetHashSetOfTotalScore1();
            var hashSetOfTotalScore2 = school.GetHashSetOfTotalScore2();
            Assert.Equal(2, hashSetOfTotalScore1.Count);
            Assert.Contains(170, hashSetOfTotalScore1);
            Assert.Contains(134, hashSetOfTotalScore1);
            Assert.Equal(2, hashSetOfTotalScore2.Count);
            Assert.Contains(156, hashSetOfTotalScore2);
            Assert.Contains(153, hashSetOfTotalScore2);
        }
        [Fact]
        public void should_be_correct_when_get_intersect_set()
        {
            var school = new School();
            var hashSetOfTotalScore1 = school.GetHashSetOfTotalScore1();
            var hashSetOfTotalScore2 = school.GetHashSetOfTotalScore2();
            hashSetOfTotalScore1.IntersectWith(hashSetOfTotalScore2);
            Assert.Empty(hashSetOfTotalScore1);
        }
        [Fact]
        public void should_be_correct_when_get_union_set()
        {
            var school = new School();
            var hashSetOfTotalScore1 = school.GetHashSetOfTotalScore1();
            var hashSetOfTotalScore2 = school.GetHashSetOfTotalScore2();
            hashSetOfTotalScore1.UnionWith(hashSetOfTotalScore2);
            Assert.Equal(4, hashSetOfTotalScore1.Count);
            Assert.Contains(170, hashSetOfTotalScore1);
            Assert.Contains(134, hashSetOfTotalScore1);
            Assert.Contains(156, hashSetOfTotalScore1);
            Assert.Contains(153, hashSetOfTotalScore1);
        }
        [Fact]
        public void should_be_correct_when_get_except_set()
        {
            var school = new School();
            var hashSetOfTotalScore1 = school.GetHashSetOfTotalScore1();
            var hashSetOfTotalScore2 = school.GetHashSetOfTotalScore2();
            hashSetOfTotalScore2.Add(170);
            hashSetOfTotalScore1.ExceptWith(hashSetOfTotalScore2);
            Assert.Single(hashSetOfTotalScore1);
            Assert.Contains(134, hashSetOfTotalScore1);
        }
    }
}
