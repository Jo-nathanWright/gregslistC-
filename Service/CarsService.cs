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
    }
}