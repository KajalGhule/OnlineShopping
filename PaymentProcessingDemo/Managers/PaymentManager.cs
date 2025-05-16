using System.Collections.Generic;
using System;
using System.Linq;
using Core.Models;
using Core.DBContexts;

namespace Core.Managers
{
    public class PaymentManager : IPaymentManager
    {
        public void Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Payments.Remove(context.Payments.Find(id));
                context.SaveChanges();
            }
        }

        public List<Payment> GetAll()
        {
            using (var context = new CollectionContext())
            {
             var products = from prod in context.Payments select prod;
             return products.ToList<Payment>();
            }
        }

        public Payment GetById(int id)
        {
            using (var context = new CollectionContext())
            {
             var product = context.Payments.Find(id);
             return product;
            }
        }

        public void Insert(Payment payment)
        {
            using(var context = new CollectionContext())
            {
                context.Payments.Add(payment);
                context.SaveChanges();   
            }
        }

        public void Update(Payment payment)
        {
            using(var context = new CollectionContext())
            {
                var thePayment = context.Payments.Find(payment.Id);
                thePayment.Amount =payment.Amount;
                thePayment.PaymentMode=payment.PaymentMode;
                context.SaveChanges();
            }
        }
    }
}