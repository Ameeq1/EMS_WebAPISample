using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample
{
    public interface IResponseHandler<T> where T : class
    {
        IActionResult Create(T? Data, int? StatusCode, string? Message = null, string? ReturnToUrl = null, List<string> errorMessages = null);

        //IActionResult CreateError(T Data, int? StatusCode, Exception? errorMessages = null, string? Message = null, string? ReturnToUrl = null);

        //IActionResult CreateData(T? Data, int? StatusCode);
    }
}
