using System;
using Prime.Service;
using Xunit;

namespace Palindrome.Grader
{
    public class PalindromeServiceTests
    {

        [Fact]
        public void Constructor_Succeeds()
        {
            // should not throw exception
            new PalindromeService();
        }

        [Theory]
        [InlineData("madam")]
        [InlineData("racecar")]
        public void IsPalindrome_AllLowercasePalindrome_ReturnsTrue(string value)
        {
            var palindromeService = new PalindromeService();

            bool result = palindromeService.IsPalindrome(value);

            Assert.True(result);
        }

        [Theory]
        [InlineData("palindrome")]
        [InlineData("crab")]
        public void IsPalindrome_AllLowercaseNonPalindrome_ReturnsFalse(string value)
        {
            var palindromeService = new PalindromeService();

            bool result = palindromeService.IsPalindrome(value);

            Assert.False(result);
        }
    }
}
