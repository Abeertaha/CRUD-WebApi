using Microsoft.AspNetCore.Mvc;
using VisitorApi.Models;
using System.Collections.Generic;

namespace Visitors.Controllers;

[ApiController]
[Route("[controller]/[action]")]

public class VisitorController : ControllerBase
{
    public static List<Visitor> VisitorDatabase = new List<Visitor>();

    [HttpGet]
    public List<Visitor> Get()
    {
        return VisitorDatabase;
    }

    [HttpPost] 
    public string Add(int id, string name, string LastName)
    {
        Visitor visitor = new Visitor
        {
            Id = id,
            Name = name,
            LastName = LastName,
        };

        VisitorDatabase.Add(visitor);
        return "Visitor Added successfully" + "" + visitor.Name;
    }
    
    [HttpPut]
    public string Update(Visitor visitor)
    {
        return $"Visitor Updated: {visitor.Id} {visitor.Name} {visitor.LastName}";
    }

    [HttpDelete]
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

        Console.WriteLine("Visitor Deleted Successfully{id}");

            }
        }