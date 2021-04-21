using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Service 
    {
        private string _serviceId;
        private string _serviceName;
        private string _serviceDescription;
        private int _serviceDuration;
        private string _serviceAgreement;
        private string _serviceLevel;
        private bool _equipment;

        public Service(string serviceId, string serviceName, string serviceDescription, int serviceDuration, string serviceAgreement, string serviceLevel, bool equipment)
        {
            _serviceId = serviceId;
            _serviceName = serviceName;
            _serviceDescription = serviceDescription;
            _serviceDuration = serviceDuration;
            _serviceAgreement = serviceAgreement;
            _serviceLevel = serviceLevel;
            _equipment = equipment;
        }

        public string ServiceId { get => _serviceId; set => _serviceId = value; }
        public string ServiceName { get => _serviceName; set => _serviceName = value; }
        public string ServiceDescription { get => _serviceDescription; set => _serviceDescription = value; }
        public int ServiceDuration { get => _serviceDuration; set => _serviceDuration = value; }
        public string ServiceAgreement { get => _serviceAgreement; set => _serviceAgreement = value; }
        public string ServiceLevel { get => _serviceLevel; set => _serviceLevel = value; }
        public bool Equipment { get => _equipment; set => _equipment = value; }

        public override bool Equals(object obj)
        {
            return obj is Service service &&
                   _serviceId == service._serviceId &&
                   _serviceName == service._serviceName &&
                   _serviceDescription == service._serviceDescription &&
                   _serviceDuration == service._serviceDuration &&
                   _serviceAgreement == service._serviceAgreement &&
                   _serviceLevel == service._serviceLevel &&
                   _equipment == service._equipment &&
                   ServiceId == service.ServiceId &&
                   ServiceName == service.ServiceName &&
                   ServiceDescription == service.ServiceDescription &&
                   ServiceDuration == service.ServiceDuration &&
                   ServiceAgreement == service.ServiceAgreement &&
                   ServiceLevel == service.ServiceLevel &&
                   Equipment == service.Equipment;
        }

        public override int GetHashCode()
        {
            int hashCode = 1366509473;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_serviceId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_serviceName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_serviceDescription);
            hashCode = hashCode * -1521134295 + _serviceDuration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_serviceAgreement);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_serviceLevel);
            hashCode = hashCode * -1521134295 + _equipment.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceDescription);
            hashCode = hashCode * -1521134295 + ServiceDuration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceAgreement);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceLevel);
            hashCode = hashCode * -1521134295 + Equipment.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}