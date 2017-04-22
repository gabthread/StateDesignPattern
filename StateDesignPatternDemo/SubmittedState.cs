using System;

namespace StateDesignPatternDemo
{
    public  class SubmittedState : IPaymentState
    {
        public PaymentStatus PaymentStatus { get { return PaymentStatus.Submitted; } }       

        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine("Run Complex Logic to SUBMIT the Payment");

        }
    }
}