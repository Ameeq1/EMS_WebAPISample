using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample
{
    public class CommonAPIResponse<T> where T : class
    {
        public T _object { get; set; }
        public string _Message { get; set; }

        public bool _Success { get; set; }

        public string _ReturnToUrl { get; set; }


        public List<string> _errorMessages = new List<string>();
    }
}
