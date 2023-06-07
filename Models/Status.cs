using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Status
    {
        private int _idQuote;
        private int _idType;
        private DateTime _date;
        private List<Quote> _listQuote;
        private List<Type> _listType;

        public Status(int idQuote, int idType, DateTime date)
        {
            this._idQuote = idQuote;
            this._idType = idType;
            this._date = date;
            this._listQuote = new List<Quote>();
            this._listType = new List<Type>();
        }

        public int GetIdQuote()
        {
            return _idQuote;
        }

        public void SetIdQuote(int value)
        {
            this._idQuote = value;
        }

        public int GetIdType()
        {
            return _idType;
        }

        public void SetIdType(int value)
        {
            this._idType = value;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public void SetDate(DateTime value)
        {
            this._date = value;
        }
    }
}
