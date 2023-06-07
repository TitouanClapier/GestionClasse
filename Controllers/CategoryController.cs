using AutoFact2.Repository;
using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Controllers
{
    public class CategoryController
    {
        public CategoryRepository categoryRepository;
        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<Category> findAll()
        {
            return categoryRepository.findAll();
        }
    }
}
