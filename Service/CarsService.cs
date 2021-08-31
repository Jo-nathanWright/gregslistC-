using System;
using System.Collections.Generic;
using gregslist.Models;

namespace gregslist.Service
{
    public class CarsService
    {
        internal IEnumerable<Car> Get()
        {
          return FakeDB.Cars;
        }

        internal Car Get(string id)
        {
          Car found = FakeDB.Cars.Find(c => c.Id == id);
          if (found == null){
            throw new Exception("Invalid Id");
          }
          return found;
        }

        internal Car Create(Car newCar)
        {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }
    }
}