using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ValidateString
{
    public static class ValidateStringFuncApp
    {
        [FunctionName("ValidateStringFuncApp")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string responseMessage;
            string stringToValidate = req.Query["toValidate"];

            if (stringToValidate == null)
                responseMessage = "No string received";
            else if (stringToValidate.Length == 0)
                responseMessage = "Empty string received";
            else                       
                responseMessage = Solution.ValidateString(stringToValidate)
                    ? "String is valid"
                    : "String is not valid";           

            return new OkObjectResult(responseMessage);
        }
    }
}
