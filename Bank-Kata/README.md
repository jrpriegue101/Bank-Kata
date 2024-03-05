
# Objective
Learn and practice the double loop of TDD Test application from outside, identifying side effects


# Problem description
Create a simple bank application with the following features:

- Deposit into Account
- Withdraw from an Account
- Print a bank statement to the console



# Acceptance criteria
Statement should have transactions in the following format:
```
Given a client makes a deposit of 1000 on 10-01-2012
And a deposit of 2000 on 13-01-2012
And a withdrawal of 500 on 14-01-2012
When they print their bank statement
Then they would see:

  DATE       | AMOUNT  | BALANCE
  10/04/2014 | 500.00  | 1400.00
  02/04/2014 | -100.00 | 900.00
  01/04/2014 | 1000.00 | 1000.00
```

# Starting point and constraints
Start with a class the following structure:
```
public class Account
    {

        public void Deposit(int amount) { }

        public void Withdrawal(int amount) { }

        public void PrintStatement() { }

    }
```
You are not allowed to add any other public method to this class.