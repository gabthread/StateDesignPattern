using System;

namespace StateDesignPatternDemo
{
    public class Payment
    {

        public int Id { get; set; }
        public decimal Amount { get; set; }

        public IPaymentState PaymentState { get; set; }

        public void ProcessPayment()
        {
            if(PaymentState != null)
                PaymentState.ProcessPayment(this);
            else
                Console.WriteLine("The Payment State has been set yet");
        }

    }
}