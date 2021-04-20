using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Request
    {
        private string _referenceNumber;
        private bool _requestAppropriation;
        private Job _requestJob;

        public Request(string referenceNumber, bool requestAppropriation, Job requestJob)
        {
            _referenceNumber = referenceNumber;
            _requestAppropriation = requestAppropriation;
            _requestJob = requestJob;
        }

        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        public bool RequestAppropriation { get => _requestAppropriation; set => _requestAppropriation = value; }
        public Job RequestJob { get => _requestJob; set => _requestJob = value; }

        public Jobs Jobs
        {
            get => default;
            set
            {
            }
        }

        public Calls Calls
        {
            get => default;
            set
            {
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Request request &&
                   _referenceNumber == request._referenceNumber &&
                   _requestAppropriation == request._requestAppropriation &&
                   EqualityComparer<Job>.Default.Equals(_requestJob, request._requestJob) &&
                   ReferenceNumber == request.ReferenceNumber &&
                   RequestAppropriation == request.RequestAppropriation &&
                   EqualityComparer<Job>.Default.Equals(RequestJob, request.RequestJob);
        }

        public override int GetHashCode()
        {
            int hashCode = 1247221067;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_referenceNumber);
            hashCode = hashCode * -1521134295 + _requestAppropriation.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Job>.Default.GetHashCode(_requestJob);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceNumber);
            hashCode = hashCode * -1521134295 + RequestAppropriation.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Job>.Default.GetHashCode(RequestJob);
            return hashCode;
        }
    }
}