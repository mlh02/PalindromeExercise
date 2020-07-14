using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("maomom", false)]

        public void IsAPalindromeTest(string str, bool expected)
        {
            //Arrange
            PalindromeExercise.WordSmith sut = new PalindromeExercise.WordSmith();

            //Act

            bool actual = sut.IsAPalindrome(str);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
//DONE ake sure the PalindromeExerciseTests project file has PalindromeExercise added as a reference.

//DONE → Right click dependencies in PalindromeExerciseTests to check and add if need be

//Create a class named WordSmith in your PalindromeExercise project file.This is where you will eventually create your IsAPalindrome() method

//In your WordSmith class, you will create a method(IsAPalindrome) that will take a parameter of type string and return a value of type bool.  If the given input is a palindrome – return true, else return false. 

//Write you test method in the UnitTest1.cs file - located in the PalindromeExerciseTests project file

//Remove the [Fact] portion and replace it with:
//[Theory]
//[InlineData()] ← you will need to put some test data and expected result here.  

//For example [InlineData(“racecar”, true)]

//Finish the test with arrange, act, assert and make your IsAPalindrome method pass the tests
