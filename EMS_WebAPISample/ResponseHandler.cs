using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample
{
    public class ResponseHandler<T> : IResponseHandler<T> where T : class
    {
        public IActionResult Create(T Data, int? StatusCode, string Message = null, string ReturnToUrl = null, List<string> errorMessages = null)
        {
            CommonAPIResponse<T> retResult = new CommonAPIResponse<T><T>();
            retResult._object = Data;
            retResult._Message = Message;
            retResult._ReturnToUrl = ReturnToUrl;
            retResult._errorMessages = errorMessages;

            if (StatusCode == 200)
                retResult._Success = true;
            else
                retResult._Success = false;

            return new ObjectResult(retResult) { StatusCode = StatusCode };
        }
    }
}
