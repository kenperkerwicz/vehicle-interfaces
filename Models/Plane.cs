using System;
using System.Linq;
using System.Collections.Generic;

namespace LeanAndMean {

   public class Plane : IAir
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public bool Winged { get; set; } = true;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxWaterSpeed { get; set; }
  public double MaxLandSpeed { get; set; }
  public double MaxAirSpeed { get; set; } = 309.0;

  public void Drive()
  {
    throw new NotImplementedException();
  }

  public void Fly()
  {
    Console.WriteLine("The Plane gets high");
  }

  public void Start()
  {
    throw new NotImplementedException();
  }

  public void Stop()
  {
    throw new NotImplementedException();
  }
}
}