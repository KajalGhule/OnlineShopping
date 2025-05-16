using System.Collections.Generic;
using Core.Repositories.Intefaces;
using Core.Services.Interfaces;
using Core.Models;
using Core.Repositories;

namespace Core.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepo;

        public PaymentService()
        {
            _paymentRepo = new PaymentRepository();;
        }
      
        public Payment GetPaymentById(int id)=>_paymentRepo.GetPaymentById(id);
        public List<Payment> GetPayments()=> _paymentRepo.GetPayments();
        public bool Insert(Payment payment)=> _paymentRepo.Insert(payment);
        public bool Update(Payment payment)=>_paymentRepo.Update(payment);
        public bool Delete(int id) => _paymentRepo.Delete(id);
    }
}