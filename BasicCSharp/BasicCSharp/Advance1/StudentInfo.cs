namespace BasicCSharp.Advance1
{
    public class StudentInfo
    {
        public long Id { get; }

        public string Name { get; }

        public int Class { get; }

        public string Gender { get; }

        public int Age { get; }

        public StudentInfo(long id, string name, int @class, string gender, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Class = @class;
            this.Gender = gender;
            this.Age = age;
        }
    }
}
