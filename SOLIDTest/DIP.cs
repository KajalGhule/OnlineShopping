using System;

namespace  DIP
{
    //Contract : Policy : Specification: Guidlines
    public interface IAccount
    {
        void Login();
        void Register();
    }

    //Business Logic Layer
    public class Admin : IAccount
    {
        public void Login()
        {
            Console.WriteLine(" Power user Valiation against MongoDB");
        }
        public void Register()
        {
            Console.WriteLine("Register Admin");
        }
    }
 
    public class User : IAccount
    {
        public void Login()
        {
            Console.WriteLine("Check credentails of User from MySQL database");
        }
        public void Register()
        {
            Console.WriteLine("Register new customer");
        }
    }

    public class FacebookUser:IAccount{
        public void Login()
        {
            Console.WriteLine("Check facebook ID from facebook server");
        }
        public void Register()
        {
            Console.WriteLine("Register new customer into Facebook server");
        }
    }
    
    
    //Controller  layer

    public class AccountsController
    {
        IAccount account; 
        public AccountsController(IAccount acct)
        {
            this.account = acct; 
        } 

        //action methods
        public void Login()
        {
            //Preprocessing
            Console.WriteLine("Get Client Token from Browser");
            Console.WriteLine("Get Request context information");
            account.Login();
            //Post Action
            Console.WriteLine("Create JSON object as response and send to remote client");
        }  
        public void Register()
        {
            Console.WriteLine("Before Register Operation");
            Console.WriteLine("Extract InComming Request");
            account.Register();
            Console.WriteLine("Generate and Send Response");            
        }
    }
 


    // frontEnd Layer
    //Console Application
     class Program
    {

        // Security:
        // Authentication and Authorization
        // verifying user credentials
        // registering user  into Users repository
        static void Main(string[] args)
        {
           IAccount actor = new Admin();  // admin------Power User
          // IAccount actor = new User();      // customer---Register User
         //  IAccount actor=new FacebookUser();
            //acting like handler , Receiver
            // manager
            AccountsController controller = new AccountsController(actor);
            controller.Login();
            Console.WriteLine( "*************************************");
            controller.Register();
            Console.Read();
        }
    }  
}

//DIP Principle
// SOA Architecture:
// Service Oriented Architecture
// ASP.NET MVC
// ASP.NET WEB API
// GRPC