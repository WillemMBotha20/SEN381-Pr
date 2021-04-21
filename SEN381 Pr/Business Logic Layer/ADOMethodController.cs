using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr
{
    class ADOMethodController
    {

        //Business Logic Layer part of the data passing thru...

        TechADOController TechCon = new TechADOController();
        JobsADOController JobCon = new JobsADOController();
        LoginADOController SecCon = new LoginADOController();
        RequestADOController ReqCon = new RequestADOController();
        CallsADOController CallCon = new CallsADOController();
        ClientADOController ClientCon = new ClientADOController();
        ContractADOController ContractCon = new ContractADOController();
        ReportADOController RepCon = new ReportADOController();
        ServicesADOController ServicesCon = new ServicesADOController();

        //Methods For Technicians

        public DataSet LoadTechData()
        {
            return TechCon.LoadData();
        }

        public void InsertTechData(DataGridView tab, string name, string surname, string number)
        {        
            TechCon.InsertTechnician(new Technician(name,surname,number));      
            tab.DataSource = TechCon.LoadData();
            tab.DataMember = "Table";         
            MessageBox.Show("Inserted Technician");               
        }

        public void UpdateTechData(DataGridView tab, string name, string surname, string number, int id)
        {
            TechCon.UpdateTechnician(new Technician(name, surname, number), id);
            tab.DataSource = TechCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Technician");
        }

        public void DeleteTechData(DataGridView tab,int id)
        {            
            TechCon.DeleteTechnician(id);                      
            tab.DataSource = TechCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Technician");
        }

        //Methods for Services

        public void LoadServices(DataGridView tab)
        {            
            tab.DataSource = ServicesCon.LoadData();
            tab.DataMember = "Table";
        }

        public void InsertService(DataGridView tab, string id,string name,string desc,string level,int period,string sal,bool equip)
        {
            id = level + name.Substring(0, 3).ToUpper() + (ServicesCon.CountServices() + 1).ToString();                      
            ServicesCon.InsertService(new Service(id.ToString(),name,desc,period,sal,level,equip));
            tab.DataSource = ServicesCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Inserted Service");
        }

        public void UpdateService(DataGridView tab, string id, string name, string desc, string level, int period, string sal, bool equip)
        {            
            ServicesCon.UpdateService(new Service(id, name, desc, period, sal, level, equip));
            tab.DataSource = ServicesCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Updated Service");
        }

        public void DeleteService(DataGridView tab, string id, string name, string desc, string level, int period, string sal, bool equip)
        {
            ServicesCon.DeleteService(new Service(id, name, desc, period, sal, level, equip));
            tab.DataSource = ServicesCon.LoadData();
            tab.DataMember = "Table";
            MessageBox.Show("Deleted Service");
        }

        //Methods for Jobs
        public DataSet LoadJobData()
        {
            return JobCon.LoadData();
        }

        public void InsertJobData(DataGridView tab)
        {
            RefreshData(tab);
            //tab.DataSource = JobCon.InsertJob(new Job());
            tab.DataMember = "Table";
        }

        public void UpdateJobData(DataGridView tab, string id)
        {
            RefreshData(tab);
            //tab.DataSource = JobCon.UpdateJob(new Job(), id);
            tab.DataMember = "Table";
        }

        public void DeleteJobData(DataGridView tab, string id)
        {
            RefreshData(tab);
            tab.DataSource = JobCon.DeleteJob(id);
            tab.DataMember = "Table";
        }

        //Security Layer Controllers

        public List<string> ValidateCredentials(string username)
        {
            List<string> UserCredentials = new List<string>();
            int i = 0;

            foreach (DataRow row in SecCon.LoadData(username).Tables[i].Rows)
            {               
                if (username == row.ItemArray.GetValue(1).ToString())
                {
                    UserCredentials.Add(row.ItemArray.GetValue(1).ToString());
                    UserCredentials.Add(row.ItemArray.GetValue(3).ToString());
                    break;
                }
                else
                {
                    UserCredentials.Add(null);
                    UserCredentials.Add(null);
                }
                i++;
            }

            return UserCredentials;
        }

        //Request ADO Controllers/Methods

        public void LoadReqData(DataGridView tab)
        {
            RefreshData(tab);
            tab.DataSource = ReqCon.LoadData();
            tab.DataMember = "Table";
        }

        public void SortData(DataGridView tab,string sort)
        {
            RefreshData(tab);
            tab.DataSource = ReqCon.SortData(sort);
            tab.DataMember = "Table";
        }

        //Call Handler ADO Method Controllers

        public void LoadCallClients(DataGridView tab)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = ClientCon.LoadData();
            tab.DataMember = "Table";
        }

        public void LoadCalls(DataGridView tab)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = CallCon.LoadData();
            tab.DataMember = "Table";
        }

        //Contract ADO Controller Methods

        public void LoadContracts(DataGridView tab)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = ContractCon.LoadData();
            tab.DataMember = "Table";
        }

        //Report ADO Controller Methods

        public void LoadReports(DataGridView tab) {

            tab.AutoGenerateColumns = true;
            tab.DataSource = RepCon.LoadData();
            tab.DataMember = "Table";
        }       

        public void SearchReport(DataGridView tab,int refer)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = RepCon.SearchReport(refer);
            tab.DataMember = "Table";
        }

        public void SortReports(DataGridView tab)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = RepCon.SortReportData();
            tab.DataMember = "Table";
        }

        public void RefreshData(DataGridView tab)
        {
            tab.DataSource = null;
            tab.Rows.Clear();
            tab.Update();
            tab.Refresh();
        }       

       

        


    }
}
