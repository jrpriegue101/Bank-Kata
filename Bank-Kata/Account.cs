namespace Bank_Kata_Voxel;

public class Account
{

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdrawal(int amount) { }

    public void PrintStatement() { }

    public int Balance { get; set; }
}