using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class CallHandler
    {
        private Call _clientCall;
        private Request _clientRequest;
        private string _referenceNumber;

        public CallHandler(Call clientCall, Request clientRequest, string referenceNumber)
        {
            _clientCall = clientCall;
            _clientRequest = clientRequest;
            _referenceNumber = referenceNumber;
        }

        public Call ClientCall { get => _clientCall; set => _clientCall = value; }
        public Request ClientRequest { get => _clientRequest; set => _clientRequest = value; }
        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }

        public void LogCall()
        {

        }

        public void CreateJob()
        {

        }

        public void AnswerCall()
        {

        }

        public void EndCall()
        {

        }

        public void MakeCall(BusinessClient client)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is CallHandler handler &&
                   EqualityComparer<Call>.Default.Equals(_clientCall, handler._clientCall) &&
                   EqualityComparer<Request>.Default.Equals(_clientRequest, handler._clientRequest) &&
                   _referenceNumber == handler._referenceNumber &&
                   EqualityComparer<Call>.Default.Equals(ClientCall, handler.ClientCall) &&
                   EqualityComparer<Request>.Default.Equals(ClientRequest, handler.ClientRequest) &&
                   ReferenceNumber == handler.ReferenceNumber;
        }

        public override int GetHashCode()
        {
            int hashCode = -2125340607;
            hashCode = hashCode * -1521134295 + EqualityComparer<Call>.Default.GetHashCode(_clientCall);
            hashCode = hashCode * -1521134295 + EqualityComparer<Request>.Default.GetHashCode(_clientRequest);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_referenceNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<Call>.Default.GetHashCode(ClientCall);
            hashCode = hashCode * -1521134295 + EqualityComparer<Request>.Default.GetHashCode(ClientRequest);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceNumber);
            return hashCode;
        }
    }
}