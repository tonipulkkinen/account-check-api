using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace account_check_api.Controllers
{
    public class DataCheckController : ApiController
    {
        public string _accountNumber { get; set; }
        public string _referenceNumber { get; set; }
    }
}
