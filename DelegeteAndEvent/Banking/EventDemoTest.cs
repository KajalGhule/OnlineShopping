using System;


namespace Banking
{
    public static class Government
    {
        public static void PayIncomeTax()
        {
            Console.WriteLine("PayIncomeTax");
        }
        public static void PayPropertyTax()
        {
            Console.WriteLine(" PayPropertyTax");
        }
        public static void PayServiceTax()
        {
            Console.WriteLine("PayServiceTax ");
        }
    }
    public static class HDFC
    {
        public static void BlockAccount()
        {
            Console.WriteLine("Your account is block due to less balance");
        }
        public static void SendMail()
        {
            Console.WriteLine("Your account details sent to your email id ");
        }
    }
}
