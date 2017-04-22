using System;

namespace StateDesignPatternDemo
{
    public class ApprovedState : IPaymentState
    {
        public PaymentStatus PaymentStatus { get { return PaymentStatus.Approved;} }

        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine("Run Complex Logic to APPROVE the Payment");
        }
    }
}