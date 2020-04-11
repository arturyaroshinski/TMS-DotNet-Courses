using BankLib;
using Xunit;

namespace ATMxUnitTest
{
    public class ATMTest
    {
        [Fact]
        public void Client_WhenBalanceIsNegativOrZero_Return_Zero()
        {
            // Arrange
            decimal negValue = -1;
            var client = new Client("Name", negValue);

            // Act
            decimal actual = client.GetBalance();

            // Assert
            decimal expected = 0;
            Assert.Equal(expected, actual);
        }
    }
}