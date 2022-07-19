using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslistc.db;
using gregslistc.Models;

namespace gregslistc.Services
{
  public class CarsService
  {
    internal List<Car> Get()
    {
      return FakeDb.Cars;
    }
    internal Car Get(string id)
    {
      Car found = FakeDb.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
    internal Car Create(Car carData)
    {
      FakeDb.Cars.Add(carData);
      return carData;
    }
    internal Car Update(Car carData)
    {
      Car original = Get(carData.Id);
      original.Make = carData.Make ?? original.Make;
      original.Model = carData.Model ?? original.Model;
      original.Year = carData.Year ?? original.Year;
      original.Description = carData.Description ?? original.Description;
      original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;
      original.Color = carData.Color ?? original.Color;
      return original;
    }
    internal Car Delete(string id)
    {
      Car found = Get(id);
      FakeDb.Cars.Remove(found);
      return found;
    }
  }
}