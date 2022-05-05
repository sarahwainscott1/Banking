using Banking;

var sav1 = new SavingsComp();
sav1.Name = "My Savings";

sav1.Deposit(100);
sav1.PayInterest(8);

Console.WriteLine($"{sav1.Balance:c}");

/*
var acct1 = new Account() {
    Name = "Checking1"
    };
var acct2 = new Account() {
    Name = "Checking2"
    };

acct1.Deposit(1000);
acct2.Deposit(500);

acct1.Withdraw(200);
acct2.Withdraw(50);

Console.WriteLine($"{acct1.Name} Balance is {acct1.Balance:c}.\n{acct2.Name} Balance is {acct2.Balance:c}."); //:c formats for currency

acct1.Withdraw(1000); // should fail because after above bal is 800

Console.WriteLine($"{acct1.Name} Balance is {acct1.Balance:c}.\n{acct2.Name} Balance is {acct2.Balance:c}.");

acct2.Transfer(100, acct1);
Console.WriteLine($"{acct1.Name} Balance is {acct1.Balance:c}.\n{acct2.Name} Balance is {acct2.Balance:c}.");

acct1.Deposit(-100); //deposit negative number acts like a withdraw. negative withdraw would act like deposit
acct2.Withdraw(-200);
Console.WriteLine($"{acct1.Name} Balance is {acct1.Balance:c}.\n{acct2.Name} Balance is {acct2.Balance:c}.");
*/