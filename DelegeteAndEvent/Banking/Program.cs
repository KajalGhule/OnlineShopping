// See https://aka.ms/new-console-template for more information
using Banking;

Console.WriteLine("Hello, World!");


Account acc = new Account(50000);

//events is getting resigered with event handler
acc.overBalance += new AccountHandler(Government.PayIncomeTax); // register
acc.overBalance += new AccountHandler(HDFC.SendMail);

acc.underBalance += new AccountHandler(HDFC.BlockAccount);
acc.underBalance += new AccountHandler(HDFC.SendMail);

Console.WriteLine("Initial Balance " + acc.Balance);
Console.WriteLine("Enter amount to deposite");
float amount  = float.Parse(Console.ReadLine());  
acc.Deposit(amount);
Console.WriteLine("Net balance after operation : ");
Console.WriteLine(acc.Balance);


Console.WriteLine("Enter amount to Withdraw");
float withdrawAmount = float.Parse(Console.ReadLine());
acc.Withdraw(withdrawAmount);
Console.WriteLine("Net balance after operation : ");
Console.WriteLine(acc.Balance);


