using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample.EmergencyModel
{
    public class EmployeeNotification
    {
        public int EmergencyId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpCode { get; set; }
        public string LocationDetails { get; set; }
    }
}
