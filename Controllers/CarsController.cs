using System;
using Microsoft.AspNetCore.Mvc;
using gregslist.Service;
using System.Collections.Generic;
using gregslist.Models;

namespace gregslist.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CarsController : ControllerBase
    {
    private readonly CarsService _carsService;
    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }

    [HttpGet] // Get All Function
    public ActionResult<IEnumerable<Car>> Get()
    {
        try
        {
        IEnumerable<Car> cars = _carsService.Get();

        return Ok(cars);
      }
        catch (Exception err)
        {
        return BadRequest(err.Message);
      }
    }
  }
}