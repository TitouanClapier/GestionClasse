using AutoFact2.Repository;
using AutoFact2.Views;
using AutoFact2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoFact2.Controllers
{
    public class InvoiceController
    {
        public InvoiceRepository InRepository;
        public InvoiceController()
        {
            InRepository = new InvoiceRepository();
        }

        public List<Invoice> findAll()
        {
            return InRepository.findAll();
        }
        public void create(int idCustomer, DateTime DateInvoice)
        {
            InRepository.create(idCustomer, DateInvoice);
        }

        //public void delete(int id)
        //{
        //    InRepository.delete(id);
        //}

        public void update(int id, int idCustomer, DateTime DateInvoice)
        {
            InRepository.update(id, idCustomer, DateInvoice);
        }


    }
}
