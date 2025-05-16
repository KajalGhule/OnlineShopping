using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;
using Core.Models;
using System;

namespace PaymentProcessingDemo
{
    public class PaymentsController : Controller
    {
         private IPaymentService _svc;
        public PaymentsController(IPaymentService svc)
        {
            this._svc = svc;
        }
        public IActionResult Index()
        {
           List<Payment> allProducts= _svc.GetPayments();
           return View(allProducts);  
        }
        public ActionResult Details(int id)
        {
            Payment payment = _svc.GetPaymentById(id);
            this.ViewData["payment"]=payment;
            return View();
        }
      
        [HttpGet]
        public IActionResult Insert()
        {
           Payment payment=new Payment();
           payment.Id=65;
           payment.PaymentDate=DateTime.Now;
           payment.Amount=0;
           payment.OrderId=0;
           payment.PaymentMode="UPI";
           return View(payment);  
        }

        [HttpPost]
        public IActionResult Insert(Payment payment )
        {   
            _svc.Insert(payment);
            return RedirectToAction("Index","Payments");  
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Payment payment = _svc.GetPaymentById(id);
            return View(payment);  
        }

        [HttpPost]
        public IActionResult Update(Payment payment )
        {   
            _svc.Insert(payment);
            return RedirectToAction("Index","Payments");  
        }
          public ActionResult Delete(int id)
        {  
            _svc.Delete(id);
            return RedirectToAction("Index");
        }
    }
}