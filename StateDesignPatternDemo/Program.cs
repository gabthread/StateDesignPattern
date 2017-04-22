using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var submittedPayment = new Payment() { PaymentState = new SubmittedState()};
            submittedPayment.ProcessPayment();
            Console.ReadKey();

            var approvedPayment = new Payment() { PaymentState = new ApprovedState() };
            approvedPayment.ProcessPayment();
            Console.ReadKey();

            var completedPayment = new Payment() { PaymentState = new CompletedState() };
            completedPayment.ProcessPayment();
            Console.ReadKey();

        }
    }
}
