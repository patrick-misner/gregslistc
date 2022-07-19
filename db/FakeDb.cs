using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslistc.Models;

namespace gregslistc.db
{
  public static class FakeDb
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
            new Car
            (
              "Ford",
              "Pinto",
              1999,
              "A real piece of work",
              "https://thiscatdoesnotexist.com",
              "blue"
            )
        };
  }
}