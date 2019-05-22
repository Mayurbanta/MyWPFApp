using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFApp
{
    public class IDataErrorInfoViewModel : IDataErrorInfo
    {

        private string empId;
        public string EmpId
        {
            get { return empId; }
            set
            {
                empId = value;

                EmpName = "A";
            }
        }
        private string empName;
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private string accountno;
        public string AccountNo
        {
            get { return accountno; }
            set { accountno = value; }
        }

        public string this[string columnName]
        {
            get
            {
                string responseMessage = String.Empty;
                switch (columnName)
                {
                    case "EmpId":
                        if (String.IsNullOrEmpty(this.EmpId))
                        {
                            responseMessage = "Please enter the Employee Id";
                        }
                        else if (this.EmpId.Length < 5)
                        {
                            responseMessage = "Employee Id must be greater then 5 characters";
                        }
                        break;
                    case "EmpName":
                        if (string.IsNullOrEmpty(this.EmpName))
                        {
                            responseMessage = "Name";
                        }
                        break;
                    case "AccountNo":
                        if (columnName.Equals("AccountNo"))
                        {
                            int account;
                            if (string.IsNullOrEmpty(this.AccountNo))
                            {
                                responseMessage = "Please enter the valid Account Number";
                            }
                            else if (!Int32.TryParse(this.AccountNo, out account))
                            {
                                responseMessage = "Account Number must be numeric digit";
                            }
                        }
                        break;
                };
                return responseMessage;
            }
        }

        public string Error => throw new NotImplementedException();



    }
}
