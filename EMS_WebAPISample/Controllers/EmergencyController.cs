using EMS_WebAPISample.EmergencyModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmergencyController : ControllerBase
    {
        private readonly ILogger<EmergencyController> _logger;

        public EmergencyController(ILogger<EmergencyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetById")]
        public IEnumerable<Emergency> GetById(int EmergencyId)
        {
            // Emergency obk = new Emergency();
            //emp.entryType.EntryTypeId = (int)EntryTypeEnum.Current;
            return null;
        }

        [HttpPost]
        [Route("ManageEmergency")]
        public IEnumerable<Emergency> ManageEmergency(Emergency emp)
        {
            if (emp != null)
            {
                if (emp.entryType.EntryTypeId == 1)
                {
                    emp.entryType.entryDetails.ActivationDateTime = null;
                    emp.entryType.entryDetails.DeactivationDateTime = null;
                    emp.entryType.entryDetails.ReasonLateEntry = null;
                    emp.entryType.entryDetails.Remarks = null;
                }
            }
            if (emp.codeBlueDetails != null)
            {

            }
            return null;
        }
    }
}
