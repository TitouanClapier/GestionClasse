using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Type
    {
        private int _id;
        private string _label;

        public Type(int id, string label)
        {
            this._id = id;
            this._label = label;
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
    }
}
