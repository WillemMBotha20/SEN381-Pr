using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Call : Calls
    {
        public override BusinessClient Client { get => Client; set => Client = value; }
        public override DateTime CallLogging { get => CallLogging; set => CallLogging = value; }
        public override Service ServiceType { get => ServiceType; set => ServiceType = value; }
        public override string ClientRequest { get => ClientRequest; set => ClientRequest = value; }

        public Call(BusinessClient client, DateTime callLogging, Service serviceType, string clientRequest)
        {
            Client = client;
            CallLogging = callLogging;
            ServiceType = serviceType;
            ClientRequest = clientRequest;
        }

        public override bool Equals(object obj)
        {
            return obj is Call call &&
                   EqualityComparer<BusinessClient>.Default.Equals(Client, call.Client) &&
                   CallLogging == call.CallLogging &&
                   EqualityComparer<Service>.Default.Equals(ServiceType, call.ServiceType) &&
                   ClientRequest == call.ClientRequest &&
                   EqualityComparer<BusinessClient>.Default.Equals(Client, call.Client) &&
                   CallLogging == call.CallLogging &&
                   EqualityComparer<Service>.Default.Equals(ServiceType, call.ServiceType) &&
                   ClientRequest == call.ClientRequest;
        }

        public override int GetHashCode()
        {
            int hashCode = -890523730;
            hashCode = hashCode * -1521134295 + EqualityComparer<BusinessClient>.Default.GetHashCode(Client);
            hashCode = hashCode * -1521134295 + CallLogging.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Service>.Default.GetHashCode(ServiceType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientRequest);
            hashCode = hashCode * -1521134295 + EqualityComparer<BusinessClient>.Default.GetHashCode(Client);
            hashCode = hashCode * -1521134295 + CallLogging.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Service>.Default.GetHashCode(ServiceType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientRequest);
            return hashCode;
        }
    }

}