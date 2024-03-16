using EMS_WebAPISample.EmergencyModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EMS_WebAPISample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmergencyController : ControllerBase
    {
        private readonly ILogger<EmergencyController> _logger;
        private readonly IResponseHandler<dynamic> _ObjectResponse;

        public EmergencyController(ILogger<EmergencyController> logger, IResponseHandler<dynamic> ObjectResponse)
        {
            _logger = logger;
            _ObjectResponse = ObjectResponse;
        }


        [HttpPost]
        [Route("ManageEmergency")]
        public async Task<IActionResult> ManageEmergency(EmergencyModel.EmergencyModel emp)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":0,""entryType"":{ ""entryTypeId"":1,""entryDetails"":{ ""activationDateTime"":null,""deactivationDateTime"":null,""reasonLateEntry"":null,""remarks"":null} },""codeTypeId"":1,""locationId"":2,""locationDetails"":""Hello"",""codeBlueDetails"":{ ""victimDetails"":{ ""victimTypeId"":1,""victimRefNo"":""12345"",""victimCondition"":[""Unconsious""]},""checkList"":{ ""checklist1"":true,""checklist1Reason"":""Hello1"",""checklist2"":true,""checklist2Reason"":""Hello2"",""checklist3"":true,""checklist3Reason"":""Hello3""} },""codePinkDetails"":{ },""codeHazmatDetails"":{ },""codePurpleDetails"":{ },""codeGreyDetails"":{ },""codeRedDetails"":{ },""codeBlackDetails"":{ },""createdDate"":""2024 - 03 - 15T10: 51:46.302Z"",""updatedDate"":""2024 - 03 - 15T10: 51:46.302Z"",""isActivated"":true}""}";
            EmployeeNotification result = new EmployeeNotification();  // return EmergencyId, Employee Notification Details and Location details
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyModel.EmergencyModel result = new EmergencyModel.EmergencyModel();  // return Employee Model details to diplay Active Emergency page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost]
        [Route("ManageActiveEmergency")]
        public EmergencyModel.EmergencyModel ManageActiveEmergency(CodeBlueEmergencyModel emp)
        {

            return null;
        }

        [HttpGet]
        [Route("GetActiveEmergencyById")]
        public IEnumerable<EmergencyModel.EmergencyModel> GetActiveEmergencyById(int EmergencyId)
        {
            return new List<EmergencyModel.EmergencyModel>();
        }

        [HttpPost]
        [Route("EmergencyPostEventAnalysis")]
        public EmergencyModel.EmergencyModel EmergencyPostEventAnalysis(PostEventAnalysisModel emp)
        {

            return null;
        }

        [HttpGet]
        [Route("GetPostEventAnalysisById")]
        public IEnumerable<EmergencyModel.EmergencyModel> GetPostEventAnalysisById(int EmergencyId)
        {
            return new List<EmergencyModel.EmergencyModel>();
        }

        [HttpPost]
        [Route("EmergencyVerification")]
        public EmergencyModel.EmergencyModel EmergencyVerification(EmergencyVerificationModel emp)
        {

            return null;
        }

        [HttpGet]
        [Route("GetEmergencyVerificationById")]
        public IEnumerable<EmergencyModel.EmergencyModel> GetEmergencyVerificationById(int EmergencyId)
        {
            return new List<EmergencyModel.EmergencyModel>();
        }

        [HttpPost]
        [Route("EmergencyAction")]
        public EmergencyModel.EmergencyModel EmergencyActions(EmergencyActionModel emp)
        {

            return null;
        }

        [HttpGet]
        [Route("GetEmergencyActionById")]
        public IEnumerable<EmergencyModel.EmergencyModel> GetEmergencyActionById(int EmergencyId)
        {
            return new List<EmergencyModel.EmergencyModel>();
        }

        [HttpPost]
        [Route("EmergencyActionClosure")]
        public EmergencyModel.EmergencyModel EmergencyActionClosure(EmergencyActionClosureModel emp)
        {

            return null;
        }

        [HttpGet]
        [Route("GetEmergencyActionClosureById")]
        public IEnumerable<EmergencyModel.EmergencyModel> GetEmergencyActionClosureById(int EmergencyId)
        {
            return new List<EmergencyModel.EmergencyModel>();
        }
    }
}
