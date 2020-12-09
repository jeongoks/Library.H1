using System;
using Xunit;

namespace Library.H1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetLoaneeTest()
        {
            //  Arrange
            Library testLibrary = new Library("Aarhus");
            
            //  Act
            testLibrary.CreateLoanee(1, "Michael");  //  Actual Test
            string test = testLibrary.GetLoanee(1);   //  Should return 

            //  Assert
            Assert.Contains("Michael", test);   //  ([Expected], [Actual])
        }
    }
}
