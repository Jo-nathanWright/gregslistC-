using System;
using System.Collections.Generic;
using gregslist.Models;
using gregslist.Service;
using Microsoft.AspNetCore.Mvc;

namespace gregslist.Controllers
{
    [ApiController]

    [Route("/api/[controller]")]
    public class HousesController : ControllerBase
    {
    private readonly HousesService _houseService;

    public HousesController(HousesService housesService)
    {
      _houseService = housesService;
    }

    [HttpGet]

    public ActionResult<IEnumerable<House>> Get()
    {
        try
        {
        IEnumerable<House> houses = _houseService.Get();

        return Ok(houses);
      }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpGet("{id}")]

    public ActionResult<House> Get(string id)
    {
        try
        {
          House found = _houseService.Get(id);
          return Ok(found);
        }
        catch (Exception err)
        {
          return BadRequest(err.Message);
        }
    }

    [HttpPost]

    public ActionResult<House> Create([FromBody] House newHouse)
    {
        try
        {
        House house = _houseService.Create(newHouse);
        return Ok(house);
      }
        catch (Exception err)
        {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]

    public ActionResult<House> Delete(string id)
    {
        try
        {
        _houseService.Delete(id);
        return Ok("Successfully Deleted That House");
      }
        catch (Exception err)
        {
        return BadRequest(err.Message);
      }
    }
  }
}