using AutoFact2.Repository;
using AutoFact2.Views;
using AutoFact2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Controllers
{
    public class ProductController
    {
        public ProductRepository proRepository;
        public ProductController()
        {
            proRepository = new ProductRepository();
        }

        public List<Product> FindAll()
        {
            return proRepository.FindAll();
        }

        public Product Find(int id)
        {
            return proRepository.Find(id);
        }

        public void create(string label, float unitPrice, int idCategory)
        {
            proRepository.Create(label, unitPrice, idCategory);
        }

        public void delete(int id)
        {
            proRepository.Delete(id);
        }

        public void update(int id, string label, float unitPrice, int idCategory)
        {
            proRepository.Update(id, label, unitPrice, idCategory);
        }
    }
}
