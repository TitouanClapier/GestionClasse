using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    public class Moral:Customer
    {
        private string _companyName;

        public Moral(int id, string companyName, string address, int postalCode, string city, string mail, string tel) : base(id, address, postalCode, city, mail, tel)
        {
            this._companyName = companyName;
        }



        public override string GetCompanyName()
        {
            base.GetCompanyName();
            return _companyName;
        }

        public void SetCompanyName(string value)
        {
            this._companyName = value;
        }
    }
}
