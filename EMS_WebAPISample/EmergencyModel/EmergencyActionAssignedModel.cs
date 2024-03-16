using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample.EmergencyModel
{
    public class EmergencyActionAssignedModel
    {
        public List<ActionAssignItem> actionItem { get; set; }
    }

    public class ActionAssignItem
    {
        public string ActionDescription { get; set; }
        public List<string> ActionAssignTo { get; set; }
        public DateTime? ActionCompletedBy { get; set; }
    }
}
