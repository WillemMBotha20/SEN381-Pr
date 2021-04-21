using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class ServicesADOController
    {
        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Services");
        }

        public DataSet InsertService(Service ser)
        {          
            return Controller.CarryCommand($"INSERT INTO Services (ServiceId,ServiceName,ServiceDescription,ServiceLevel,ResolutionPeriod,ServiceLevelAgreement,IsEquipment) VALUES ('{ser.ServiceId}','{ser.ServiceName}','{ser.ServiceDescription}','{ser.ServiceLevel}',{ser.ServiceDuration},'{ser.ServiceAgreement}',{Convert.ToByte(ser.Equipment)})");
        }

        public DataSet DeleteService(Service ser)
        {
            return Controller.CarryCommand($"DELETE FROM Services WHERE ServiceId = '{ser.ServiceId}'");
        }

        public DataSet UpdateService(Service ser)
        {
            return Controller.CarryCommand($"UPDATE Services SET ServiceName = '{ser.ServiceName}',ServiceDescription = '{ser.ServiceLevel}',ServiceLevel = '{ser.ServiceLevel}',ResolutionPeriod = {ser.ServiceDuration},ServiceLevelAgreement = '{ser.ServiceAgreement}',IsEquipment = {Convert.ToByte(ser.Equipment)} WHERE ServiceId = '{ser.ServiceId}'");
        }

        public int CountServices()
        {
            return  Controller.CarryCommand("SELECT * FROM Services").Tables[0].Rows.Count;
        }
    }
}
