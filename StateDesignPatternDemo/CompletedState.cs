using System;

namespace StateDesignPatternDemo
{
    public  class CompletedState : IPaymentState
    {
        public PaymentStatus PaymentStatus { get { return PaymentStatus.Completed; } }       

        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine("Run Complex Logic to COMPLETE the Payment");
        }
    }
}