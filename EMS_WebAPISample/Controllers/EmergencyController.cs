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
        public IEnumerable<Emergency> GetById()
        {
            return null;
        }

        [HttpPost]
        [Route("ManageEmergency")]
        public IEnumerable<Emergency> ManageEmergency()
        {
            return null;
        }
    }
}
