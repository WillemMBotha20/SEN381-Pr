using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Service : Services
    {
        public override string ServiceName { get { return ServiceName; } set { ServiceName = value; } }
        public override string ServiceDescription { get { return ServiceDescription; } set { ServiceDescription = value; } }
        public override int ServiceDuration { get { return ServiceDuration; } set { ServiceDuration = value; } }
        public override string ServiceAgreement { get { return ServiceAgreement; } set { ServiceAgreement = value; } }
        public override int ServiceLevel { get { return ServiceLevel; } set { ServiceLevel = value; } }

        public Package Package
        {
            get => default;
            set
            {
            }
        }

        public Service(string serviceName, string serviceDescription, int serviceDuration, string serviceAgreement, int serviceLevel)
        {
            ServiceName = serviceName;
            ServiceDescription = serviceDescription;
            ServiceDuration = serviceDuration;
            ServiceAgreement = serviceAgreement;
            ServiceLevel = serviceLevel;
        }

        public override bool Equals(object obj)
        {
            return obj is Service service &&
                   ServiceName == service.ServiceName &&
                   ServiceDescription == service.ServiceDescription &&
                   ServiceDuration == service.ServiceDuration &&
                   ServiceAgreement == service.ServiceAgreement &&
                   ServiceLevel == service.ServiceLevel &&
                   ServiceName == service.ServiceName &&
                   ServiceDescription == service.ServiceDescription &&
                   ServiceDuration == service.ServiceDuration &&
                   ServiceAgreement == service.ServiceAgreement &&
                   ServiceLevel == service.ServiceLevel;
        }

        public override int GetHashCode()
        {
            int hashCode = 1443021598;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceDescription);
            hashCode = hashCode * -1521134295 + ServiceDuration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceAgreement);
            hashCode = hashCode * -1521134295 + ServiceLevel.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceDescription);
            hashCode = hashCode * -1521134295 + ServiceDuration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceAgreement);
            hashCode = hashCode * -1521134295 + ServiceLevel.GetHashCode();
            return hashCode;
        }
    }
}