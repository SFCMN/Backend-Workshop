using System.Collections.Generic;
using Xunit;

namespace BasicCSharp.Advance1
{
    public class ListExtensionTest
    {
        [Fact]
        public void should_return_correct_unique_list()
        {
            string[] letters = { "a", "b", "c", "a" };
            string[] uniqueLetters = { "a", "b", "c" };
            var expected = new List<string>(uniqueLetters);

            var letterList = new List<string>(letters);
            var actualUniqueLetterList = letterList.ExtendedUnique();

            Assert.Equal(expected, actualUniqueLetterList);
        }
    }
}
