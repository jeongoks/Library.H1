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
            Library newLibrary = new Library("Aarhus");
            //Loanee newloanee = new Loanee(1, "Michael"); // To Compare Against
            //string preResult = $"LoaneeNumber: {newloanee.LoaneeNumber}. {newloanee.LoaneeName} is a Loanee at Aarhus."; // prebuild result to compare against

            //  Act
            newLibrary.CreateLoanee(1, "Michael");  //  Actual Test
            string test = newLibrary.GetLoanee();   //  Should return 

            //  Assert
            Assert.Contains("Michael", test);
        }
    }
}
