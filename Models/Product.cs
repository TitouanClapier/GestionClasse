using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    public class Product
    {
        private int _id;
        private string _label;
        private float _unitPrice;
        private int _idCategory;

        public Product(int id, string label, float unitPrice, int idCategory)
        {
            this._id = id;
            this._label = label;
            this._unitPrice = unitPrice;
            this._idCategory = idCategory;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }

        public string GetLabel()
        {
            return _label;
        }

        public void SetLabel(string value)
        {
            this._label = value;
        }

        public float GetUnitPrice()
        {
            return _unitPrice;
        }

        public void SetUnitPrice(float value)
        {
            this._unitPrice = value;
        }

        public int GetIdCategory()
        {
            return _idCategory;
        }

        public void SetIdCategory(int value)
        {
            this._idCategory = value;
        }
    }
}
