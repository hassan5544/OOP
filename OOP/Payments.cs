using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Payments : BaseEntity
    {
        public decimal AmountDollar { get; set; }
        public decimal AmountIQD { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsPaid { get; set; } = false;

        public Payments(Guid Id ,decimal amountUSD , decimal amountIQD , decimal rate)
        {
            EntityId = Id;
            AmountDollar = amountUSD;
            AmountIQD = amountIQD;
            ExchangeRate = rate;
        }


        public Payments()
        {

        }

        public Payments GetById (Guid Id)
        {
            Payments payment = new Payments();
            return payment;
        }
        public Guid AddPayment(decimal amountUSD, decimal amountIQD, decimal rate)
        {
            Guid PaymentId = Guid.NewGuid();
            Payments payments = new Payments(PaymentId , amountUSD , amountIQD , rate);
            return PaymentId;
        }

        public void UpdateIsPaid(Guid PaymentId)
        {
            Payments payment = GetById(PaymentId);
            payment.IsPaid = true;
        }
    }
}
