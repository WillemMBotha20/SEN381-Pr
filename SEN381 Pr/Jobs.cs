using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public abstract class Jobs
    {
        private string _jobName;
        private string _referenceNumber;
        private string _progression;
        private DateTime _arramgedData;
        private bool _completed;
        private Request _jobRequest;
        private Technician _technician;

        public abstract string JobName { get ; set ; }
        public abstract string ReferenceNumber { get; set; }
        public abstract string Progression { get; set; }
        public abstract DateTime ArramgedData { get; set; }
        public abstract bool Completed { get; set; }
        public abstract Technician JobTechnician { get; set; }
    }
}