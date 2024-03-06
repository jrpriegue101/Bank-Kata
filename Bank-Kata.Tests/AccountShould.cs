using Bank_Kata_Voxel;
using FluentAssertions;

namespace Bank_Kata.Tests;

public class AccountShould
{
    
    [Fact]
    public void Add_Money_To_Account_On_Deposit()
    {
        var deposit = 10;
        var account = new Account();
        var expectedBalance = account.Balance + deposit;

        account.Deposit(deposit);
        
        account.Balance.Should().Be(expectedBalance);
    }
    
    [Fact]
    public void Substract_Money_To_Account_On_Withdraw()
    {
        var withdrawAmount = 10;
        
        var account = new Account();
        var expectedBalance = account.Balance - withdrawAmount;

        account.Withdraw(withdrawAmount);
        
        account.Balance.Should().Be(expectedBalance);
    }
}