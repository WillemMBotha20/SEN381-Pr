using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Address
    {
        private string _street;
        private string _code;
        private string _suburb;
        private string _country;

        public Address(string street, string code, string suburb, string country)
        {
            _street = street;
            _code = code;
            _suburb = suburb;
            _country = country;
        }

        public string Street { get => _street; set => _street = value; }
        public string Code { get => _code; set => _code = value; }
        public string Suburb { get => _suburb; set => _suburb = value; }
        public string Country { get => _country; set => _country = value; }

        public Client Client
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   _street == address._street &&
                   _code == address._code &&
                   _suburb == address._suburb &&
                   _country == address._country &&
                   Street == address.Street &&
                   Code == address.Code &&
                   Suburb == address.Suburb &&
                   Country == address.Country;
        }

        public override int GetHashCode()
        {
            int hashCode = 260441318;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_suburb);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Suburb);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Country);
            return hashCode;
        }
    }
}