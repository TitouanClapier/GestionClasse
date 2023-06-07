using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    public class Category
    {
        private int _id;
        private string _label;
        private List<Product> _listProduct;

        public Category(int id, string label)
        {
            this._id = id;
            this._label = label;
            this._listProduct = new List<Product>();
        }

        public void SetId(int id)
        {
            this._id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetLabel(string label)
        {
            this._label = label;
        }

        public string GetLabel()
        {
            return _label;
        }

        public List<Product> GetListProduct()
        {
            return _listProduct;
        }

        public void SetProduct(Product product)
        {
            this._listProduct.Add(product);
        }
    }
}
