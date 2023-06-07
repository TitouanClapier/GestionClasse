using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    public class Quote
    {
        private int _id;

        public Quote(int id)
        {
            this._id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }
    }
}
