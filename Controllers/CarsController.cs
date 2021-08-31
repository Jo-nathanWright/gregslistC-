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

    [HttpGet("{id}")]

    public ActionResult<Car> Get(string id)
    {
        try
        {
        Car found = _carsService.Get(id);
        return Ok(found);
      }
        catch (Exception err)
        {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]

    public ActionResult<Car> Create([FromBody] Car newCar)
    {
        try
        {
        Car car = _carsService.Create(newCar);
        return Ok(car);
      }
        catch (Exception err)
        {
        return BadRequest(err.Message);
      }
    }
  }
}