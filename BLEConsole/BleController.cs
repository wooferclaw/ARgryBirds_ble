using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BLEConsole
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[Route("api/{controller}/{color}")]
    public class BleController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(int color)
        {
            var exitCode = Program.WriteCharacteristic($"#02/#0 {color}").Result;

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}