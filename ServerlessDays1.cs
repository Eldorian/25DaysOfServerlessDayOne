using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace My.Function
{
    public static class ServerlessDays1
    {
        [FunctionName("ServerlessDays1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var values = new string[]{"נ (Nun)", "ג (Gimmel)", "ה (hay)", "ש (Shin)"};
            int index = new Random().Next(values.Length);

            return (ActionResult)new OkObjectResult($"{values[index]}");
        }
    }
}
