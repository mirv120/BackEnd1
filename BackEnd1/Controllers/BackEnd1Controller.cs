using Microsoft.AspNetCore.Mvc;

namespace BackEnd1;

[Route("api/[controller]")]
[ApiController]
public class BackEnd1Controller : ControllerBase
{
    private const int BackEnd1Result = 42;

    [HttpGet]
    public int GetBackEndResult()
    {
        Thread.Sleep(500);  //arbitrary sleep per requirements
        return BackEnd1Result;
    }
}