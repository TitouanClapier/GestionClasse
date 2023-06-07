using AutoFact2.Models;
using AutoFact2.Repository;
using AutoFact2.Views;
using System;
using System.Collections.Generic;

namespace AutoFact2.Controllers
{
    public class InvoiceLineController
    {
        private InvoiceLineRepository inLineRepository;

        public InvoiceLineController()
        {
            inLineRepository = new InvoiceLineRepository();
        }

        public List<Invoiceline> FindAll(int invoiceId)
        {
            return inLineRepository.FindAll(invoiceId);
        }

        public Invoiceline Find(int id)
        {
            return inLineRepository.Find(id);
        }

        public int Create(int invoiceId, int productId, int quantity, decimal price, decimal promotion)
        {
            Invoiceline invoiceLine = new Invoiceline(invoiceId, productId, quantity, price, promotion );
            int id = inLineRepository.Create(invoiceLine);
            return id;
        }

        public void Create(Invoiceline invoiceLine)
        {
            int id = inLineRepository.Create(invoiceLine);
            invoiceLine.SetId(id);
        }

        public void Update(int id, int productId, int quantity, decimal price, decimal promotion)
        {
            Invoiceline invoiceLine = inLineRepository.Find(id);
            if (invoiceLine != null)
            {
                
                invoiceLine.SetIdProduct(productId);
                invoiceLine.SetQuantity(quantity);
                invoiceLine.SetPrice(price);
                invoiceLine.SetPromotion(promotion);
                inLineRepository.Update(invoiceLine);
            }
        }

        public void Delete(int id)
        {
            inLineRepository.Delete(id);
        }
    }
}
