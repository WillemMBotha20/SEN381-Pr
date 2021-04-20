using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Package
    {
        private List<Service> _serviceslsit;

        public Package(List<Service> serviceslsit)
        {
            _serviceslsit = serviceslsit;
        }

        public List<Service> Serviceslsit { get => _serviceslsit; set => _serviceslsit = value; }

        public Contract Contract
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Package package &&
                   EqualityComparer<List<Service>>.Default.Equals(_serviceslsit, package._serviceslsit);
        }

        public override int GetHashCode()
        {
            return -1301553130 + EqualityComparer<List<Service>>.Default.GetHashCode(_serviceslsit);
        }
    }
}