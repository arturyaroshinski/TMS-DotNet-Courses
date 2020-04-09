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
            decimal actualBalance = client.GetBalance();
            // Assert
            decimal expectedBalance = 0;
            Assert.Equal(expectedBalance, actualBalance);
        }
    }
}