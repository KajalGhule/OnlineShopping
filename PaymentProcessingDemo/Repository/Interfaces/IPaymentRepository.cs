using System.Collections.Generic;
using PaymentProcessingDemo.Models;
using Core.Models;
namespace Core.Repositories.Intefaces
{
    public interface IPaymentRepository
    {
        List<Payment> GetPayments();
         Payment GetPaymentById(int id);
        bool Insert(Payment product);
        bool Update(Payment product);
        bool Delete(int id);
    }
}
