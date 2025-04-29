using System;


namespace Banking
{
    //subscriber 1
    public static class Government
    {
        // always contain handler
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
    //subscriber 2
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
