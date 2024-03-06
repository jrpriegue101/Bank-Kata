namespace Bank_Kata_Voxel;

public class Account
{

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount) {
        Balance -= amount;
    }

    public void PrintStatement() { }

    public int Balance { get; set; }
}