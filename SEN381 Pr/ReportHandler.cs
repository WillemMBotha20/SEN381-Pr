using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class ReportHandler
    {
        private string _referenceNumber;
        private BusinessClient _client;
        private Job _job;

        public ReportHandler(string referenceNumber, BusinessClient client, Job job)
        {
            _referenceNumber = referenceNumber;
            _client = client;
            _job = job;
        }

        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        public BusinessClient Client { get => _client; set => _client = value; }
        public Job Job { get => _job; set => _job = value; }

        public void GenerateReport()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is ReportHandler handler &&
                   ReferenceNumber == handler.ReferenceNumber &&
                   EqualityComparer<BusinessClient>.Default.Equals(Client, handler.Client) &&
                   EqualityComparer<Job>.Default.Equals(Job, handler.Job) &&
                   ReferenceNumber == handler.ReferenceNumber &&
                   EqualityComparer<BusinessClient>.Default.Equals(Client, handler.Client) &&
                   EqualityComparer<Job>.Default.Equals(Job, handler.Job);
        }

        public override int GetHashCode()
        {
            int hashCode = -1287161391;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<BusinessClient>.Default.GetHashCode(Client);
            hashCode = hashCode * -1521134295 + EqualityComparer<Job>.Default.GetHashCode(Job);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<BusinessClient>.Default.GetHashCode(Client);
            hashCode = hashCode * -1521134295 + EqualityComparer<Job>.Default.GetHashCode(Job);
            return hashCode;
        }

       


    }
}