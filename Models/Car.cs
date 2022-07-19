using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslistc.Models
{
  public class Car
  {
    public Car(
        string make,
        string model,
        int year,
        string description,
        string imgUrl,
        string color
        )
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Description = description;
      ImgUrl = imgUrl;
      Color = color;

    }
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int? Year { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public string Color { get; set; }
  }
}