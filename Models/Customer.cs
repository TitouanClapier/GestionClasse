using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    public abstract class Customer
    {
        private int _id;
        private string _adress;
        private int _postalCode;
        private string _city;
        private string _mail;
        private string _tel;
        private List<Quote> _listQuote;


        public Customer(int id, string adress, int postalCode, string city, string mail, string tel)
        {
            this._id = id;
            this._adress = adress;
            this._postalCode = postalCode;
            this._city = city;
            this._mail = mail;
            this._tel = tel;
            this._listQuote = new List<Quote>();
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }

        public string GetAdress()
        {
            return _adress;
        }

        public void SetAdress(string value)
        {
            this._adress = value;
        }

        public int GetPostalCode()
        {
            return _postalCode;
        }

        public void SetPostalCode(int value)
        {
            this._postalCode = value;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetCity(string value)
        {
            this._city = value;
        }

        public string GetMail()
        {
            return _mail;
        }

        public void SetMail(string value)
        {
            this._mail = value;
        }

        public string GetTel()
        {
            return _tel;
        }

        public void SetTel(string value)
        {
            this._tel = value;
        }

        public List<Quote> GetListQuote()
        {
            return _listQuote;
        }

        public void SetQuote(Quote quote)
        {
            this._listQuote.Add(quote);
        }

        public virtual string GetName()
        {
            return string.Empty;
        }

        public virtual string GetLastname()
        {
            return string.Empty;
        }

        public virtual string GetCompanyName()
        {
            return string.Empty;
        }

        /*public void SetName(string value)
        {
            this._Name = value;
        }
        public void SetSurname(string value)
        {
            this._tel = value;
        }
        public void SetCompany(string value)
        {
            this._tel = value;
        }*/
    }
}
