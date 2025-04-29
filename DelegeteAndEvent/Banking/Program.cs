// See https://aka.ms/new-console-template for more information
using Banking;

Console.WriteLine("Hello, World!");

/*
 * Observer pattern
 Event Driven Mechanism apply
 Define delegate
 Defined your class with event
 write a logic to raise event based on condition
 define event handler logic 
 register event handler with delegate before method invoke
 */

Account acc = new Account(50000);

//events is getting resigered with event handler

//Subscribe to account 
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


