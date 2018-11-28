using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AgeCalcAngular.Calculations;
using AgeCalcAngular.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MediaTypeHeaderValue = System.Net.Http.Headers.MediaTypeHeaderValue;

namespace AgeCalcAngular.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeCalcController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ChildResult),(int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody]AgeCollection ageCollection)
        {
            var result = NormalCalc.CalculateWeight(ageCollection.Age, ageCollection.Weight);
            /*return new HttpResponseMessage()
            {
                Content = new StringContent(
                    $"{result}",
                    Encoding.UTF8,
                    "text/html"
                )
            };*/
            /*var response = new HttpResponseMessage(HttpStatusCode.OK);
            Request.crea
            response.Content = new StringContent(result);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
            return response;*/
            // return result;
            return Ok(result);
        }
    }
}