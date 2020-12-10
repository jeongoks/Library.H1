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
            Library testLibrary = new Library("Sønderborg");
            Loanee loanee = new Loanee(1, "Michael", "SomeEmail");
            testLibrary.Loanees.Add(loanee);

            //  Act
            string test = testLibrary.GetLoanee(1);   //  Should return 

            //  Assert
            Assert.Contains("Michael", test);   //  ([Expected], [Actual])
        }
    }
}
