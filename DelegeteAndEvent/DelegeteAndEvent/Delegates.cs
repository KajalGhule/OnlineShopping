using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegeteAndEvent
{
    public class Delegates
    {
        public delegate void Handler();
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
}
