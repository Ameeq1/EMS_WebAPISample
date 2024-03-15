using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample.Controllers
{
    [ApiController]
    public class EmergencyDetailsController : ControllerBase
    {
        private readonly ILogger<EmergencyDetailsController> _logger;

        public EmergencyDetailsController(ILogger<EmergencyDetailsController> logger)
        {
            _logger = logger;
        }
    }
}
