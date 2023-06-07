using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    public class Profil
    {
        private int _id;
        private string _socialReason;
        private int _siren;
        private string _adress;
        private int _postalCode;
        private string _city;
        private string _tel;
        private string _mail;

        public Profil(int id, string socialReason, int siren, string adress, int postalCode, string city, string tel, string mail)
        {
            this._id = id;
            this._socialReason = socialReason;
            this._siren = siren;
            this._adress = adress;
            this._postalCode = postalCode;
            this._city = city;
            this._tel = tel;
            this._mail = mail;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }

        public string GetSocialReason()
        {
            return _socialReason;
        }

        public void SetSocialReason(string value)
        {
            this._socialReason = value;
        }

        public int GetSiren()
        {
            return _siren;
        }

        public void SetSiren(int value)
        {
            this._siren = value;
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

        public string GetTel()
        {
            return _tel;
        }

        public void SetTel(string value)
        {
            this._tel = value;
        }

        public string GetMail()
        {
            return _mail;
        }

        public void SetMail(string value)
        {
            this._mail = value;
        }
    }
}
