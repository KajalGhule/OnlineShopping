
using System.Collections.Generic;
using Core.Models;
using Core.Repositories.Intefaces;
using Core.Managers;
using Core.Services.Interfaces;

namespace Core.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
       
        public List<Payment> GetPayments()
        {
             IPaymentManager dbm=new PaymentManager();
            List<Payment> items=new List<Payment>();          
            List<Payment> allProducts=dbm.GetAll();
            foreach(Payment theProduct in allProducts){
                items.Add(new Payment{
                    Id=theProduct.Id,
                    OrderId=theProduct.OrderId,
                    Amount=theProduct.Amount,
                    PaymentDate=theProduct.PaymentDate,
                    PaymentMode=theProduct.PaymentMode
                });
            }
            return items;
        }

        public Payment GetPaymentById(int id)
        {

            IPaymentManager dbm=new PaymentManager();
            Payment payment=dbm.GetById(id);
            
            return payment;
          
        }

        

        public bool Insert(Payment payment)
        {
            IPaymentManager dbm=new PaymentManager();
            dbm.Insert(payment);
            return true;
        
        }

        public bool Update(Payment payment)
        {
             
            IPaymentManager dbm=new PaymentManager();
            dbm.Update(payment);
            return true;
        }

         public bool Delete(int id)
        {
             IPaymentManager dbm=new PaymentManager();
             dbm.Delete(id);
             return true;
        }      
    }
}
