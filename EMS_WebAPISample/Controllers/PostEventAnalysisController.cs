using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample.Controllers
{
    [ApiController]
    public class PostEventAnalysisController : ControllerBase
    {
        private readonly ILogger<PostEventAnalysisController> _logger;

        public PostEventAnalysisController(ILogger<PostEventAnalysisController> logger)
        {
            _logger = logger;
        }
    }
}
