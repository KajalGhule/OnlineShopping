// See https://aka.ms/new-console-template for more information
//using DelegeteAndEvent;

using static DelegeteAndEvent.Delegates;

Console.WriteLine("Hello, World!");

//early binding
//PayIncomeTax();

//Late binding Unicast delegate
Handler operation1 = null;
operation1 = new Handler(PayIncomeTax); // registering name of function to be invoke
//operation1();

Handler operation2 = null;
operation2 = new Handler(PayPropertyTax);
//operation2();

Handler operation3 = null;
operation3 = new Handler(PayServiceTax);
//operation3();


Handler masterOperationManager = null; // Multicast
masterOperationManager = operation1;
masterOperationManager += operation2;
masterOperationManager += operation3;
masterOperationManager(); // One invokation multicast delegate