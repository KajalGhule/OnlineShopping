
using System.Collections.Generic;
using Core.Models;

namespace Core.Managers
{
    public interface IPaymentManager{
        List<Payment> GetAll();
        Payment GetById(int id);
        void Insert(Payment product);
        void Update(Payment product);
        void Delete(int id);
    }
}