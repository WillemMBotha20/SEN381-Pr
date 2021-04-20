using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class IndividualClient : Client
    {

        public override string BusinessID { get => BusinessID; set => BusinessID = value; }
        public override Contract ClientContract { get => ClientContract; set => ClientContract = value; }
        public override Address ClientAddress { get => ClientAddress; set => ClientAddress = value; }
        public override string ClientName { get => ClientName; set => ClientName = value; }
        public override string ClientSurname { get => ClientSurname; set => ClientSurname = value; }
        public override string ClientNumber { get => ClientNumber; set => ClientNumber = value; }
        public override string CallsMade { get => CallsMade; set => CallsMade = value; }
        public override string Position { get => Position; set => Position = value; }

        public IndividualClient(string businessID, Contract clientContract, Address clientAddress, string clientName, string clientSurname, string clientNumber, string callsMade, string position)
        {
            BusinessID = businessID;
            ClientContract = clientContract;
            ClientAddress = clientAddress;
            ClientName = clientName;
            ClientSurname = clientSurname;
            ClientNumber = clientNumber;
            CallsMade = callsMade;
            Position = position;
        }
    }
}