
using Microsoft.AspNetCore.Mvc;

namespace NannoA_Say_Hello_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloEndPoint : ControllerBase
    {
        [HttpPost]
        [Route("SayHelloApi/{name}")]
         
    public string sayHelloApi(string name)
    {
        return $"Hello {name}, how are you doing today?";
    }
}
 