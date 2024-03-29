﻿using EMS_WebAPISample.EmergencyModel;
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
        [Route("DeactivateEmergencyStatus")]
        public async Task<IActionResult> DeactivateEmergencyStatus(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            bool result = true;  // only return true
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost]
        [Route("ManageCodeBlueEmergencyStatus")]
        public async Task<IActionResult> ManageCodeBlueEmergencyStatus(CodeBlueEmergencyModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "CodeBlueEmergencyModel"
            int result = 0;   // check only return true or not
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet]
        [Route("GetCodeBlueEmergencyStatusById")]
        public async Task<IActionResult> GetCodeBlueEmergencyStatusById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            CodeBlueEmergencyModel result = new CodeBlueEmergencyModel();  // return CodeBlueEmergency Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost]
        [Route("ManageCodePinkEmergencyStatus")]
        public EmergencyModel.EmergencyModel ManageCodePinkEmergencyStatus(CodeBlueEmergencyModel emp) // Change to CodePinkEmergencyModel
        {
            return null;
        }

        [HttpGet]
        [Route("GetCodePinkEmergencyStatusById")]
        public IEnumerable<EmergencyModel.EmergencyModel> GetCodePinkEmergencyStatusById(int EmergencyId)
        {
            return new List<EmergencyModel.EmergencyModel>();
        }

        [HttpPost]
        [Route("ManagePostEventAnalysis")]
        public async Task<IActionResult> ManagePostEventAnalysis(PostEventAnalysisModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "PostEventAnalysisModel"
            int result = 0;   // check only return true or not
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet]
        [Route("GetPostEventAnalysisById")]
        public async Task<IActionResult> GetPostEventAnalysisById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            PostEventAnalysisModel result = new PostEventAnalysisModel();  // return PostEventAnalysis Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost]
        [Route("ManageEmergencyVerification")]
        public async Task<IActionResult> ManageEmergencyVerification(EmergencyVerificationModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "PostEventAnalysisModel"
            int result = 0;   // check only return true or not
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet]
        [Route("GetEmergencyVerificationById")]
        public async Task<IActionResult> GetEmergencyVerificationById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyVerificationModel result = new EmergencyVerificationModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost]
        [Route("ManageEmergencyAssignedAction")]
        public async Task<IActionResult> ManageEmergencyAssignedAction(EmergencyActionAssignedModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "PostEventAnalysisModel"
            int result = 0;   // return Employee Notification Model to send email notification
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet]
        [Route("GetEmergencyAssignedActionById")]
        public async Task<IActionResult> GetEmergencyAssignedActionById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionAssignedModel result = new EmergencyActionAssignedModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost]
        [Route("ManageEmergencyActionTaken")]
        public async Task<IActionResult> ManageEmergencyActionTaken(EmergencyActionTakenModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "EmergencyActionTakenModel"
            int result = 0;   // return Employee Notification Model to send email notification
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet]
        [Route("GetEmergencyActionTakenById")]
        public async Task<IActionResult> GetEmergencyActionTakenById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionTakenModel result = new EmergencyActionTakenModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost]
        [Route("ManageEmergencyActionClosure")]
        public async Task<IActionResult> ManageEmergencyActionClosure(EmergencyActionClosureModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "EmergencyActionTakenModel"
            int result = 0;   // return true
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet]
        [Route("GetEmergencyActionClosureById")]
        public async Task<IActionResult> GetEmergencyActionClosureById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionClosureModel result = new EmergencyActionClosureModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }
    }
}
