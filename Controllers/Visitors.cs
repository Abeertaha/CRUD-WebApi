using System;
using Microsoft.AspNetCore.Mvc;

namespace Visitors.Controllers;

[ApiController]
[Route("[controller]")]
public class Visitors : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string [] {"Visitor1","Visitor2"};
    }

    [HttpGet("{id}")] 
    public ActionResult<string> Get(int id)
    {
        return "id";
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        try 
        {
            string Visitor = string.Empty;
        }
    
        catch (Exception ex)
        {
            string Visitor = ex.Message;
        }      
            }

        }

